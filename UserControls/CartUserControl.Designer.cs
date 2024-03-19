namespace RentMe.UserControls
{
    partial class CartUserControl
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
            CartTableLayoutPanel = new TableLayoutPanel();
            CartRentalIDLabel = new Label();
            CartFirstNameLabel = new Label();
            CartLastNameLabel = new Label();
            CartLeftFlowLayoutPanel = new FlowLayoutPanel();
            CartRentItemsButton = new Button();
            CartCancelButton = new Button();
            CartRentalIDTextBox = new TextBox();
            CartMemberIDTextBox = new TextBox();
            CartFirstNameTextBox = new TextBox();
            CartLastNameTextBox = new TextBox();
            CartRightFlowLayoutPanel = new FlowLayoutPanel();
            CartClearButton = new Button();
            CartListView = new ListView();
            CartFurnitureIDHeader = new ColumnHeader();
            CartDescriptionHeader = new ColumnHeader();
            CartRentalRateHeader = new ColumnHeader();
            CartOverdueChargeHeader = new ColumnHeader();
            CartQuantityHeader = new ColumnHeader();
            CartMemberIDLabel = new Label();
            CartMessageLabel = new Label();
            CartTableLayoutPanel.SuspendLayout();
            CartLeftFlowLayoutPanel.SuspendLayout();
            CartRightFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CartTableLayoutPanel
            // 
            CartTableLayoutPanel.ColumnCount = 5;
            CartTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5074291F));
            CartTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.95908F));
            CartTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4859333F));
            CartTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7723789F));
            CartTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1687984F));
            CartTableLayoutPanel.Controls.Add(CartRentalIDLabel, 0, 0);
            CartTableLayoutPanel.Controls.Add(CartFirstNameLabel, 0, 1);
            CartTableLayoutPanel.Controls.Add(CartLastNameLabel, 2, 1);
            CartTableLayoutPanel.Controls.Add(CartLeftFlowLayoutPanel, 0, 3);
            CartTableLayoutPanel.Controls.Add(CartRentalIDTextBox, 1, 0);
            CartTableLayoutPanel.Controls.Add(CartMemberIDTextBox, 3, 0);
            CartTableLayoutPanel.Controls.Add(CartFirstNameTextBox, 1, 1);
            CartTableLayoutPanel.Controls.Add(CartLastNameTextBox, 3, 1);
            CartTableLayoutPanel.Controls.Add(CartRightFlowLayoutPanel, 3, 3);
            CartTableLayoutPanel.Controls.Add(CartListView, 0, 2);
            CartTableLayoutPanel.Controls.Add(CartMemberIDLabel, 2, 0);
            CartTableLayoutPanel.Controls.Add(CartMessageLabel, 4, 1);
            CartTableLayoutPanel.Dock = DockStyle.Fill;
            CartTableLayoutPanel.Location = new Point(0, 0);
            CartTableLayoutPanel.Name = "CartTableLayoutPanel";
            CartTableLayoutPanel.RowCount = 4;
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.Size = new Size(782, 425);
            CartTableLayoutPanel.TabIndex = 0;
            // 
            // CartRentalIDLabel
            // 
            CartRentalIDLabel.Anchor = AnchorStyles.Left;
            CartRentalIDLabel.AutoSize = true;
            CartRentalIDLabel.Location = new Point(3, 7);
            CartRentalIDLabel.Name = "CartRentalIDLabel";
            CartRentalIDLabel.Size = new Size(54, 15);
            CartRentalIDLabel.TabIndex = 0;
            CartRentalIDLabel.Text = "Rental ID";
            // 
            // CartFirstNameLabel
            // 
            CartFirstNameLabel.Anchor = AnchorStyles.Left;
            CartFirstNameLabel.AutoSize = true;
            CartFirstNameLabel.Location = new Point(3, 36);
            CartFirstNameLabel.Name = "CartFirstNameLabel";
            CartFirstNameLabel.Size = new Size(64, 15);
            CartFirstNameLabel.TabIndex = 0;
            CartFirstNameLabel.Text = "First Name";
            // 
            // CartLastNameLabel
            // 
            CartLastNameLabel.Anchor = AnchorStyles.Left;
            CartLastNameLabel.AutoSize = true;
            CartLastNameLabel.Location = new Point(288, 36);
            CartLastNameLabel.Name = "CartLastNameLabel";
            CartLastNameLabel.Size = new Size(63, 15);
            CartLastNameLabel.TabIndex = 0;
            CartLastNameLabel.Text = "Last Name";
            // 
            // CartLeftFlowLayoutPanel
            // 
            CartLeftFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartTableLayoutPanel.SetColumnSpan(CartLeftFlowLayoutPanel, 3);
            CartLeftFlowLayoutPanel.Controls.Add(CartRentItemsButton);
            CartLeftFlowLayoutPanel.Controls.Add(CartCancelButton);
            CartLeftFlowLayoutPanel.Location = new Point(3, 385);
            CartLeftFlowLayoutPanel.Name = "CartLeftFlowLayoutPanel";
            CartLeftFlowLayoutPanel.Size = new Size(361, 37);
            CartLeftFlowLayoutPanel.TabIndex = 4;
            // 
            // CartRentItemsButton
            // 
            CartRentItemsButton.Location = new Point(3, 3);
            CartRentItemsButton.Name = "CartRentItemsButton";
            CartRentItemsButton.Size = new Size(75, 23);
            CartRentItemsButton.TabIndex = 5;
            CartRentItemsButton.Text = "Rent Items";
            CartRentItemsButton.UseVisualStyleBackColor = true;
            // 
            // CartCancelButton
            // 
            CartCancelButton.Location = new Point(84, 3);
            CartCancelButton.Name = "CartCancelButton";
            CartCancelButton.Size = new Size(75, 23);
            CartCancelButton.TabIndex = 6;
            CartCancelButton.Text = "Cancel";
            CartCancelButton.UseVisualStyleBackColor = true;
            // 
            // CartRentalIDTextBox
            // 
            CartRentalIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartRentalIDTextBox.Enabled = false;
            CartRentalIDTextBox.Location = new Point(85, 3);
            CartRentalIDTextBox.Name = "CartRentalIDTextBox";
            CartRentalIDTextBox.Size = new Size(197, 23);
            CartRentalIDTextBox.TabIndex = 0;
            // 
            // CartMemberIDTextBox
            // 
            CartMemberIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartMemberIDTextBox.Enabled = false;
            CartMemberIDTextBox.Location = new Point(370, 3);
            CartMemberIDTextBox.Name = "CartMemberIDTextBox";
            CartMemberIDTextBox.Size = new Size(219, 23);
            CartMemberIDTextBox.TabIndex = 1;
            // 
            // CartFirstNameTextBox
            // 
            CartFirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartFirstNameTextBox.Enabled = false;
            CartFirstNameTextBox.Location = new Point(85, 32);
            CartFirstNameTextBox.Name = "CartFirstNameTextBox";
            CartFirstNameTextBox.Size = new Size(197, 23);
            CartFirstNameTextBox.TabIndex = 2;
            // 
            // CartLastNameTextBox
            // 
            CartLastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartLastNameTextBox.Enabled = false;
            CartLastNameTextBox.Location = new Point(370, 32);
            CartLastNameTextBox.Name = "CartLastNameTextBox";
            CartLastNameTextBox.Size = new Size(219, 23);
            CartLastNameTextBox.TabIndex = 3;
            // 
            // CartRightFlowLayoutPanel
            // 
            CartRightFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartTableLayoutPanel.SetColumnSpan(CartRightFlowLayoutPanel, 2);
            CartRightFlowLayoutPanel.Controls.Add(CartClearButton);
            CartRightFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            CartRightFlowLayoutPanel.Location = new Point(370, 385);
            CartRightFlowLayoutPanel.Name = "CartRightFlowLayoutPanel";
            CartRightFlowLayoutPanel.Size = new Size(409, 37);
            CartRightFlowLayoutPanel.TabIndex = 10;
            // 
            // CartClearButton
            // 
            CartClearButton.Location = new Point(331, 3);
            CartClearButton.Name = "CartClearButton";
            CartClearButton.Size = new Size(75, 23);
            CartClearButton.TabIndex = 7;
            CartClearButton.Text = "Clear";
            CartClearButton.UseVisualStyleBackColor = true;
            // 
            // CartListView
            // 
            CartListView.Columns.AddRange(new ColumnHeader[] { CartFurnitureIDHeader, CartDescriptionHeader, CartRentalRateHeader, CartOverdueChargeHeader, CartQuantityHeader });
            CartTableLayoutPanel.SetColumnSpan(CartListView, 5);
            CartListView.Dock = DockStyle.Fill;
            CartListView.Location = new Point(3, 61);
            CartListView.Name = "CartListView";
            CartListView.Size = new Size(776, 318);
            CartListView.TabIndex = 4;
            CartListView.UseCompatibleStateImageBehavior = false;
            CartListView.View = System.Windows.Forms.View.Details;
            // 
            // CartFurnitureIDHeader
            // 
            CartFurnitureIDHeader.Text = "Furniture ID";
            // 
            // CartDescriptionHeader
            // 
            CartDescriptionHeader.Text = "Description";
            // 
            // CartRentalRateHeader
            // 
            CartRentalRateHeader.Text = "Rental Rate";
            // 
            // CartOverdueChargeHeader
            // 
            CartOverdueChargeHeader.Text = "Overdue Charge";
            // 
            // CartQuantityHeader
            // 
            CartQuantityHeader.Text = "Quantity";
            // 
            // CartMemberIDLabel
            // 
            CartMemberIDLabel.Anchor = AnchorStyles.Left;
            CartMemberIDLabel.AutoSize = true;
            CartMemberIDLabel.Location = new Point(288, 7);
            CartMemberIDLabel.Name = "CartMemberIDLabel";
            CartMemberIDLabel.Size = new Size(66, 15);
            CartMemberIDLabel.TabIndex = 0;
            CartMemberIDLabel.Text = "Member ID";
            // 
            // CartMessageLabel
            // 
            CartMessageLabel.Anchor = AnchorStyles.Left;
            CartMessageLabel.AutoSize = true;
            CartMessageLabel.Location = new Point(595, 36);
            CartMessageLabel.Name = "CartMessageLabel";
            CartMessageLabel.Size = new Size(84, 15);
            CartMessageLabel.TabIndex = 0;
            CartMessageLabel.Text = "Message Label";
            // 
            // CartUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartTableLayoutPanel);
            Name = "CartUserControl";
            Size = new Size(782, 425);
            CartTableLayoutPanel.ResumeLayout(false);
            CartTableLayoutPanel.PerformLayout();
            CartLeftFlowLayoutPanel.ResumeLayout(false);
            CartRightFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CartTableLayoutPanel;
        private Label CartRentalIDLabel;
        private Label CartMemberIDLabel;
        private Button CartClearButton;
        private Label CartFirstNameLabel;
        private Label CartLastNameLabel;
        private FlowLayoutPanel CartLeftFlowLayoutPanel;
        private Button CartRentItemsButton;
        private Button CartCancelButton;
        private TextBox CartRentalIDTextBox;
        private TextBox CartMemberIDTextBox;
        private TextBox CartFirstNameTextBox;
        private TextBox CartLastNameTextBox;
        private FlowLayoutPanel CartRightFlowLayoutPanel;
        private ListView CartListView;
        private ColumnHeader CartFurnitureIDHeader;
        private ColumnHeader CartDescriptionHeader;
        private ColumnHeader CartRentalRateHeader;
        private ColumnHeader CartOverdueChargeHeader;
        private ColumnHeader CartQuantityHeader;
        private Label CartMessageLabel;
    }
}
