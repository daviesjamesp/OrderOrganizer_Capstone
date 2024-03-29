﻿
namespace OrderOrganizer_Capstone.Forms
{
    partial class OrderInputForm
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
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.statusRbtn3 = new System.Windows.Forms.RadioButton();
            this.statusRbtn2 = new System.Windows.Forms.RadioButton();
            this.statusRbtn1 = new System.Windows.Forms.RadioButton();
            this.statusRbtn0 = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawTextBox
            // 
            this.rawTextBox.AcceptsReturn = true;
            this.rawTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawTextBox.Location = new System.Drawing.Point(8, 10);
            this.rawTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawTextBox.Multiline = true;
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(631, 198);
            this.rawTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(565, 224);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(213, 29);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusGroupBox.Controls.Add(this.statusRbtn3);
            this.statusGroupBox.Controls.Add(this.statusRbtn2);
            this.statusGroupBox.Controls.Add(this.statusRbtn1);
            this.statusGroupBox.Controls.Add(this.statusRbtn0);
            this.statusGroupBox.Location = new System.Drawing.Point(641, 12);
            this.statusGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusGroupBox.Size = new System.Drawing.Size(137, 195);
            this.statusGroupBox.TabIndex = 2;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Order Status";
            // 
            // statusRbtn3
            // 
            this.statusRbtn3.AutoSize = true;
            this.statusRbtn3.Location = new System.Drawing.Point(4, 159);
            this.statusRbtn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusRbtn3.Name = "statusRbtn3";
            this.statusRbtn3.Size = new System.Drawing.Size(98, 17);
            this.statusRbtn3.TabIndex = 3;
            this.statusRbtn3.TabStop = true;
            this.statusRbtn3.Text = "Order Complete";
            this.statusRbtn3.UseVisualStyleBackColor = true;
            // 
            // statusRbtn2
            // 
            this.statusRbtn2.AutoSize = true;
            this.statusRbtn2.Location = new System.Drawing.Point(4, 117);
            this.statusRbtn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusRbtn2.Name = "statusRbtn2";
            this.statusRbtn2.Size = new System.Drawing.Size(104, 17);
            this.statusRbtn2.TabIndex = 2;
            this.statusRbtn2.TabStop = true;
            this.statusRbtn2.Text = "Order In Process";
            this.statusRbtn2.UseVisualStyleBackColor = true;
            // 
            // statusRbtn1
            // 
            this.statusRbtn1.AutoSize = true;
            this.statusRbtn1.Location = new System.Drawing.Point(4, 75);
            this.statusRbtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusRbtn1.Name = "statusRbtn1";
            this.statusRbtn1.Size = new System.Drawing.Size(125, 17);
            this.statusRbtn1.TabIndex = 1;
            this.statusRbtn1.TabStop = true;
            this.statusRbtn1.Text = "Check and Call Back";
            this.statusRbtn1.UseVisualStyleBackColor = true;
            // 
            // statusRbtn0
            // 
            this.statusRbtn0.AutoSize = true;
            this.statusRbtn0.Location = new System.Drawing.Point(4, 34);
            this.statusRbtn0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusRbtn0.Name = "statusRbtn0";
            this.statusRbtn0.Size = new System.Drawing.Size(109, 17);
            this.statusRbtn0.TabIndex = 0;
            this.statusRbtn0.TabStop = true;
            this.statusRbtn0.Text = "Customer Will-Call";
            this.statusRbtn0.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(8, 224);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(213, 29);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OrderInputForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(789, 264);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rawTextBox);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(805, 303);
            this.Name = "OrderInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Input";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderInputForm_FormClosing);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.RadioButton statusRbtn3;
        private System.Windows.Forms.RadioButton statusRbtn2;
        private System.Windows.Forms.RadioButton statusRbtn1;
        private System.Windows.Forms.RadioButton statusRbtn0;
        private System.Windows.Forms.Button cancelButton;
    }
}