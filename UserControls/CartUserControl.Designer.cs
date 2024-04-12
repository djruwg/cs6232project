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
            CartTableLayoutPanel.Margin = new Padding(6, 6, 6, 6);
            CartTableLayoutPanel.Name = "CartTableLayoutPanel";
            CartTableLayoutPanel.RowCount = 4;
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CartTableLayoutPanel.RowStyles.Add(new RowStyle());
            CartTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            CartTableLayoutPanel.Size = new Size(1452, 907);
            CartTableLayoutPanel.TabIndex = 0;
            // 
            // CartFirstNameLabel
            // 
            CartFirstNameLabel.Anchor = AnchorStyles.Left;
            CartFirstNameLabel.AutoSize = true;
            CartFirstNameLabel.Location = new Point(6, 60);
            CartFirstNameLabel.Margin = new Padding(6, 0, 6, 0);
            CartFirstNameLabel.Name = "CartFirstNameLabel";
            CartFirstNameLabel.Size = new Size(129, 32);
            CartFirstNameLabel.TabIndex = 0;
            CartFirstNameLabel.Text = "First Name";
            // 
            // CartLastNameLabel
            // 
            CartLastNameLabel.Anchor = AnchorStyles.Left;
            CartLastNameLabel.AutoSize = true;
            CartLastNameLabel.Location = new Point(535, 60);
            CartLastNameLabel.Margin = new Padding(6, 0, 6, 0);
            CartLastNameLabel.Name = "CartLastNameLabel";
            CartLastNameLabel.Size = new Size(126, 32);
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
            CartLeftFlowLayoutPanel.Location = new Point(6, 822);
            CartLeftFlowLayoutPanel.Margin = new Padding(6, 6, 6, 6);
            CartLeftFlowLayoutPanel.Name = "CartLeftFlowLayoutPanel";
            CartLeftFlowLayoutPanel.Size = new Size(1087, 79);
            CartLeftFlowLayoutPanel.TabIndex = 4;
            // 
            // CartRentItemsButton
            // 
            CartRentItemsButton.Location = new Point(6, 6);
            CartRentItemsButton.Margin = new Padding(6, 6, 6, 6);
            CartRentItemsButton.Name = "CartRentItemsButton";
            CartRentItemsButton.Size = new Size(139, 49);
            CartRentItemsButton.TabIndex = 5;
            CartRentItemsButton.Text = "Rent Items";
            CartRentItemsButton.UseVisualStyleBackColor = true;
            CartRentItemsButton.Click += CartRentItemsButton_Click;
            // 
            // CartRemoveButton
            // 
            CartRemoveButton.Location = new Point(157, 6);
            CartRemoveButton.Margin = new Padding(6, 6, 6, 6);
            CartRemoveButton.Name = "CartRemoveButton";
            CartRemoveButton.Size = new Size(139, 49);
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
            CartMessageLabel.Location = new Point(308, 14);
            CartMessageLabel.Margin = new Padding(6, 0, 6, 0);
            CartMessageLabel.Name = "CartMessageLabel";
            CartMessageLabel.Size = new Size(171, 32);
            CartMessageLabel.TabIndex = 0;
            CartMessageLabel.Text = "Message Label";
            // 
            // CartFirstNameTextBox
            // 
            CartFirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartFirstNameTextBox.Enabled = false;
            CartFirstNameTextBox.Location = new Point(158, 57);
            CartFirstNameTextBox.Margin = new Padding(6, 6, 6, 6);
            CartFirstNameTextBox.Name = "CartFirstNameTextBox";
            CartFirstNameTextBox.Size = new Size(365, 39);
            CartFirstNameTextBox.TabIndex = 2;
            // 
            // CartLastNameTextBox
            // 
            CartLastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartLastNameTextBox.Enabled = false;
            CartLastNameTextBox.Location = new Point(687, 57);
            CartLastNameTextBox.Margin = new Padding(6, 6, 6, 6);
            CartLastNameTextBox.Name = "CartLastNameTextBox";
            CartLastNameTextBox.Size = new Size(406, 39);
            CartLastNameTextBox.TabIndex = 3;
            // 
            // CartRightFlowLayoutPanel
            // 
            CartRightFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartRightFlowLayoutPanel.Controls.Add(CartNewCartButton);
            CartRightFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            CartRightFlowLayoutPanel.Location = new Point(1105, 822);
            CartRightFlowLayoutPanel.Margin = new Padding(6, 6, 6, 6);
            CartRightFlowLayoutPanel.Name = "CartRightFlowLayoutPanel";
            CartRightFlowLayoutPanel.Size = new Size(341, 79);
            CartRightFlowLayoutPanel.TabIndex = 10;
            // 
            // CartNewCartButton
            // 
            CartNewCartButton.Location = new Point(196, 6);
            CartNewCartButton.Margin = new Padding(6, 6, 6, 6);
            CartNewCartButton.Name = "CartNewCartButton";
            CartNewCartButton.Size = new Size(139, 49);
            CartNewCartButton.TabIndex = 7;
            CartNewCartButton.Text = "New Cart";
            CartNewCartButton.UseVisualStyleBackColor = true;
            CartNewCartButton.Click += CartNewCartButton_Click;
            // 
            // CartDataGridView
            // 
            CartDataGridView.AllowUserToAddRows = false;
            CartDataGridView.AllowUserToDeleteRows = false;
            CartDataGridView.AllowUserToResizeRows = false;
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
            CartDataGridView.Location = new Point(4, 104);
            CartDataGridView.Margin = new Padding(4, 2, 4, 2);
            CartDataGridView.Name = "CartDataGridView";
            CartDataGridView.RowHeadersVisible = false;
            CartDataGridView.RowHeadersWidth = 82;
            CartDataGridView.Size = new Size(1444, 710);
            CartDataGridView.TabIndex = 4;
            CartDataGridView.CellDoubleClick += CartDataGridView_CellDoubleClick;
            CartDataGridView.CellValidating += CartDataGridView_CellValidating;
            CartDataGridView.CellValueChanged += CartDataGridView_CellValueChanged;
            // 
            // CartMemberIDLabel
            // 
            CartMemberIDLabel.Anchor = AnchorStyles.Left;
            CartMemberIDLabel.AutoSize = true;
            CartMemberIDLabel.Location = new Point(6, 9);
            CartMemberIDLabel.Margin = new Padding(6, 0, 6, 0);
            CartMemberIDLabel.Name = "CartMemberIDLabel";
            CartMemberIDLabel.Size = new Size(135, 32);
            CartMemberIDLabel.TabIndex = 0;
            CartMemberIDLabel.Text = "Member ID";
            // 
            // CartMemberIDTextBox
            // 
            CartMemberIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartMemberIDTextBox.Enabled = false;
            CartMemberIDTextBox.Location = new Point(158, 6);
            CartMemberIDTextBox.Margin = new Padding(6, 6, 6, 6);
            CartMemberIDTextBox.Name = "CartMemberIDTextBox";
            CartMemberIDTextBox.Size = new Size(365, 39);
            CartMemberIDTextBox.TabIndex = 1;
            // 
            // CartUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartTableLayoutPanel);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CartUserControl";
            Size = new Size(1452, 907);
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
