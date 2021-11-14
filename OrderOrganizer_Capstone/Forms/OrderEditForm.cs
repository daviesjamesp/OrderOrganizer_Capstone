using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLib;
using OrderOrganizer_Capstone.Objects;

namespace OrderOrganizer_Capstone.Forms
{
    public partial class OrderEditForm : Form
    {
        public order EditingOrder { get; }

        public event EventHandler<OrderEventArgs> OrderUpdating;
        public event EventHandler<OrderEventArgs> PaymentInfoShown;

        public OrderEditForm(order editingOrder)
        {
            InitializeComponent();
            EditingOrder = editingOrder;
            FormatOrderToControls();
        }

        private void FormatOrderToControls()
        {
            rawTextBox.Text = EditingOrder.raw_text;
            createdByTextBox.Text = EditingOrder.user.user_name;
            createdOnTextBox.Text = EditingOrder.created_on.ToString("g");

            if (EditingOrder.extracted_infos != null)
            {
                if (!string.IsNullOrEmpty(EditingOrder.extracted_infos.part_code))
                    partCodeTextBox.Text = EditingOrder.extracted_infos.part_code;
                if (!string.IsNullOrEmpty(EditingOrder.extracted_infos.phone_number))
                    phoneTextBox.Text = EditingOrder.extracted_infos.phone_number;
                if (EditingOrder.extracted_infos.stock_number.HasValue)
                    stockNumberTextBox.Text = EditingOrder.extracted_infos.stock_number.Value.ToString();
            }
            else
            {
                extractedGroupBox.Enabled = false;
            }

            var orderStatusControlName = "statusRbtn" + EditingOrder.order_status.ToString();
            (this.Controls.Find(orderStatusControlName, true).First() as RadioButton).Checked = true;

            hasPaymentTextBox.Text = EditingOrder.payment is null ? "NO" : "YES";
            showPayInfoButton.Enabled = !(EditingOrder.payment is null);
        }

        private void showPayInfoButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("WARNING: Only proceed when ready to charge the card. Payment info will be removed after it is shown. Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response != DialogResult.Yes) return;

            var newPayInfoForm = new PayInfoForm(EditingOrder.payment);
            newPayInfoForm.ShowDialog();

            hasPaymentTextBox.Text = "NO";

            PaymentInfoShown(this, new OrderEventArgs() { Order = EditingOrder });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EditingOrder.raw_text = rawTextBox.Text;

            var checkedStatusControlName = "";
            foreach (var c in statusGroupBox.Controls)
            {
                var asRadio = c as RadioButton;
                if (asRadio is null) continue;
                if (asRadio.Checked)
                {
                    checkedStatusControlName = asRadio.Name;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(checkedStatusControlName))
            {
                EditingOrder.order_status = int.Parse(checkedStatusControlName.Substring(checkedStatusControlName.Length - 1, 1));
            }

            OrderUpdating(this, new OrderEventArgs() { Order = EditingOrder });
            Close();
        }
    }
}
