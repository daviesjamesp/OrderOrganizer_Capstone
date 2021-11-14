
namespace OrderOrganizer_Capstone.Forms
{
    partial class PayInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.expiryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number:";
            // 
            // doneButton
            // 
            this.doneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doneButton.Location = new System.Drawing.Point(140, 115);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(106, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(12, 25);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.ReadOnly = true;
            this.cardNumberTextBox.Size = new System.Drawing.Size(234, 20);
            this.cardNumberTextBox.TabIndex = 2;
            this.cardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // expiryTextBox
            // 
            this.expiryTextBox.Location = new System.Drawing.Point(12, 64);
            this.expiryTextBox.Name = "expiryTextBox";
            this.expiryTextBox.ReadOnly = true;
            this.expiryTextBox.Size = new System.Drawing.Size(78, 20);
            this.expiryTextBox.TabIndex = 4;
            this.expiryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expiry:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(106, 64);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(140, 20);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Billing Address:";
            // 
            // PayInfoForm
            // 
            this.AcceptButton = this.doneButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.doneButton;
            this.ClientSize = new System.Drawing.Size(257, 150);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expiryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Information";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayInfoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox expiryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label3;
    }
}