
namespace OrderOrganizer_Capstone.Forms
{
    partial class OrderListForm
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
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.dateFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.dateFilterTypeCombo = new System.Windows.Forms.ComboBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.throughLabel = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.statusFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.status3 = new System.Windows.Forms.CheckBox();
            this.status2 = new System.Windows.Forms.CheckBox();
            this.status1 = new System.Windows.Forms.CheckBox();
            this.status0 = new System.Windows.Forms.CheckBox();
            this.orderListView = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHasExtInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHasPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.filterGroupBox.SuspendLayout();
            this.dateFilterGroupBox.SuspendLayout();
            this.statusFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupBox.Controls.Add(this.refreshButton);
            this.filterGroupBox.Controls.Add(this.resetFilterButton);
            this.filterGroupBox.Controls.Add(this.dateFilterGroupBox);
            this.filterGroupBox.Controls.Add(this.label1);
            this.filterGroupBox.Controls.Add(this.searchTextBox);
            this.filterGroupBox.Controls.Add(this.statusFilterGroupBox);
            this.filterGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(623, 213);
            this.filterGroupBox.TabIndex = 0;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filters";
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetFilterButton.Location = new System.Drawing.Point(417, 174);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(91, 33);
            this.resetFilterButton.TabIndex = 4;
            this.resetFilterButton.Text = "Reset";
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.ResetFilters);
            // 
            // dateFilterGroupBox
            // 
            this.dateFilterGroupBox.Controls.Add(this.dateFilterTypeCombo);
            this.dateFilterGroupBox.Controls.Add(this.date1);
            this.dateFilterGroupBox.Controls.Add(this.throughLabel);
            this.dateFilterGroupBox.Controls.Add(this.date2);
            this.dateFilterGroupBox.Location = new System.Drawing.Point(6, 84);
            this.dateFilterGroupBox.Name = "dateFilterGroupBox";
            this.dateFilterGroupBox.Size = new System.Drawing.Size(405, 116);
            this.dateFilterGroupBox.TabIndex = 6;
            this.dateFilterGroupBox.TabStop = false;
            this.dateFilterGroupBox.Text = "Dates";
            // 
            // dateFilterTypeCombo
            // 
            this.dateFilterTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterTypeCombo.FormattingEnabled = true;
            this.dateFilterTypeCombo.Items.AddRange(new object[] {
            "(none)",
            "Single Date",
            "Date Range"});
            this.dateFilterTypeCombo.Location = new System.Drawing.Point(25, 25);
            this.dateFilterTypeCombo.Name = "dateFilterTypeCombo";
            this.dateFilterTypeCombo.Size = new System.Drawing.Size(354, 28);
            this.dateFilterTypeCombo.TabIndex = 9;
            this.dateFilterTypeCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterTypeCombo_SelectedIndexChanged);
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(25, 75);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(114, 26);
            this.date1.TabIndex = 8;
            this.date1.ValueChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // throughLabel
            // 
            this.throughLabel.AutoSize = true;
            this.throughLabel.Location = new System.Drawing.Point(170, 80);
            this.throughLabel.Name = "throughLabel";
            this.throughLabel.Size = new System.Drawing.Size(64, 20);
            this.throughLabel.TabIndex = 7;
            this.throughLabel.Text = "through";
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(265, 75);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(114, 26);
            this.date2.TabIndex = 2;
            this.date2.ValueChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find Text:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 52);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(405, 26);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // statusFilterGroupBox
            // 
            this.statusFilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusFilterGroupBox.Controls.Add(this.status3);
            this.statusFilterGroupBox.Controls.Add(this.status2);
            this.statusFilterGroupBox.Controls.Add(this.status1);
            this.statusFilterGroupBox.Controls.Add(this.status0);
            this.statusFilterGroupBox.Location = new System.Drawing.Point(417, 12);
            this.statusFilterGroupBox.Name = "statusFilterGroupBox";
            this.statusFilterGroupBox.Size = new System.Drawing.Size(200, 156);
            this.statusFilterGroupBox.TabIndex = 1;
            this.statusFilterGroupBox.TabStop = false;
            this.statusFilterGroupBox.Text = "Order Status:";
            // 
            // status3
            // 
            this.status3.AutoSize = true;
            this.status3.Checked = true;
            this.status3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status3.Location = new System.Drawing.Point(17, 119);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(147, 24);
            this.status3.TabIndex = 1;
            this.status3.Text = "Order Complete";
            this.status3.UseVisualStyleBackColor = true;
            this.status3.CheckedChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.Checked = true;
            this.status2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status2.Location = new System.Drawing.Point(17, 89);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(154, 24);
            this.status2.TabIndex = 1;
            this.status2.Text = "Order In Process";
            this.status2.UseVisualStyleBackColor = true;
            this.status2.CheckedChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.Checked = true;
            this.status1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status1.Location = new System.Drawing.Point(17, 59);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(183, 24);
            this.status1.TabIndex = 1;
            this.status1.Text = "Check And Call Back";
            this.status1.UseVisualStyleBackColor = true;
            this.status1.CheckedChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // status0
            // 
            this.status0.AutoSize = true;
            this.status0.Checked = true;
            this.status0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status0.Location = new System.Drawing.Point(17, 29);
            this.status0.Name = "status0";
            this.status0.Size = new System.Drawing.Size(163, 24);
            this.status0.TabIndex = 0;
            this.status0.Text = "Customer Will-Call";
            this.status0.UseVisualStyleBackColor = true;
            this.status0.CheckedChanged += new System.EventHandler(this.RefreshOrderList);
            // 
            // orderListView
            // 
            this.orderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colUser,
            this.colHasExtInfo,
            this.colHasPayment,
            this.colText});
            this.orderListView.FullRowSelect = true;
            this.orderListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(12, 231);
            this.orderListView.MultiSelect = false;
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(623, 653);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.orderListView_MouseDoubleClick);
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            // 
            // colUser
            // 
            this.colUser.Text = "User";
            // 
            // colHasExtInfo
            // 
            this.colHasExtInfo.Text = "Ext. Info";
            // 
            // colHasPayment
            // 
            this.colHasPayment.Text = "Payment";
            // 
            // colText
            // 
            this.colText.Text = "Text";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(526, 174);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(91, 33);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 904);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.orderListView);
            this.MinimumSize = new System.Drawing.Size(670, 960);
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderListForm_FormClosing);
            this.Load += new System.EventHandler(this.RefreshOrderList);
            this.Shown += new System.EventHandler(this.FillListColumns);
            this.ResizeEnd += new System.EventHandler(this.FillListColumns);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.dateFilterGroupBox.ResumeLayout(false);
            this.dateFilterGroupBox.PerformLayout();
            this.statusFilterGroupBox.ResumeLayout(false);
            this.statusFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colUser;
        private System.Windows.Forms.ColumnHeader colHasExtInfo;
        private System.Windows.Forms.ColumnHeader colHasPayment;
        private System.Windows.Forms.ColumnHeader colText;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.GroupBox dateFilterGroupBox;
        private System.Windows.Forms.ComboBox dateFilterTypeCombo;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label throughLabel;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox statusFilterGroupBox;
        private System.Windows.Forms.CheckBox status3;
        private System.Windows.Forms.CheckBox status2;
        private System.Windows.Forms.CheckBox status1;
        private System.Windows.Forms.CheckBox status0;
        private System.Windows.Forms.Button refreshButton;
    }
}