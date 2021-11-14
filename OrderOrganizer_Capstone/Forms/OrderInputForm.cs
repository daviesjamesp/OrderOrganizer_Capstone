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
using System.Text.RegularExpressions;

namespace OrderOrganizer_Capstone.Forms
{
    public partial class OrderInputForm : Form
    {
        public event EventHandler<OrderEventArgs> OrderAdding;

        private RadioButton[] statusSelectionControls;
        private user loggedInUser;

        public OrderInputForm()
        {
            InitializeComponent();
            statusSelectionControls = new RadioButton[] { statusRbtn0, statusRbtn1, statusRbtn2, statusRbtn3 };
        }

        public void SetCurrentUser(user newUser)
        {
            loggedInUser = newUser;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            
            var newOrderEventArgs = ExtractDetails();

            OrderAdding(this, newOrderEventArgs);
            ClearForm();
        }

        private bool ValidateData()
        {
            if (rawTextBox.Text.Length == 0)
            {
                MessageBox.Show("Order must have text.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            var hasStatus = false;
            foreach (var rbtn in statusSelectionControls)
            {
                if (rbtn.Checked) hasStatus = true;
            }
            if (!hasStatus)
            {
                MessageBox.Show("Order must have a status selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private OrderEventArgs ExtractDetails()
        {
            var newOrder = new order();

            newOrder.created_by = loggedInUser.user_id;
            newOrder.created_on = DateTime.Now;
            newOrder.raw_text = rawTextBox.Text.Replace("/","").Replace(";","").Replace("\'","").Replace("\"",""); // Basic input sanitization

            var statusIndex = -1;
            for (int i = 0; i < statusSelectionControls.Length; i++)
            {
                if (statusSelectionControls[i].Checked) statusIndex = i;
            }
            newOrder.order_status = statusIndex;

            newOrder.extracted_infos = GetExtractedInfo();
            newOrder.payment = GetPaymentInfo();
            if (newOrder.payment != null)
            {
                newOrder.raw_text = newOrder.raw_text.Replace(newOrder.payment.card_number, "[CARD NUMBER REMOVED]");
                newOrder.raw_text = newOrder.raw_text.Replace(newOrder.payment.expire_date.Replace("/", ""), "[EXPIRY DATE REMOVED]");
            }

            return new OrderEventArgs() { Order = newOrder };
        }

        private extracted_infos GetExtractedInfo()
        {
            var part_code = MatchRegexFromRawText("[A-Z]{3}");
            var phone_number = MatchRegexFromRawText("\\d{10}");
            var stock_number_string = MatchRegexFromRawText("1\\d{4}");

            if (part_code is null && phone_number is null && stock_number_string is null)
                return null;
            else
            {
                var newExtInfo = new extracted_infos();
                newExtInfo.part_code = part_code;
                newExtInfo.phone_number = phone_number;
                if (!string.IsNullOrEmpty(stock_number_string))
                    newExtInfo.stock_number = int.Parse(stock_number_string);
                return newExtInfo;
            }
        }

        private payment GetPaymentInfo()
        {
            var card_number = MatchRegexFromRawText("\\d{15,16}");

            var expiration = MatchRegexFromRawText("\\d{1,2}/\\d{2,4}");
            if (expiration != null)
            {
                var splitExp = expiration.Split('/');
                if (splitExp[1].Length > 2)
                {
                    splitExp[1] = splitExp[1].Substring(splitExp[1].Length - 2);
                    expiration = splitExp[0] + '/' + splitExp[1];
                }
            }
        

            var addressString = MatchRegexFromRawText("\\d{1,}/\\d{5}");
            string number = "", zip = "";
            if (!string.IsNullOrEmpty(addressString))
            {
                number = addressString.Split('/')[0];
                zip = addressString.Split('/')[1];
            }

            if (card_number is null || expiration is null)
                return null;
            else
            {
                var newPayment = new payment();
                newPayment.card_number = card_number;
                newPayment.expire_date = expiration;
                if (!string.IsNullOrEmpty(addressString))
                {
                    newPayment.billing_address = number;
                    newPayment.billing_zip = int.Parse(zip);
                }

                return newPayment;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearForm(true);
        }

        private void ClearForm(bool confirm = false)
        {
            if (confirm)
            {
                var response = MessageBox.Show("Are you sure you want to clear?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response != DialogResult.Yes) return;
            }

            rawTextBox.Text = "";
            foreach (var rbtn in statusSelectionControls)
            {
                rbtn.Checked = false;
            }
        }

        private string MatchRegexFromRawText(string pattern)
        {
            var patternL = "\\s" + pattern + "\\s?"; 
            var patternR = "\\s?" + pattern + "\\s"; 

            var matchL = Regex.Match(rawTextBox.Text, patternL);
            var matchR = Regex.Match(rawTextBox.Text, patternR);

            if (matchL.Success) return matchL.Value.Trim();
            if (matchR.Success) return matchR.Value.Trim();

            return null;
        }

        public void OrderInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
