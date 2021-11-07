using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderOrganizer_Capstone.Forms
{
    public partial class LoginForm : Form
    {
        public string UsernameAttempt { get; private set; }
        public string PasswordAttempt { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UsernameAttempt = usernameTextBox.Text;
            PasswordAttempt = passwordTextBox.Text;
            FormClosing -= LoginForm_FormClosing;
            Close();
        }
    }
}
