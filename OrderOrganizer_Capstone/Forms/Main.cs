using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DatabaseLib;
using OrderOrganizer_Capstone.Objects;
using OrderOrganizer_Capstone.Forms;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Configuration;

namespace OrderOrganizer_Capstone
{
    public partial class Main : Form
    {
        private readonly string configFile = Application.StartupPath + "\\oo.config";
        private string hostString, passString, portString;
        
        private OO_dbEntities dbcontext;
        private UserManager userManager;
        private OrderManager orderManager;

        private OrderInputForm orderInputForm;
        private OrderListForm orderListForm;
        private List<OrderEditForm> orderEditForms = new List<OrderEditForm>(5);

        private user loggedInUser;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetServerSetup();
            InstantiateKeyObjects();
            TestConnection();
            LoadDbcontext();
            PromptForLogin();
        }

        private void TestConnection()
        {
            try
            {
                dbcontext.Database.Connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Server configuration data is incorrect, or the server may be offline. Please reopen application and reenter server credentials.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (File.Exists(configFile)) File.Delete(configFile);
                Application.Exit();
            }
        }

        private void GetServerSetup()
        {
            if (File.Exists(configFile))
            {
                var splitText = File.ReadAllLines(configFile);
                if (splitText.Length != 3)
                    throw new ArgumentException("Configuration file corrupted");
                hostString = splitText[0];
                passString = splitText[1];
                portString = splitText[2];
            }
            else
            {
                var serverSetupForm = new ServerSetupForm();
                serverSetupForm.ShowDialog();

                using (StreamWriter writer = new StreamWriter(configFile))
                {
                    writer.WriteLine(serverSetupForm.HostName);
                    writer.WriteLine(serverSetupForm.Password);
                    writer.WriteLine(serverSetupForm.Port);
                }

                GetServerSetup();
            }
        }

        private void InstantiateKeyObjects()
        {
            dbcontext = new OO_dbEntities();
            var connectionString = dbcontext.Database.Connection.ConnectionString;
            connectionString = connectionString.Replace("_HOST_", hostString).Replace("_PASS_", passString).Replace("port=0", "port=" + portString);
            dbcontext.Database.Connection.ConnectionString = connectionString;
            
            userManager = new UserManager(dbcontext);
            orderManager = new OrderManager(dbcontext);

            orderInputForm = new OrderInputForm();
            orderInputForm.MdiParent = this;
            orderInputForm.OrderAdding += orderManager.AddOrderToDB;

            orderListForm = new OrderListForm(dbcontext);
            orderListForm.MdiParent = this;
            orderManager.OrderAdded += orderListForm.RefreshOrderList;
            orderListForm.OrderOpening += OpenOrderForEdit;
        }

        private void LoadDbcontext()
        {
            try
            {
                dbcontext.users.Load();
                dbcontext.orders.Load();
                dbcontext.payments.Load();
                dbcontext.extracted_infos.Load();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw new Exception("There was a problem initializing the database connection.", ex);
            }
            catch (InvalidOperationException)
            {
                // Object has been disposed of but the method was still called due to async connection methods when the app is closed. Ignore.
            }
            
        }

        private void PromptForLogin()
        {
            var newLoginForm = new LoginForm();
            newLoginForm.ShowDialog();

            var attemptedUser = userManager.ValidateUser(newLoginForm.UsernameAttempt, newLoginForm.PasswordAttempt);

            if (attemptedUser is null)
            {
                MessageBox.Show("Login attempt failed. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                loggedInUser = attemptedUser;
                PostLoginProcedures();
            }
        }

        private void PostLoginProcedures()
        {
            Text += " - Logged in as " + loggedInUser.user_name;
            if (loggedInUser.user_admin) Text += " (Admin)";

            orderInputForm.SetCurrentUser(loggedInUser);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            foreach (var child in this.MdiChildren)
            {
                child.Show();
            }
        }

        private void OpenOrderForEdit(object sender, OrderEventArgs e)
        {
            if (orderEditForms.Count == orderEditForms.Capacity)
            {
                MessageBox.Show("Too many Edit windows are open. Please close one or more and retry.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newEditForm = new OrderEditForm(e.Order);
            newEditForm.MdiParent = this;
            newEditForm.PaymentInfoShown += orderManager.RemovePayInfo;
            newEditForm.OrderUpdating += orderManager.UpdateOrder;
            newEditForm.OrderUpdating += orderListForm.RefreshOrderList;
            newEditForm.Show();
            orderEditForms.Add(newEditForm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            orderInputForm.FormClosing -= orderInputForm.OrderInputForm_FormClosing;
            orderListForm.FormClosing -= orderListForm.OrderListForm_FormClosing;
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }

            dbcontext.Dispose();

            Application.Exit();
        }
    }
}
