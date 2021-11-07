using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderOrganizer_Capstone.Objects;
using DatabaseLib;

namespace OrderOrganizer_Capstone.Forms
{
    public partial class OrderListForm : Form
    {
        public event EventHandler<OrderEventArgs> OrderOpening;

        private OO_dbEntities dbcontext;
        private CheckBox[] statusFilterCheckBoxes;

        public OrderListForm(OO_dbEntities _dbcontext)
        {
            InitializeComponent();
            dbcontext = _dbcontext;
            statusFilterCheckBoxes = new CheckBox[] { status0, status1, status2, status3 };
            dateFilterTypeCombo.SelectedIndex = 0;
        }

        private void FillListColumns(object _, EventArgs e)
        {
            var adjustedWidth = orderListView.Size.Width - 5;
            int fifteenPercent = Convert.ToInt32(adjustedWidth * 0.15);
            int fortyPercent = Convert.ToInt32(adjustedWidth * 0.4);

            for (int i = 0; i < 4; i++)
            {
                orderListView.Columns[i].Width = fifteenPercent;
            }

            orderListView.Columns[4].Width = fortyPercent;
        }

        public void RefreshOrderList(object _, EventArgs e)
        {
            orderListView.Items.Clear();
            foreach (var o in GetFilteredList())
            {
                orderListView.Items.Add(ConvertToLVI(o));
            }
        }

        private ListViewItem ConvertToLVI(order o)
        {
            return new ListViewItem(new string[] {
                o.created_on.ToShortDateString(),
                o.user.user_name,
                (o.extracted_infos is null ? "NO" : "YES"),
                (o.payment is null ? "NO" : "YES"),
                (o.raw_text.Length > 40 ? o.raw_text.Substring(0, 40) + "..." : o.raw_text)
            });
        }

        private void ResetFilters(object _, EventArgs e)
        {
            date1.Value = DateTime.Today;
            date2.Value = DateTime.Today;
            dateFilterTypeCombo.SelectedIndex = 0;
            foreach (var cbox in statusFilterCheckBoxes)
            {
                cbox.Checked = true;
            }
            searchTextBox.Text = "";
            RefreshOrderList(_, e);
        }

        private void OrderListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void dateFilterTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = dateFilterTypeCombo.SelectedIndex;
            switch (selected)
            {
                case 0:
                    date1.Enabled = false;
                    date2.Enabled = false;
                    throughLabel.Visible = false;
                    break;
                case 1:
                    date1.Enabled = true;
                    date2.Enabled = false;
                    throughLabel.Visible = false;
                    break;
                case 2:
                    date1.Enabled = true;
                    date2.Enabled = true;
                    throughLabel.Visible = true;
                    break;
                default:
                    break;
            }
            RefreshOrderList(sender, e);
        }

        private List<order> GetFilteredList()
        {
            List<order> filteredCollection = new List<order>();
            filteredCollection.AddRange(dbcontext.orders);

            if (searchTextBox.Text.Length > 1)
            {
                filteredCollection = filteredCollection.Where(o => o.raw_text.Contains(searchTextBox.Text)).ToList();
            }

            switch (dateFilterTypeCombo.SelectedIndex)
            {
                case 1:
                    filteredCollection = filteredCollection.Where(o => o.created_on.Date == date1.Value.Date).ToList();
                    break;
                case 2:
                    filteredCollection = filteredCollection.Where(o => o.created_on.Date >= date1.Value.Date && o.created_on.Date <= date2.Value.Date).ToList();
                    break;
                default:
                    break;
            }

            for (int i = 0; i < statusFilterCheckBoxes.Length; i++)
            {
                if (statusFilterCheckBoxes[i].Checked) continue;
                else filteredCollection = filteredCollection.Where(o => o.order_status != i).ToList();
            }

            return filteredCollection;
        }

        private void orderListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (orderListView.SelectedIndices.Count == 0) return;
            var selectedItemTextSubstring = orderListView.SelectedItems[0].SubItems[4].Text.Substring(0, 40);

            var editOrder = dbcontext.orders.Where(o => o.raw_text.Substring(0, 40) == selectedItemTextSubstring).FirstOrDefault();

            if (editOrder is null)
            {
                MessageBox.Show("Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrderOpening(this, new OrderEventArgs() { Order = editOrder });
            }
        }
    }
}
