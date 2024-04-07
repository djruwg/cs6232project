namespace RentMe.View
{
    partial class ShowRentalReceiptForm
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
            ShowRentalReceiptTableLayoutPanel = new TableLayoutPanel();
            ShowRentalReceiptRentalIDLabel = new Label();
            ShowRentalReceiptDateRentedLabel = new Label();
            ShowRentalReceiptDateDueLabel = new Label();
            ShowRentalReceiptDateRentedDatePicker = new DateTimePicker();
            ShowRentalReceiptDateDueDatePicker = new DateTimePicker();
            ShowRentalReceiptRentalIDTextBox = new TextBox();
            ShowRentalReceiptDataGridView = new DataGridView();
            ShowRentalReceiptTotalCostLabel = new Label();
            ShowRentalReceiptCloseButton = new Button();
            ShowRentalReceiptTotalCostTextBox = new TextBox();
            ShowRentalReceiptTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowRentalReceiptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ShowRentalReceiptTableLayoutPanel
            // 
            ShowRentalReceiptTableLayoutPanel.ColumnCount = 5;
            ShowRentalReceiptTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            ShowRentalReceiptTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            ShowRentalReceiptTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            ShowRentalReceiptTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            ShowRentalReceiptTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0000038F));
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptRentalIDLabel, 0, 0);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptDateRentedLabel, 2, 0);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptDateDueLabel, 2, 1);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptDateRentedDatePicker, 3, 0);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptDateDueDatePicker, 3, 1);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptRentalIDTextBox, 1, 0);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptDataGridView, 0, 2);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptTotalCostLabel, 3, 3);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptCloseButton, 0, 4);
            ShowRentalReceiptTableLayoutPanel.Controls.Add(ShowRentalReceiptTotalCostTextBox, 4, 3);
            ShowRentalReceiptTableLayoutPanel.Dock = DockStyle.Fill;
            ShowRentalReceiptTableLayoutPanel.Location = new Point(0, 0);
            ShowRentalReceiptTableLayoutPanel.Name = "ShowRentalReceiptTableLayoutPanel";
            ShowRentalReceiptTableLayoutPanel.RowCount = 5;
            ShowRentalReceiptTableLayoutPanel.RowStyles.Add(new RowStyle());
            ShowRentalReceiptTableLayoutPanel.RowStyles.Add(new RowStyle());
            ShowRentalReceiptTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ShowRentalReceiptTableLayoutPanel.RowStyles.Add(new RowStyle());
            ShowRentalReceiptTableLayoutPanel.RowStyles.Add(new RowStyle());
            ShowRentalReceiptTableLayoutPanel.Size = new Size(800, 450);
            ShowRentalReceiptTableLayoutPanel.TabIndex = 0;
            // 
            // ShowRentalReceiptRentalIDLabel
            // 
            ShowRentalReceiptRentalIDLabel.Anchor = AnchorStyles.Right;
            ShowRentalReceiptRentalIDLabel.AutoSize = true;
            ShowRentalReceiptRentalIDLabel.Location = new Point(103, 7);
            ShowRentalReceiptRentalIDLabel.Name = "ShowRentalReceiptRentalIDLabel";
            ShowRentalReceiptRentalIDLabel.Size = new Size(54, 15);
            ShowRentalReceiptRentalIDLabel.TabIndex = 1;
            ShowRentalReceiptRentalIDLabel.Text = "Rental ID";
            // 
            // ShowRentalReceiptDateRentedLabel
            // 
            ShowRentalReceiptDateRentedLabel.Anchor = AnchorStyles.Right;
            ShowRentalReceiptDateRentedLabel.AutoSize = true;
            ShowRentalReceiptDateRentedLabel.Location = new Point(404, 7);
            ShowRentalReceiptDateRentedLabel.Name = "ShowRentalReceiptDateRentedLabel";
            ShowRentalReceiptDateRentedLabel.Size = new Size(71, 15);
            ShowRentalReceiptDateRentedLabel.TabIndex = 2;
            ShowRentalReceiptDateRentedLabel.Text = "Date Rented";
            // 
            // ShowRentalReceiptDateDueLabel
            // 
            ShowRentalReceiptDateDueLabel.Anchor = AnchorStyles.Right;
            ShowRentalReceiptDateDueLabel.AutoSize = true;
            ShowRentalReceiptDateDueLabel.Location = new Point(420, 36);
            ShowRentalReceiptDateDueLabel.Name = "ShowRentalReceiptDateDueLabel";
            ShowRentalReceiptDateDueLabel.Size = new Size(55, 15);
            ShowRentalReceiptDateDueLabel.TabIndex = 3;
            ShowRentalReceiptDateDueLabel.Text = "Date Due";
            // 
            // ShowRentalReceiptDateRentedDatePicker
            // 
            ShowRentalReceiptDateRentedDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ShowRentalReceiptTableLayoutPanel.SetColumnSpan(ShowRentalReceiptDateRentedDatePicker, 2);
            ShowRentalReceiptDateRentedDatePicker.Enabled = false;
            ShowRentalReceiptDateRentedDatePicker.Location = new Point(481, 3);
            ShowRentalReceiptDateRentedDatePicker.Name = "ShowRentalReceiptDateRentedDatePicker";
            ShowRentalReceiptDateRentedDatePicker.Size = new Size(316, 23);
            ShowRentalReceiptDateRentedDatePicker.TabIndex = 4;
            // 
            // ShowRentalReceiptDateDueDatePicker
            // 
            ShowRentalReceiptDateDueDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ShowRentalReceiptTableLayoutPanel.SetColumnSpan(ShowRentalReceiptDateDueDatePicker, 2);
            ShowRentalReceiptDateDueDatePicker.Enabled = false;
            ShowRentalReceiptDateDueDatePicker.Location = new Point(481, 32);
            ShowRentalReceiptDateDueDatePicker.Name = "ShowRentalReceiptDateDueDatePicker";
            ShowRentalReceiptDateDueDatePicker.Size = new Size(316, 23);
            ShowRentalReceiptDateDueDatePicker.TabIndex = 5;
            // 
            // ShowRentalReceiptRentalIDTextBox
            // 
            ShowRentalReceiptRentalIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ShowRentalReceiptRentalIDTextBox.Enabled = false;
            ShowRentalReceiptRentalIDTextBox.Location = new Point(163, 3);
            ShowRentalReceiptRentalIDTextBox.Name = "ShowRentalReceiptRentalIDTextBox";
            ShowRentalReceiptRentalIDTextBox.Size = new Size(153, 23);
            ShowRentalReceiptRentalIDTextBox.TabIndex = 6;
            // 
            // ShowRentalReceiptDataGridView
            // 
            ShowRentalReceiptDataGridView.AllowUserToAddRows = false;
            ShowRentalReceiptDataGridView.AllowUserToDeleteRows = false;
            ShowRentalReceiptDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            ShowRentalReceiptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowRentalReceiptTableLayoutPanel.SetColumnSpan(ShowRentalReceiptDataGridView, 5);
            ShowRentalReceiptDataGridView.Dock = DockStyle.Fill;
            ShowRentalReceiptDataGridView.Location = new Point(3, 61);
            ShowRentalReceiptDataGridView.Name = "ShowRentalReceiptDataGridView";
            ShowRentalReceiptDataGridView.ReadOnly = true;
            ShowRentalReceiptDataGridView.RowHeadersVisible = false;
            ShowRentalReceiptDataGridView.Size = new Size(794, 328);
            ShowRentalReceiptDataGridView.TabIndex = 7;
            // 
            // ShowRentalReceiptTotalCostLabel
            // 
            ShowRentalReceiptTotalCostLabel.Anchor = AnchorStyles.Right;
            ShowRentalReceiptTotalCostLabel.AutoSize = true;
            ShowRentalReceiptTotalCostLabel.Location = new Point(575, 399);
            ShowRentalReceiptTotalCostLabel.Name = "ShowRentalReceiptTotalCostLabel";
            ShowRentalReceiptTotalCostLabel.Size = new Size(59, 15);
            ShowRentalReceiptTotalCostLabel.TabIndex = 8;
            ShowRentalReceiptTotalCostLabel.Text = "Total Cost";
            // 
            // ShowRentalReceiptCloseButton
            // 
            ShowRentalReceiptCloseButton.Anchor = AnchorStyles.None;
            ShowRentalReceiptCloseButton.Location = new Point(42, 424);
            ShowRentalReceiptCloseButton.Name = "ShowRentalReceiptCloseButton";
            ShowRentalReceiptCloseButton.Size = new Size(75, 23);
            ShowRentalReceiptCloseButton.TabIndex = 0;
            ShowRentalReceiptCloseButton.Text = "Close";
            ShowRentalReceiptCloseButton.UseVisualStyleBackColor = true;
            ShowRentalReceiptCloseButton.Click += ShowRentalReceiptCloseButton_Click;
            // 
            // ShowRentalReceiptTotalCostTextBox
            // 
            ShowRentalReceiptTotalCostTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ShowRentalReceiptTotalCostTextBox.Enabled = false;
            ShowRentalReceiptTotalCostTextBox.Location = new Point(640, 395);
            ShowRentalReceiptTotalCostTextBox.Name = "ShowRentalReceiptTotalCostTextBox";
            ShowRentalReceiptTotalCostTextBox.Size = new Size(157, 23);
            ShowRentalReceiptTotalCostTextBox.TabIndex = 9;
            // 
            // ShowRentalReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowRentalReceiptTableLayoutPanel);
            Name = "ShowRentalReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ShowRentalReceiptForm";
            ShowRentalReceiptTableLayoutPanel.ResumeLayout(false);
            ShowRentalReceiptTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowRentalReceiptDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ShowRentalReceiptTableLayoutPanel;
        private Button ShowRentalReceiptCloseButton;
        private Label ShowRentalReceiptRentalIDLabel;
        private Label ShowRentalReceiptDateRentedLabel;
        private Label ShowRentalReceiptDateDueLabel;
        private DateTimePicker ShowRentalReceiptDateRentedDatePicker;
        private DateTimePicker ShowRentalReceiptDateDueDatePicker;
        private TextBox ShowRentalReceiptRentalIDTextBox;
        private DataGridView ShowRentalReceiptDataGridView;
        private Label ShowRentalReceiptTotalCostLabel;
        private TextBox ShowRentalReceiptTotalCostTextBox;
    }
}