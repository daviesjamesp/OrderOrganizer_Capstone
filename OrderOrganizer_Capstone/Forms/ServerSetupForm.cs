using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DatabaseLib;

namespace OrderOrganizer_Capstone.Forms
{
    public partial class ServerSetupForm : Form
    {
        public string HostName { get; private set; }
        public string Password { get; private set; }
        public string Port { get; private set; }

        public ServerSetupForm()
        {
            InitializeComponent();
        }

        private void ServerSetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var dbcontext = new OO_dbEntities();
            var connectionString = dbcontext.Database.Connection.ConnectionString;
            connectionString = connectionString.Replace("_HOST_", ipTextBox.Text).Replace("_PASS_", passwordTextBox.Text).Replace("port=0", "port=" + portTextBox.Text);
            dbcontext.Database.Connection.ConnectionString = connectionString;

            try
            {
                dbcontext.Database.Connection.Open();
                MessageBox.Show("Connection test succeeded!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                acceptButton.Enabled = true;
            }
            catch (Exception ex) //TODO refine this type
            {
                MessageBox.Show($"Connection test failed! Revise inputs.\n{ex.GetType().Name}: {ex.Message}");
            }
            finally
            {
                dbcontext.Dispose();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            FormClosing -= ServerSetupForm_FormClosing;
            HostName = ipTextBox.Text;
            Password = passwordTextBox.Text;
            Port = portTextBox.Text;
            Close();
        }
    }
}
