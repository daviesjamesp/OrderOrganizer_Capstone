
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
            this.statusRbtn0 = new System.Windows.Forms.RadioButton();
            this.statusRbtn1 = new System.Windows.Forms.RadioButton();
            this.statusRbtn2 = new System.Windows.Forms.RadioButton();
            this.statusRbtn3 = new System.Windows.Forms.RadioButton();
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
            this.rawTextBox.Location = new System.Drawing.Point(12, 16);
            this.rawTextBox.Multiline = true;
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(944, 302);
            this.rawTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(847, 331);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(320, 45);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusGroupBox.Controls.Add(this.statusRbtn3);
            this.statusGroupBox.Controls.Add(this.statusRbtn2);
            this.statusGroupBox.Controls.Add(this.statusRbtn1);
            this.statusGroupBox.Controls.Add(this.statusRbtn0);
            this.statusGroupBox.Location = new System.Drawing.Point(962, 18);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(205, 300);
            this.statusGroupBox.TabIndex = 2;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Order Status";
            // 
            // statusRbtn0
            // 
            this.statusRbtn0.AutoSize = true;
            this.statusRbtn0.Location = new System.Drawing.Point(6, 52);
            this.statusRbtn0.Name = "statusRbtn0";
            this.statusRbtn0.Size = new System.Drawing.Size(162, 24);
            this.statusRbtn0.TabIndex = 0;
            this.statusRbtn0.TabStop = true;
            this.statusRbtn0.Text = "Customer Will-Call";
            this.statusRbtn0.UseVisualStyleBackColor = true;
            // 
            // statusRbtn1
            // 
            this.statusRbtn1.AutoSize = true;
            this.statusRbtn1.Location = new System.Drawing.Point(6, 116);
            this.statusRbtn1.Name = "statusRbtn1";
            this.statusRbtn1.Size = new System.Drawing.Size(180, 24);
            this.statusRbtn1.TabIndex = 1;
            this.statusRbtn1.TabStop = true;
            this.statusRbtn1.Text = "Check and Call Back";
            this.statusRbtn1.UseVisualStyleBackColor = true;
            // 
            // statusRbtn2
            // 
            this.statusRbtn2.AutoSize = true;
            this.statusRbtn2.Location = new System.Drawing.Point(6, 180);
            this.statusRbtn2.Name = "statusRbtn2";
            this.statusRbtn2.Size = new System.Drawing.Size(153, 24);
            this.statusRbtn2.TabIndex = 2;
            this.statusRbtn2.TabStop = true;
            this.statusRbtn2.Text = "Order In Process";
            this.statusRbtn2.UseVisualStyleBackColor = true;
            // 
            // statusRbtn3
            // 
            this.statusRbtn3.AutoSize = true;
            this.statusRbtn3.Location = new System.Drawing.Point(6, 244);
            this.statusRbtn3.Name = "statusRbtn3";
            this.statusRbtn3.Size = new System.Drawing.Size(146, 24);
            this.statusRbtn3.TabIndex = 3;
            this.statusRbtn3.TabStop = true;
            this.statusRbtn3.Text = "Order Complete";
            this.statusRbtn3.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 331);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(320, 45);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderInputForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1178, 389);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rawTextBox);
            this.Controls.Add(this.cancelButton);
            this.MinimumSize = new System.Drawing.Size(1200, 445);
            this.Name = "OrderInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Input";
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