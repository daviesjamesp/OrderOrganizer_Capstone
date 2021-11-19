
namespace OrderOrganizer_Capstone.Forms
{
    partial class ServerSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(16, 105);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(508, 26);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.Text = "jrp!serv32#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database Password:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(16, 36);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(228, 26);
            this.ipTextBox.TabIndex = 7;
            this.ipTextBox.Text = "73.193.75.115";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host IP Address:";
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(393, 204);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(131, 45);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(16, 204);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(131, 45);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(296, 36);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(228, 26);
            this.portTextBox.TabIndex = 11;
            this.portTextBox.Text = "3122";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Server Port:";
            // 
            // ServerSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 263);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSetupForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerSetupForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label3;
    }
}