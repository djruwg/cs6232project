namespace RentMe.UserControls
{
    partial class MemberShow
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
            MemberShowTableLayoutPanel = new TableLayoutPanel();
            MemberShowIDTableLayoutPanel = new TableLayoutPanel();
            MemberShowIDTextBox = new TextBox();
            MemberShowIDLabel = new Label();
            MemberShowFirstNameTableLayoutPanel = new TableLayoutPanel();
            MemberShowFirstNameLabel = new Label();
            MemberShowFirstNameTextBox = new TextBox();
            MemberShowLastNameTableLayoutPanel = new TableLayoutPanel();
            MemberShowLastNameLabel = new Label();
            MemberShowLastNameTextBox = new TextBox();
            MemberShowRentalsLabel = new Label();
            MemberShowReturnsLabel = new Label();
            MemberShowEditMemberButton = new Button();
            MemberShowRentalsListView = new ListView();
            RentalID = new ColumnHeader();
            RentalDate = new ColumnHeader();
            MemberShowReturnsListView = new ListView();
            ReturnID = new ColumnHeader();
            ReturnDate = new ColumnHeader();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MemberShowReturnItemsButton = new Button();
            MemberShowAttachCartButton = new Button();
            MemberShowCancelButton = new Button();
            MemberShowTableLayoutPanel.SuspendLayout();
            MemberShowIDTableLayoutPanel.SuspendLayout();
            MemberShowFirstNameTableLayoutPanel.SuspendLayout();
            MemberShowLastNameTableLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MemberShowTableLayoutPanel
            // 
            MemberShowTableLayoutPanel.ColumnCount = 2;
            MemberShowTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MemberShowTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MemberShowTableLayoutPanel.Controls.Add(MemberShowIDTableLayoutPanel, 0, 1);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowFirstNameTableLayoutPanel, 0, 3);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowLastNameTableLayoutPanel, 1, 3);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowRentalsLabel, 0, 5);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowReturnsLabel, 1, 5);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowEditMemberButton, 1, 1);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowRentalsListView, 0, 7);
            MemberShowTableLayoutPanel.Controls.Add(MemberShowReturnsListView, 1, 7);
            MemberShowTableLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 9);
            MemberShowTableLayoutPanel.Dock = DockStyle.Fill;
            MemberShowTableLayoutPanel.Location = new Point(0, 0);
            MemberShowTableLayoutPanel.Name = "MemberShowTableLayoutPanel";
            MemberShowTableLayoutPanel.RowCount = 11;
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            MemberShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            MemberShowTableLayoutPanel.Size = new Size(819, 507);
            MemberShowTableLayoutPanel.TabIndex = 2;
            // 
            // MemberShowIDTableLayoutPanel
            // 
            MemberShowIDTableLayoutPanel.ColumnCount = 2;
            MemberShowIDTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            MemberShowIDTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MemberShowIDTableLayoutPanel.Controls.Add(MemberShowIDTextBox, 1, 0);
            MemberShowIDTableLayoutPanel.Controls.Add(MemberShowIDLabel, 0, 0);
            MemberShowIDTableLayoutPanel.Dock = DockStyle.Fill;
            MemberShowIDTableLayoutPanel.Location = new Point(3, 13);
            MemberShowIDTableLayoutPanel.Name = "MemberShowIDTableLayoutPanel";
            MemberShowIDTableLayoutPanel.RowCount = 1;
            MemberShowIDTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MemberShowIDTableLayoutPanel.Size = new Size(403, 26);
            MemberShowIDTableLayoutPanel.TabIndex = 0;
            // 
            // MemberShowIDTextBox
            // 
            MemberShowIDTextBox.Dock = DockStyle.Fill;
            MemberShowIDTextBox.Enabled = false;
            MemberShowIDTextBox.Location = new Point(83, 3);
            MemberShowIDTextBox.Name = "MemberShowIDTextBox";
            MemberShowIDTextBox.Size = new Size(317, 23);
            MemberShowIDTextBox.TabIndex = 1;
            // 
            // MemberShowIDLabel
            // 
            MemberShowIDLabel.Anchor = AnchorStyles.Left;
            MemberShowIDLabel.AutoSize = true;
            MemberShowIDLabel.Location = new Point(3, 5);
            MemberShowIDLabel.Name = "MemberShowIDLabel";
            MemberShowIDLabel.Size = new Size(18, 15);
            MemberShowIDLabel.TabIndex = 2;
            MemberShowIDLabel.Text = "ID";
            // 
            // MemberShowFirstNameTableLayoutPanel
            // 
            MemberShowFirstNameTableLayoutPanel.ColumnCount = 2;
            MemberShowFirstNameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            MemberShowFirstNameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MemberShowFirstNameTableLayoutPanel.Controls.Add(MemberShowFirstNameLabel, 0, 0);
            MemberShowFirstNameTableLayoutPanel.Controls.Add(MemberShowFirstNameTextBox, 1, 0);
            MemberShowFirstNameTableLayoutPanel.Dock = DockStyle.Fill;
            MemberShowFirstNameTableLayoutPanel.Location = new Point(3, 55);
            MemberShowFirstNameTableLayoutPanel.Name = "MemberShowFirstNameTableLayoutPanel";
            MemberShowFirstNameTableLayoutPanel.RowCount = 1;
            MemberShowFirstNameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MemberShowFirstNameTableLayoutPanel.Size = new Size(403, 26);
            MemberShowFirstNameTableLayoutPanel.TabIndex = 1;
            // 
            // MemberShowFirstNameLabel
            // 
            MemberShowFirstNameLabel.Anchor = AnchorStyles.Left;
            MemberShowFirstNameLabel.AutoSize = true;
            MemberShowFirstNameLabel.Location = new Point(3, 5);
            MemberShowFirstNameLabel.Name = "MemberShowFirstNameLabel";
            MemberShowFirstNameLabel.Size = new Size(64, 15);
            MemberShowFirstNameLabel.TabIndex = 0;
            MemberShowFirstNameLabel.Text = "First Name";
            // 
            // MemberShowFirstNameTextBox
            // 
            MemberShowFirstNameTextBox.Dock = DockStyle.Fill;
            MemberShowFirstNameTextBox.Enabled = false;
            MemberShowFirstNameTextBox.Location = new Point(83, 3);
            MemberShowFirstNameTextBox.Name = "MemberShowFirstNameTextBox";
            MemberShowFirstNameTextBox.Size = new Size(317, 23);
            MemberShowFirstNameTextBox.TabIndex = 1;
            // 
            // MemberShowLastNameTableLayoutPanel
            // 
            MemberShowLastNameTableLayoutPanel.ColumnCount = 2;
            MemberShowLastNameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            MemberShowLastNameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MemberShowLastNameTableLayoutPanel.Controls.Add(MemberShowLastNameLabel, 0, 0);
            MemberShowLastNameTableLayoutPanel.Controls.Add(MemberShowLastNameTextBox, 1, 0);
            MemberShowLastNameTableLayoutPanel.Dock = DockStyle.Fill;
            MemberShowLastNameTableLayoutPanel.Location = new Point(412, 55);
            MemberShowLastNameTableLayoutPanel.Name = "MemberShowLastNameTableLayoutPanel";
            MemberShowLastNameTableLayoutPanel.RowCount = 1;
            MemberShowLastNameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MemberShowLastNameTableLayoutPanel.Size = new Size(404, 26);
            MemberShowLastNameTableLayoutPanel.TabIndex = 2;
            // 
            // MemberShowLastNameLabel
            // 
            MemberShowLastNameLabel.Anchor = AnchorStyles.Left;
            MemberShowLastNameLabel.AutoSize = true;
            MemberShowLastNameLabel.Location = new Point(3, 5);
            MemberShowLastNameLabel.Name = "MemberShowLastNameLabel";
            MemberShowLastNameLabel.Size = new Size(63, 15);
            MemberShowLastNameLabel.TabIndex = 0;
            MemberShowLastNameLabel.Text = "Last Name";
            // 
            // MemberShowLastNameTextBox
            // 
            MemberShowLastNameTextBox.Dock = DockStyle.Fill;
            MemberShowLastNameTextBox.Enabled = false;
            MemberShowLastNameTextBox.Location = new Point(83, 3);
            MemberShowLastNameTextBox.Name = "MemberShowLastNameTextBox";
            MemberShowLastNameTextBox.Size = new Size(318, 23);
            MemberShowLastNameTextBox.TabIndex = 1;
            // 
            // MemberShowRentalsLabel
            // 
            MemberShowRentalsLabel.Anchor = AnchorStyles.Left;
            MemberShowRentalsLabel.AutoSize = true;
            MemberShowRentalsLabel.Location = new Point(3, 102);
            MemberShowRentalsLabel.Name = "MemberShowRentalsLabel";
            MemberShowRentalsLabel.Size = new Size(45, 15);
            MemberShowRentalsLabel.TabIndex = 3;
            MemberShowRentalsLabel.Text = "Rentals";
            // 
            // MemberShowReturnsLabel
            // 
            MemberShowReturnsLabel.Anchor = AnchorStyles.Left;
            MemberShowReturnsLabel.AutoSize = true;
            MemberShowReturnsLabel.Location = new Point(412, 102);
            MemberShowReturnsLabel.Name = "MemberShowReturnsLabel";
            MemberShowReturnsLabel.Size = new Size(47, 15);
            MemberShowReturnsLabel.TabIndex = 4;
            MemberShowReturnsLabel.Text = "Returns";
            // 
            // MemberShowEditMemberButton
            // 
            MemberShowEditMemberButton.Anchor = AnchorStyles.Left;
            MemberShowEditMemberButton.Location = new Point(412, 14);
            MemberShowEditMemberButton.Name = "MemberShowEditMemberButton";
            MemberShowEditMemberButton.Size = new Size(80, 23);
            MemberShowEditMemberButton.TabIndex = 5;
            MemberShowEditMemberButton.Text = "Edit Member";
            MemberShowEditMemberButton.UseVisualStyleBackColor = true;
            MemberShowEditMemberButton.Click += MemberShowEditMemberButton_Click;
            // 
            // MemberShowRentalsListView
            // 
            MemberShowRentalsListView.Columns.AddRange(new ColumnHeader[] { RentalID, RentalDate });
            MemberShowRentalsListView.Dock = DockStyle.Fill;
            MemberShowRentalsListView.Location = new Point(3, 139);
            MemberShowRentalsListView.Name = "MemberShowRentalsListView";
            MemberShowRentalsListView.Size = new Size(403, 313);
            MemberShowRentalsListView.TabIndex = 6;
            MemberShowRentalsListView.UseCompatibleStateImageBehavior = false;
            MemberShowRentalsListView.View = System.Windows.Forms.View.Details;
            // 
            // RentalID
            // 
            RentalID.Text = "Rental ID";
            // 
            // RentalDate
            // 
            RentalDate.Text = "Rental Date";
            // 
            // MemberShowReturnsListView
            // 
            MemberShowReturnsListView.Columns.AddRange(new ColumnHeader[] { ReturnID, ReturnDate });
            MemberShowReturnsListView.Dock = DockStyle.Fill;
            MemberShowReturnsListView.Location = new Point(412, 139);
            MemberShowReturnsListView.Name = "MemberShowReturnsListView";
            MemberShowReturnsListView.Size = new Size(404, 313);
            MemberShowReturnsListView.TabIndex = 7;
            MemberShowReturnsListView.UseCompatibleStateImageBehavior = false;
            MemberShowReturnsListView.View = System.Windows.Forms.View.Details;
            // 
            // ReturnID
            // 
            ReturnID.Text = "Return ID";
            // 
            // ReturnDate
            // 
            ReturnDate.Text = "Return Date";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(MemberShowReturnItemsButton);
            flowLayoutPanel1.Controls.Add(MemberShowAttachCartButton);
            flowLayoutPanel1.Controls.Add(MemberShowCancelButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 468);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(403, 26);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // MemberShowReturnItemsButton
            // 
            MemberShowReturnItemsButton.Location = new Point(3, 3);
            MemberShowReturnItemsButton.Name = "MemberShowReturnItemsButton";
            MemberShowReturnItemsButton.Size = new Size(100, 23);
            MemberShowReturnItemsButton.TabIndex = 0;
            MemberShowReturnItemsButton.Text = "Return Items";
            MemberShowReturnItemsButton.UseVisualStyleBackColor = true;
            MemberShowReturnItemsButton.Click += MemberShowReturnItemsButton_Click;
            // 
            // MemberShowAttachCartButton
            // 
            MemberShowAttachCartButton.Location = new Point(109, 3);
            MemberShowAttachCartButton.Name = "MemberShowAttachCartButton";
            MemberShowAttachCartButton.Size = new Size(100, 23);
            MemberShowAttachCartButton.TabIndex = 1;
            MemberShowAttachCartButton.Text = "Attach To Cart";
            MemberShowAttachCartButton.UseVisualStyleBackColor = true;
            MemberShowAttachCartButton.Click += MemberShowAttachCartButton_Click;
            // 
            // MemberShowCancelButton
            // 
            MemberShowCancelButton.Location = new Point(215, 3);
            MemberShowCancelButton.Name = "MemberShowCancelButton";
            MemberShowCancelButton.Size = new Size(100, 23);
            MemberShowCancelButton.TabIndex = 2;
            MemberShowCancelButton.Text = "Close";
            MemberShowCancelButton.UseVisualStyleBackColor = true;
            MemberShowCancelButton.Click += MemberShowCancelButton_Click;
            // 
            // MemberShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MemberShowTableLayoutPanel);
            Name = "MemberShow";
            Size = new Size(819, 507);
            MemberShowTableLayoutPanel.ResumeLayout(false);
            MemberShowTableLayoutPanel.PerformLayout();
            MemberShowIDTableLayoutPanel.ResumeLayout(false);
            MemberShowIDTableLayoutPanel.PerformLayout();
            MemberShowFirstNameTableLayoutPanel.ResumeLayout(false);
            MemberShowFirstNameTableLayoutPanel.PerformLayout();
            MemberShowLastNameTableLayoutPanel.ResumeLayout(false);
            MemberShowLastNameTableLayoutPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MemberShowTableLayoutPanel;
        private TableLayoutPanel MemberShowIDTableLayoutPanel;
        private TextBox MemberShowIDTextBox;
        private Label MemberShowIDLabel;
        private TableLayoutPanel MemberShowFirstNameTableLayoutPanel;
        private Label MemberShowFirstNameLabel;
        private TextBox MemberShowFirstNameTextBox;
        private TableLayoutPanel MemberShowLastNameTableLayoutPanel;
        private Label MemberShowLastNameLabel;
        private TextBox MemberShowLastNameTextBox;
        private Label MemberShowRentalsLabel;
        private Label MemberShowReturnsLabel;
        private Button MemberShowEditMemberButton;
        private ListView MemberShowRentalsListView;
        private ListView MemberShowReturnsListView;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button MemberShowReturnItemsButton;
        private Button MemberShowAttachCartButton;
        private Button MemberShowCancelButton;
        private ColumnHeader RentalID;
        private ColumnHeader RentalDate;
        private ColumnHeader ReturnID;
        private ColumnHeader ReturnDate;
    }
}
