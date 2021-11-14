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

namespace OrderOrganizer_Capstone.Forms
{
    public partial class PayInfoForm : Form
    {
        public PayInfoForm(payment payInfo)
        {
            InitializeComponent();
            cardNumberTextBox.Text =
                payInfo.card_number.Substring(0, 4) + " " +
                payInfo.card_number.Substring(4, 4) + " " +
                payInfo.card_number.Substring(8, 4) + " " +
                payInfo.card_number.Substring(12, 4);
            expiryTextBox.Text = payInfo.expire_date;
            addressTextBox.Text = payInfo.billing_address + " / " + payInfo.billing_zip;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PayInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var response = MessageBox.Show("WARNING: Are you sure this transaction is completed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response != DialogResult.Yes) e.Cancel = true;
        }
    }
}
