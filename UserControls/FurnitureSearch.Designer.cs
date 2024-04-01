namespace RentMe.UserControls
{
    partial class FurnitureSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FurnitureSearchTableLayoutPanel = new TableLayoutPanel();
            FurnitureSearchListView = new ListView();
            FurnitureSearchIDColumnHeader = new ColumnHeader();
            FurnnitureSearchNameColumnHeader = new ColumnHeader();
            FurnitureSearchDescriptionColumnHeader = new ColumnHeader();
            FurnitureSearchCategoryColumnHeader = new ColumnHeader();
            FurnitureSearchStyleColumnHeader = new ColumnHeader();
            FurnitureSearchQuantityInStockColumnHeader = new ColumnHeader();
            FurnitureSearchDailyRateColumnHeader = new ColumnHeader();
            FurnitureSearchSearchLabel = new Label();
            FurnitureSearchSearchTextBox = new TextBox();
            FurnitureSearchSearchMessageLabel = new Label();
            FurnitureSearchSearchButton = new Button();
            FurnitureSearchTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FurnitureSearchTableLayoutPanel
            // 
            FurnitureSearchTableLayoutPanel.ColumnCount = 4;
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FurnitureSearchTableLayoutPanel.Controls.Add(FurnitureSearchListView, 0, 1);
            FurnitureSearchTableLayoutPanel.Controls.Add(FurnitureSearchSearchLabel, 0, 0);
            FurnitureSearchTableLayoutPanel.Controls.Add(FurnitureSearchSearchTextBox, 1, 0);
            FurnitureSearchTableLayoutPanel.Controls.Add(FurnitureSearchSearchMessageLabel, 3, 0);
            FurnitureSearchTableLayoutPanel.Controls.Add(FurnitureSearchSearchButton, 2, 0);
            FurnitureSearchTableLayoutPanel.Dock = DockStyle.Fill;
            FurnitureSearchTableLayoutPanel.Location = new Point(0, 0);
            FurnitureSearchTableLayoutPanel.Name = "FurnitureSearchTableLayoutPanel";
            FurnitureSearchTableLayoutPanel.RowCount = 2;
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            FurnitureSearchTableLayoutPanel.Size = new Size(705, 254);
            FurnitureSearchTableLayoutPanel.TabIndex = 1;
            FurnitureSearchTableLayoutPanel.Resize += UserControl_Resize;
            // 
            // FurnitureSearchListView
            // 
            FurnitureSearchListView.Columns.AddRange(new ColumnHeader[] { FurnitureSearchIDColumnHeader, FurnnitureSearchNameColumnHeader, FurnitureSearchDescriptionColumnHeader, FurnitureSearchCategoryColumnHeader, FurnitureSearchStyleColumnHeader, FurnitureSearchQuantityInStockColumnHeader, FurnitureSearchDailyRateColumnHeader });
            FurnitureSearchTableLayoutPanel.SetColumnSpan(FurnitureSearchListView, 4);
            FurnitureSearchListView.Dock = DockStyle.Fill;
            FurnitureSearchListView.FullRowSelect = true;
            FurnitureSearchListView.Location = new Point(3, 41);
            FurnitureSearchListView.MultiSelect = false;
            FurnitureSearchListView.Name = "FurnitureSearchListView";
            FurnitureSearchListView.Size = new Size(699, 210);
            FurnitureSearchListView.TabIndex = 5;
            FurnitureSearchListView.UseCompatibleStateImageBehavior = false;
            FurnitureSearchListView.View = System.Windows.Forms.View.Details;
            // 
            // FurnitureSearchIDColumnHeader
            // 
            FurnitureSearchIDColumnHeader.Text = "ID";
            // 
            // FurnnitureSearchNameColumnHeader
            // 
            FurnnitureSearchNameColumnHeader.Text = "Name";
            // 
            // FurnitureSearchDescriptionColumnHeader
            // 
            FurnitureSearchDescriptionColumnHeader.Text = "Description";
            // 
            // FurnitureSearchCategoryColumnHeader
            // 
            FurnitureSearchCategoryColumnHeader.Text = "Category";
            // 
            // FurnitureSearchStyleColumnHeader
            // 
            FurnitureSearchStyleColumnHeader.Text = "Style";
            // 
            // FurnitureSearchQuantityInStockColumnHeader
            // 
            FurnitureSearchQuantityInStockColumnHeader.Text = "Quantity in Stock";
            // 
            // FurnitureSearchDailyRateColumnHeader
            // 
            FurnitureSearchDailyRateColumnHeader.Text = "Daily Rate";
            // 
            // FurnitureSearchSearchLabel
            // 
            FurnitureSearchSearchLabel.Anchor = AnchorStyles.Left;
            FurnitureSearchSearchLabel.AutoSize = true;
            FurnitureSearchSearchLabel.Location = new Point(3, 11);
            FurnitureSearchSearchLabel.Name = "FurnitureSearchSearchLabel";
            FurnitureSearchSearchLabel.Size = new Size(45, 15);
            FurnitureSearchSearchLabel.TabIndex = 0;
            FurnitureSearchSearchLabel.Text = "Search:";
            // 
            // FurnitureSearchSearchTextBox
            // 
            FurnitureSearchSearchTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FurnitureSearchSearchTextBox.Location = new Point(73, 7);
            FurnitureSearchSearchTextBox.Name = "FurnitureSearchSearchTextBox";
            FurnitureSearchSearchTextBox.Size = new Size(346, 23);
            FurnitureSearchSearchTextBox.TabIndex = 2;
            // 
            // FurnitureSearchSearchMessageLabel
            // 
            FurnitureSearchSearchMessageLabel.Anchor = AnchorStyles.Left;
            FurnitureSearchSearchMessageLabel.AutoSize = true;
            FurnitureSearchSearchMessageLabel.ForeColor = Color.Red;
            FurnitureSearchSearchMessageLabel.Location = new Point(530, 11);
            FurnitureSearchSearchMessageLabel.Name = "FurnitureSearchSearchMessageLabel";
            FurnitureSearchSearchMessageLabel.Size = new Size(84, 15);
            FurnitureSearchSearchMessageLabel.TabIndex = 1;
            FurnitureSearchSearchMessageLabel.Text = "Message Label";
            // 
            // FurnitureSearchSearchButton
            // 
            FurnitureSearchSearchButton.Anchor = AnchorStyles.Left;
            FurnitureSearchSearchButton.Location = new Point(425, 7);
            FurnitureSearchSearchButton.Name = "FurnitureSearchSearchButton";
            FurnitureSearchSearchButton.Size = new Size(75, 23);
            FurnitureSearchSearchButton.TabIndex = 4;
            FurnitureSearchSearchButton.Text = "Search";
            FurnitureSearchSearchButton.UseVisualStyleBackColor = true;
            FurnitureSearchSearchButton.Click += FurnitureSearchSearchButton_Click;
            // 
            // FurnitureSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FurnitureSearchTableLayoutPanel);
            Name = "FurnitureSearch";
            Size = new Size(705, 254);
            FurnitureSearchTableLayoutPanel.ResumeLayout(false);
            FurnitureSearchTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FurnitureSearchTableLayoutPanel;
        private Label FurnitureSearchSearchLabel;
        private TextBox FurnitureSearchSearchTextBox;
        private Label FurnitureSearchSearchMessageLabel;
        private Button FurnitureSearchSearchButton;
        private ListView FurnitureSearchListView;
        private ColumnHeader FurnitureSearchIDColumnHeader;
        private ColumnHeader FurnnitureSearchNameColumnHeader;
        private ColumnHeader FurnitureSearchDescriptionColumnHeader;
        private ColumnHeader FurnitureSearchCategoryColumnHeader;
        private ColumnHeader FurnitureSearchStyleColumnHeader;
        private ColumnHeader FurnitureSearchQuantityInStockColumnHeader;
        private ColumnHeader FurnitureSearchDailyRateColumnHeader;
    }
}
