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
using DatabaseLib;
using OrderOrganizer_Capstone.Objects;
using OrderOrganizer_Capstone.Forms;
using System.Data.Entity;

namespace OrderOrganizer_Capstone
{
    public partial class Main : Form
    {
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
            InstantiateKeyObjects();
            LoadDbcontext();
            PromptForLogin();
        }

        private void InstantiateKeyObjects()
        {
            dbcontext = new OO_dbEntities();
            
            userManager = new UserManager(dbcontext);
            orderManager = new OrderManager(dbcontext);

            orderInputForm = new OrderInputForm();
            orderInputForm.MdiParent = this;
            orderInputForm.OrderAdding += orderManager.AddOrderToDB;

            orderListForm = new OrderListForm(dbcontext);
            orderListForm.MdiParent = this;
            orderManager.OrderAdded += orderListForm.RefreshOrderList;
            orderListForm.OrderOpening += OpenOrderForEdit;

            // TODO needs more here.
        }

        private void LoadDbcontext()
        {
            dbcontext.users.Load();
            dbcontext.orders.Load();
            dbcontext.payments.Load();
            dbcontext.extracted_infos.Load();
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
            Text = "Order Organizer - Logged in as " + loggedInUser.user_name;
            if (loggedInUser.user_admin) Text += " (Admin)";

            orderInputForm.SetCurrentUser(loggedInUser);

            // TODO fill in here with other admin/regular user stuff
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

        }
    }
}
