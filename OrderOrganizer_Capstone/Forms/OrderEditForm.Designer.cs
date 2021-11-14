
namespace OrderOrganizer_Capstone.Forms
{
    partial class OrderEditForm
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
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.statusRbtn3 = new System.Windows.Forms.RadioButton();
            this.statusRbtn2 = new System.Windows.Forms.RadioButton();
            this.statusRbtn1 = new System.Windows.Forms.RadioButton();
            this.statusRbtn0 = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createdOnTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showPayInfoButton = new System.Windows.Forms.Button();
            this.stockNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hasPaymentTextBox = new System.Windows.Forms.TextBox();
            this.extractedGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.extractedGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusGroupBox.Controls.Add(this.statusRbtn3);
            this.statusGroupBox.Controls.Add(this.statusRbtn2);
            this.statusGroupBox.Controls.Add(this.statusRbtn1);
            this.statusGroupBox.Controls.Add(this.statusRbtn0);
            this.statusGroupBox.Location = new System.Drawing.Point(633, 13);
            this.statusGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.statusGroupBox.Size = new System.Drawing.Size(146, 194);
            this.statusGroupBox.TabIndex = 6;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Order Status";
            // 
            // statusRbtn3
            // 
            this.statusRbtn3.AutoSize = true;
            this.statusRbtn3.Location = new System.Drawing.Point(4, 159);
            this.statusRbtn3.Margin = new System.Windows.Forms.Padding(2);
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
            this.statusRbtn2.Margin = new System.Windows.Forms.Padding(2);
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
            this.statusRbtn1.Margin = new System.Windows.Forms.Padding(2);
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
            this.statusRbtn0.Margin = new System.Windows.Forms.Padding(2);
            this.statusRbtn0.Name = "statusRbtn0";
            this.statusRbtn0.Size = new System.Drawing.Size(109, 17);
            this.statusRbtn0.TabIndex = 0;
            this.statusRbtn0.TabStop = true;
            this.statusRbtn0.Text = "Customer Will-Call";
            this.statusRbtn0.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(565, 361);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(213, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rawTextBox
            // 
            this.rawTextBox.AcceptsReturn = true;
            this.rawTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawTextBox.Location = new System.Drawing.Point(11, 11);
            this.rawTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rawTextBox.Multiline = true;
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(620, 197);
            this.rawTextBox.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(11, 361);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(213, 29);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.createdOnTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.createdByTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // createdOnTextBox
            // 
            this.createdOnTextBox.Location = new System.Drawing.Point(20, 98);
            this.createdOnTextBox.Name = "createdOnTextBox";
            this.createdOnTextBox.ReadOnly = true;
            this.createdOnTextBox.Size = new System.Drawing.Size(128, 20);
            this.createdOnTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Created On:";
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.Location = new System.Drawing.Point(20, 41);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(128, 20);
            this.createdByTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created By:";
            // 
            // showPayInfoButton
            // 
            this.showPayInfoButton.Location = new System.Drawing.Point(23, 96);
            this.showPayInfoButton.Name = "showPayInfoButton";
            this.showPayInfoButton.Size = new System.Drawing.Size(128, 23);
            this.showPayInfoButton.TabIndex = 2;
            this.showPayInfoButton.Text = "Show Pay Info";
            this.showPayInfoButton.UseVisualStyleBackColor = true;
            this.showPayInfoButton.Click += new System.EventHandler(this.showPayInfoButton_Click);
            // 
            // stockNumberTextBox
            // 
            this.stockNumberTextBox.Location = new System.Drawing.Point(20, 41);
            this.stockNumberTextBox.Name = "stockNumberTextBox";
            this.stockNumberTextBox.ReadOnly = true;
            this.stockNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockNumberTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Number:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(20, 98);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(223, 20);
            this.phoneTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number:";
            // 
            // partCodeTextBox
            // 
            this.partCodeTextBox.Location = new System.Drawing.Point(143, 41);
            this.partCodeTextBox.Name = "partCodeTextBox";
            this.partCodeTextBox.ReadOnly = true;
            this.partCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.partCodeTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Part Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Has Payment Info:";
            // 
            // hasPaymentTextBox
            // 
            this.hasPaymentTextBox.Location = new System.Drawing.Point(23, 41);
            this.hasPaymentTextBox.Name = "hasPaymentTextBox";
            this.hasPaymentTextBox.ReadOnly = true;
            this.hasPaymentTextBox.Size = new System.Drawing.Size(128, 20);
            this.hasPaymentTextBox.TabIndex = 1;
            // 
            // extractedGroupBox
            // 
            this.extractedGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.extractedGroupBox.Controls.Add(this.label2);
            this.extractedGroupBox.Controls.Add(this.stockNumberTextBox);
            this.extractedGroupBox.Controls.Add(this.label3);
            this.extractedGroupBox.Controls.Add(this.partCodeTextBox);
            this.extractedGroupBox.Controls.Add(this.phoneTextBox);
            this.extractedGroupBox.Controls.Add(this.label4);
            this.extractedGroupBox.Location = new System.Drawing.Point(262, 215);
            this.extractedGroupBox.Name = "extractedGroupBox";
            this.extractedGroupBox.Size = new System.Drawing.Size(265, 134);
            this.extractedGroupBox.TabIndex = 11;
            this.extractedGroupBox.TabStop = false;
            this.extractedGroupBox.Text = "Extracted Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.hasPaymentTextBox);
            this.groupBox3.Controls.Add(this.showPayInfoButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(609, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 134);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Info";
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 401);
            this.Controls.Add(this.extractedGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rawTextBox);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(805, 440);
            this.Name = "OrderEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderEditForm";
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.extractedGroupBox.ResumeLayout(false);
            this.extractedGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.RadioButton statusRbtn3;
        private System.Windows.Forms.RadioButton statusRbtn2;
        private System.Windows.Forms.RadioButton statusRbtn1;
        private System.Windows.Forms.RadioButton statusRbtn0;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox createdOnTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showPayInfoButton;
        private System.Windows.Forms.TextBox stockNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partCodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hasPaymentTextBox;
        private System.Windows.Forms.GroupBox extractedGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}