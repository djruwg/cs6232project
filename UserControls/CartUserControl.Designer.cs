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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            CartTableLayoutPanel = new TableLayoutPanel();
            CartFirstNameLabel = new Label();
            CartLastNameLabel = new Label();
            CartLeftFlowLayoutPanel = new FlowLayoutPanel();
            CartRentItemsButton = new Button();
            CartRemoveButton = new Button();
            CartMessageLabel = new Label();
            CartFirstNameTextBox = new TextBox();
            CartLastNameTextBox = new TextBox();
            CartRightFlowLayoutPanel = new FlowLayoutPanel();
            CartNewCartButton = new Button();
            CartDataGridView = new DataGridView();
            CartMemberIDLabel = new Label();
            CartMemberIDTextBox = new TextBox();
            CartTableLayoutPanel.SuspendLayout();
            CartLeftFlowLayoutPanel.SuspendLayout();
            CartRightFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).BeginInit();
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
            CartTableLayoutPanel.Controls.Add(CartFirstNameLabel, 0, 1);
            CartTableLayoutPanel.Controls.Add(CartLastNameLabel, 2, 1);
            CartTableLayoutPanel.Controls.Add(CartLeftFlowLayoutPanel, 0, 3);
            CartTableLayoutPanel.Controls.Add(CartFirstNameTextBox, 1, 1);
            CartTableLayoutPanel.Controls.Add(CartLastNameTextBox, 3, 1);
            CartTableLayoutPanel.Controls.Add(CartRightFlowLayoutPanel, 4, 3);
            CartTableLayoutPanel.Controls.Add(CartDataGridView, 0, 2);
            CartTableLayoutPanel.Controls.Add(CartMemberIDLabel, 0, 0);
            CartTableLayoutPanel.Controls.Add(CartMemberIDTextBox, 1, 0);
            CartTableLayoutPanel.Dock = DockStyle.Fill;
            CartTableLayoutPanel.Location = new Point(0, 0);
            CartTableLayoutPanel.Name = "CartTableLayoutPanel";
            CartTableLayoutPanel.RowCount = 4;
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CartTableLayoutPanel.Size = new Size(782, 425);
            CartTableLayoutPanel.TabIndex = 0;
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
            CartTableLayoutPanel.SetColumnSpan(CartLeftFlowLayoutPanel, 4);
            CartLeftFlowLayoutPanel.Controls.Add(CartRentItemsButton);
            CartLeftFlowLayoutPanel.Controls.Add(CartRemoveButton);
            CartLeftFlowLayoutPanel.Controls.Add(CartMessageLabel);
            CartLeftFlowLayoutPanel.Location = new Point(3, 385);
            CartLeftFlowLayoutPanel.Name = "CartLeftFlowLayoutPanel";
            CartLeftFlowLayoutPanel.Size = new Size(586, 37);
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
            CartRentItemsButton.Click += CartRentItemsButton_Click;
            // 
            // CartRemoveButton
            // 
            CartRemoveButton.Location = new Point(84, 3);
            CartRemoveButton.Name = "CartRemoveButton";
            CartRemoveButton.Size = new Size(75, 23);
            CartRemoveButton.TabIndex = 6;
            CartRemoveButton.Text = "Remove";
            CartRemoveButton.UseVisualStyleBackColor = true;
            CartRemoveButton.Click += CartRemoveButton_Click;
            // 
            // CartMessageLabel
            // 
            CartMessageLabel.Anchor = AnchorStyles.Left;
            CartMessageLabel.AutoSize = true;
            CartMessageLabel.ForeColor = Color.Red;
            CartMessageLabel.Location = new Point(165, 7);
            CartMessageLabel.Name = "CartMessageLabel";
            CartMessageLabel.Size = new Size(84, 15);
            CartMessageLabel.TabIndex = 0;
            CartMessageLabel.Text = "Message Label";
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
            CartRightFlowLayoutPanel.Controls.Add(CartNewCartButton);
            CartRightFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            CartRightFlowLayoutPanel.Location = new Point(595, 385);
            CartRightFlowLayoutPanel.Name = "CartRightFlowLayoutPanel";
            CartRightFlowLayoutPanel.Size = new Size(184, 37);
            CartRightFlowLayoutPanel.TabIndex = 10;
            // 
            // CartNewCartButton
            // 
            CartNewCartButton.Location = new Point(106, 3);
            CartNewCartButton.Name = "CartNewCartButton";
            CartNewCartButton.Size = new Size(75, 23);
            CartNewCartButton.TabIndex = 7;
            CartNewCartButton.Text = "New Cart";
            CartNewCartButton.UseVisualStyleBackColor = true;
            CartNewCartButton.Click += CartNewCartButton_Click;
            // 
            // CartDataGridView
            // 
            CartDataGridView.AllowUserToAddRows = false;
            CartDataGridView.AllowUserToDeleteRows = false;
            CartDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartTableLayoutPanel.SetColumnSpan(CartDataGridView, 5);
            CartDataGridView.Dock = DockStyle.Fill;
            CartDataGridView.Location = new Point(2, 59);
            CartDataGridView.Margin = new Padding(2, 1, 2, 1);
            CartDataGridView.Name = "CartDataGridView";
            CartDataGridView.RowHeadersVisible = false;
            CartDataGridView.RowHeadersWidth = 82;
            CartDataGridView.Size = new Size(778, 322);
            CartDataGridView.TabIndex = 11;
            CartDataGridView.CellValidating += CartDataGridView_CellValidating;
            CartDataGridView.CellValueChanged += CartDataGridView_CellValueChanged;
            // 
            // CartMemberIDLabel
            // 
            CartMemberIDLabel.Anchor = AnchorStyles.Left;
            CartMemberIDLabel.AutoSize = true;
            CartMemberIDLabel.Location = new Point(3, 7);
            CartMemberIDLabel.Name = "CartMemberIDLabel";
            CartMemberIDLabel.Size = new Size(66, 15);
            CartMemberIDLabel.TabIndex = 0;
            CartMemberIDLabel.Text = "Member ID";
            // 
            // CartMemberIDTextBox
            // 
            CartMemberIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartMemberIDTextBox.Enabled = false;
            CartMemberIDTextBox.Location = new Point(85, 3);
            CartMemberIDTextBox.Name = "CartMemberIDTextBox";
            CartMemberIDTextBox.Size = new Size(197, 23);
            CartMemberIDTextBox.TabIndex = 1;
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
            CartLeftFlowLayoutPanel.PerformLayout();
            CartRightFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CartTableLayoutPanel;
        private Label CartMemberIDLabel;
        private Label CartFirstNameLabel;
        private Label CartLastNameLabel;
        private FlowLayoutPanel CartLeftFlowLayoutPanel;
        private Button CartRentItemsButton;
        private Button CartNewCartButton;
        private TextBox CartMemberIDTextBox;
        private TextBox CartFirstNameTextBox;
        private TextBox CartLastNameTextBox;
        private FlowLayoutPanel CartRightFlowLayoutPanel;
        private Label CartMessageLabel;
        private Button CartRemoveButton;
        private DataGridView CartDataGridView;
    }
}
