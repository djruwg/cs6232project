namespace RentMe.View
{
    partial class SaveReturnForm
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
            SaveReturnTableLayoutPanel = new TableLayoutPanel();
            SaveReturnEmployeeIDTextBox = new TextBox();
            SaveReturnMemberIDTextBox = new TextBox();
            SaveReturnListView = new ListView();
            SaveReturnRentalIDColumnHeader = new ColumnHeader();
            SaveReturnFurnitureIDColumnHeader = new ColumnHeader();
            SaveReturnNameColumnHeader = new ColumnHeader();
            SaveReturnDescriptionColumnHeader = new ColumnHeader();
            SaveReturnDailyRateColumnHeader = new ColumnHeader();
            SaveReturnQuantityReturnedColumnHeader = new ColumnHeader();
            SaveReturnCostColumnHeader = new ColumnHeader();
            SaveReturnRentalIDLabel = new Label();
            SaveReturnMemberIDLabel = new Label();
            SaveReturnEmployeeIDLabel = new Label();
            SaveReturnDateReturnedLabel = new Label();
            SaveReturnRentalIDTextBox = new TextBox();
            SaveReturnReturnDateDateTimePicker = new DateTimePicker();
            SaveReturnSaveButton = new Button();
            SaveReturnCancelButton = new Button();
            SaveReturnQuantityLabel = new Label();
            SaveReturnTotalCostLabel = new Label();
            SaveReturnQuantityTextBox = new TextBox();
            SaveReturnTotalCostTextBox = new TextBox();
            SaveReturnTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SaveReturnTableLayoutPanel
            // 
            SaveReturnTableLayoutPanel.ColumnCount = 8;
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnEmployeeIDTextBox, 5, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnMemberIDTextBox, 3, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnListView, 0, 1);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnRentalIDLabel, 0, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnMemberIDLabel, 2, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnEmployeeIDLabel, 4, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnDateReturnedLabel, 6, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnRentalIDTextBox, 1, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnReturnDateDateTimePicker, 7, 0);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnSaveButton, 0, 2);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnCancelButton, 1, 2);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnQuantityLabel, 4, 2);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnTotalCostLabel, 6, 2);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnQuantityTextBox, 5, 2);
            SaveReturnTableLayoutPanel.Controls.Add(SaveReturnTotalCostTextBox, 7, 2);
            SaveReturnTableLayoutPanel.Dock = DockStyle.Fill;
            SaveReturnTableLayoutPanel.Location = new Point(0, 0);
            SaveReturnTableLayoutPanel.Name = "SaveReturnTableLayoutPanel";
            SaveReturnTableLayoutPanel.RowCount = 3;
            SaveReturnTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SaveReturnTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            SaveReturnTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SaveReturnTableLayoutPanel.Size = new Size(800, 450);
            SaveReturnTableLayoutPanel.TabIndex = 2;
            // 
            // SaveReturnEmployeeIDTextBox
            // 
            SaveReturnEmployeeIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SaveReturnEmployeeIDTextBox.Location = new Point(503, 11);
            SaveReturnEmployeeIDTextBox.Name = "SaveReturnEmployeeIDTextBox";
            SaveReturnEmployeeIDTextBox.ReadOnly = true;
            SaveReturnEmployeeIDTextBox.Size = new Size(94, 23);
            SaveReturnEmployeeIDTextBox.TabIndex = 12;
            // 
            // SaveReturnMemberIDTextBox
            // 
            SaveReturnMemberIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SaveReturnMemberIDTextBox.Location = new Point(303, 11);
            SaveReturnMemberIDTextBox.Name = "SaveReturnMemberIDTextBox";
            SaveReturnMemberIDTextBox.ReadOnly = true;
            SaveReturnMemberIDTextBox.Size = new Size(94, 23);
            SaveReturnMemberIDTextBox.TabIndex = 11;
            // 
            // SaveReturnListView
            // 
            SaveReturnListView.Columns.AddRange(new ColumnHeader[] { SaveReturnRentalIDColumnHeader, SaveReturnFurnitureIDColumnHeader, SaveReturnNameColumnHeader, SaveReturnDescriptionColumnHeader, SaveReturnDailyRateColumnHeader, SaveReturnQuantityReturnedColumnHeader, SaveReturnCostColumnHeader });
            SaveReturnTableLayoutPanel.SetColumnSpan(SaveReturnListView, 8);
            SaveReturnListView.Dock = DockStyle.Fill;
            SaveReturnListView.FullRowSelect = true;
            SaveReturnListView.Location = new Point(3, 48);
            SaveReturnListView.MultiSelect = false;
            SaveReturnListView.Name = "SaveReturnListView";
            SaveReturnListView.Size = new Size(794, 354);
            SaveReturnListView.TabIndex = 5;
            SaveReturnListView.UseCompatibleStateImageBehavior = false;
            SaveReturnListView.View = System.Windows.Forms.View.Details;
            SaveReturnListView.Resize += View_Resize;
            // 
            // SaveReturnRentalIDColumnHeader
            // 
            SaveReturnRentalIDColumnHeader.Text = "Rental ID";
            // 
            // SaveReturnFurnitureIDColumnHeader
            // 
            SaveReturnFurnitureIDColumnHeader.Text = "Furniture ID";
            // 
            // SaveReturnNameColumnHeader
            // 
            SaveReturnNameColumnHeader.Text = "Name";
            // 
            // SaveReturnDescriptionColumnHeader
            // 
            SaveReturnDescriptionColumnHeader.Text = "Description";
            // 
            // SaveReturnDailyRateColumnHeader
            // 
            SaveReturnDailyRateColumnHeader.Text = "Daily Rate";
            // 
            // SaveReturnQuantityReturnedColumnHeader
            // 
            SaveReturnQuantityReturnedColumnHeader.Text = "Quantity Returned";
            // 
            // SaveReturnCostColumnHeader
            // 
            SaveReturnCostColumnHeader.Text = "Cost";
            // 
            // SaveReturnRentalIDLabel
            // 
            SaveReturnRentalIDLabel.Anchor = AnchorStyles.Right;
            SaveReturnRentalIDLabel.AutoSize = true;
            SaveReturnRentalIDLabel.Location = new Point(40, 15);
            SaveReturnRentalIDLabel.Name = "SaveReturnRentalIDLabel";
            SaveReturnRentalIDLabel.Size = new Size(57, 15);
            SaveReturnRentalIDLabel.TabIndex = 6;
            SaveReturnRentalIDLabel.Text = "Rental ID:";
            // 
            // SaveReturnMemberIDLabel
            // 
            SaveReturnMemberIDLabel.Anchor = AnchorStyles.Right;
            SaveReturnMemberIDLabel.AutoSize = true;
            SaveReturnMemberIDLabel.Location = new Point(228, 15);
            SaveReturnMemberIDLabel.Name = "SaveReturnMemberIDLabel";
            SaveReturnMemberIDLabel.Size = new Size(69, 15);
            SaveReturnMemberIDLabel.TabIndex = 7;
            SaveReturnMemberIDLabel.Text = "Member ID:";
            // 
            // SaveReturnEmployeeIDLabel
            // 
            SaveReturnEmployeeIDLabel.Anchor = AnchorStyles.Right;
            SaveReturnEmployeeIDLabel.AutoSize = true;
            SaveReturnEmployeeIDLabel.Location = new Point(421, 15);
            SaveReturnEmployeeIDLabel.Name = "SaveReturnEmployeeIDLabel";
            SaveReturnEmployeeIDLabel.Size = new Size(76, 15);
            SaveReturnEmployeeIDLabel.TabIndex = 8;
            SaveReturnEmployeeIDLabel.Text = "Employee ID:";
            // 
            // SaveReturnDateReturnedLabel
            // 
            SaveReturnDateReturnedLabel.Anchor = AnchorStyles.Right;
            SaveReturnDateReturnedLabel.AutoSize = true;
            SaveReturnDateReturnedLabel.Location = new Point(612, 15);
            SaveReturnDateReturnedLabel.Name = "SaveReturnDateReturnedLabel";
            SaveReturnDateReturnedLabel.Size = new Size(85, 15);
            SaveReturnDateReturnedLabel.TabIndex = 9;
            SaveReturnDateReturnedLabel.Text = "Date Returned:";
            // 
            // SaveReturnRentalIDTextBox
            // 
            SaveReturnRentalIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SaveReturnRentalIDTextBox.Location = new Point(103, 11);
            SaveReturnRentalIDTextBox.Name = "SaveReturnRentalIDTextBox";
            SaveReturnRentalIDTextBox.ReadOnly = true;
            SaveReturnRentalIDTextBox.Size = new Size(94, 23);
            SaveReturnRentalIDTextBox.TabIndex = 10;
            // 
            // SaveReturnReturnDateDateTimePicker
            // 
            SaveReturnReturnDateDateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SaveReturnReturnDateDateTimePicker.Enabled = false;
            SaveReturnReturnDateDateTimePicker.Format = DateTimePickerFormat.Short;
            SaveReturnReturnDateDateTimePicker.Location = new Point(703, 11);
            SaveReturnReturnDateDateTimePicker.Name = "SaveReturnReturnDateDateTimePicker";
            SaveReturnReturnDateDateTimePicker.Size = new Size(94, 23);
            SaveReturnReturnDateDateTimePicker.TabIndex = 13;
            // 
            // SaveReturnSaveButton
            // 
            SaveReturnSaveButton.Anchor = AnchorStyles.None;
            SaveReturnSaveButton.Location = new Point(12, 416);
            SaveReturnSaveButton.Name = "SaveReturnSaveButton";
            SaveReturnSaveButton.Size = new Size(75, 23);
            SaveReturnSaveButton.TabIndex = 14;
            SaveReturnSaveButton.Text = "Save";
            SaveReturnSaveButton.UseVisualStyleBackColor = true;
            SaveReturnSaveButton.Click += SaveReturnSaveButton_Click;
            // 
            // SaveReturnCancelButton
            // 
            SaveReturnCancelButton.Anchor = AnchorStyles.None;
            SaveReturnCancelButton.Location = new Point(112, 416);
            SaveReturnCancelButton.Name = "SaveReturnCancelButton";
            SaveReturnCancelButton.Size = new Size(75, 23);
            SaveReturnCancelButton.TabIndex = 15;
            SaveReturnCancelButton.Text = "Cancel";
            SaveReturnCancelButton.UseVisualStyleBackColor = true;
            SaveReturnCancelButton.Click += SaveReturnCancelButton_Click;
            // 
            // SaveReturnQuantityLabel
            // 
            SaveReturnQuantityLabel.Anchor = AnchorStyles.Right;
            SaveReturnQuantityLabel.AutoSize = true;
            SaveReturnQuantityLabel.Location = new Point(441, 420);
            SaveReturnQuantityLabel.Name = "SaveReturnQuantityLabel";
            SaveReturnQuantityLabel.Size = new Size(56, 15);
            SaveReturnQuantityLabel.TabIndex = 16;
            SaveReturnQuantityLabel.Text = "Quantity:";
            // 
            // SaveReturnTotalCostLabel
            // 
            SaveReturnTotalCostLabel.Anchor = AnchorStyles.Right;
            SaveReturnTotalCostLabel.AutoSize = true;
            SaveReturnTotalCostLabel.Location = new Point(635, 420);
            SaveReturnTotalCostLabel.Name = "SaveReturnTotalCostLabel";
            SaveReturnTotalCostLabel.Size = new Size(62, 15);
            SaveReturnTotalCostLabel.TabIndex = 17;
            SaveReturnTotalCostLabel.Text = "Total Cost:";
            // 
            // SaveReturnQuantityTextBox
            // 
            SaveReturnQuantityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SaveReturnQuantityTextBox.Location = new Point(503, 416);
            SaveReturnQuantityTextBox.Name = "SaveReturnQuantityTextBox";
            SaveReturnQuantityTextBox.ReadOnly = true;
            SaveReturnQuantityTextBox.Size = new Size(94, 23);
            SaveReturnQuantityTextBox.TabIndex = 18;
            // 
            // SaveReturnTotalCostTextBox
            // 
            SaveReturnTotalCostTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SaveReturnTotalCostTextBox.Location = new Point(703, 416);
            SaveReturnTotalCostTextBox.Name = "SaveReturnTotalCostTextBox";
            SaveReturnTotalCostTextBox.ReadOnly = true;
            SaveReturnTotalCostTextBox.Size = new Size(94, 23);
            SaveReturnTotalCostTextBox.TabIndex = 19;
            // 
            // SaveReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveReturnTableLayoutPanel);
            Name = "SaveReturnForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExampleSaveRentalForm";
            SaveReturnTableLayoutPanel.ResumeLayout(false);
            SaveReturnTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel SaveReturnTableLayoutPanel;
        private ListView SaveReturnListView;
        private ColumnHeader SaveReturnRentalIDColumnHeader;
        private ColumnHeader SaveReturnNameColumnHeader;
        private ColumnHeader SaveReturnDescriptionColumnHeader;
        private ColumnHeader SaveReturnCostColumnHeader;
        private ColumnHeader SaveReturnQuantityReturnedColumnHeader;
        private ColumnHeader SaveReturnDailyRateColumnHeader;
        private Label SaveReturnRentalIDLabel;
        private Label SaveReturnMemberIDLabel;
        private Label SaveReturnEmployeeIDLabel;
        private Label SaveReturnDateReturnedLabel;
        private TextBox SaveReturnEmployeeIDTextBox;
        private TextBox SaveReturnMemberIDTextBox;
        private TextBox SaveReturnRentalIDTextBox;
        private DateTimePicker SaveReturnReturnDateDateTimePicker;
        private Button SaveReturnSaveButton;
        private Button SaveReturnCancelButton;
        private Label SaveReturnQuantityLabel;
        private Label SaveReturnTotalCostLabel;
        private TextBox SaveReturnQuantityTextBox;
        private TextBox SaveReturnTotalCostTextBox;
        private ColumnHeader SaveReturnFurnitureIDColumnHeader;
    }
}