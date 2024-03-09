namespace RentMe.UserControls
{
    partial class MemberSearch
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
            MemberSearchTableLayoutPanel = new TableLayoutPanel();
            MemberSearchSearchLabel = new Label();
            MemberSearchSeachMessageLabel = new Label();
            MemberSearchSearchTextBox = new TextBox();
            MemberSearchListView = new ListView();
            MemberSearchIDColumnHeader = new ColumnHeader();
            MemberSearchLastNameColumnHeader = new ColumnHeader();
            MemberSearchFirstNameColumnHeader = new ColumnHeader();
            MemberSearchPhoneNumberColumnHeader = new ColumnHeader();
            MemberSearchTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MemberSearchTableLayoutPanel
            // 
            MemberSearchTableLayoutPanel.ColumnCount = 3;
            MemberSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            MemberSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MemberSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            MemberSearchTableLayoutPanel.Controls.Add(MemberSearchSearchLabel, 0, 0);
            MemberSearchTableLayoutPanel.Controls.Add(MemberSearchSeachMessageLabel, 2, 0);
            MemberSearchTableLayoutPanel.Controls.Add(MemberSearchSearchTextBox, 1, 0);
            MemberSearchTableLayoutPanel.Controls.Add(MemberSearchListView, 0, 1);
            MemberSearchTableLayoutPanel.Dock = DockStyle.Fill;
            MemberSearchTableLayoutPanel.Location = new Point(0, 0);
            MemberSearchTableLayoutPanel.Name = "MemberSearchTableLayoutPanel";
            MemberSearchTableLayoutPanel.RowCount = 2;
            MemberSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            MemberSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            MemberSearchTableLayoutPanel.Size = new Size(705, 254);
            MemberSearchTableLayoutPanel.TabIndex = 0;
            // 
            // MemberSearchSearchLabel
            // 
            MemberSearchSearchLabel.Anchor = AnchorStyles.Left;
            MemberSearchSearchLabel.AutoSize = true;
            MemberSearchSearchLabel.Location = new Point(3, 11);
            MemberSearchSearchLabel.Name = "MemberSearchSearchLabel";
            MemberSearchSearchLabel.Size = new Size(45, 15);
            MemberSearchSearchLabel.TabIndex = 0;
            MemberSearchSearchLabel.Text = "Search:";
            // 
            // MemberSearchSeachMessageLabel
            // 
            MemberSearchSeachMessageLabel.Anchor = AnchorStyles.Left;
            MemberSearchSeachMessageLabel.AutoSize = true;
            MemberSearchSeachMessageLabel.ForeColor = Color.Red;
            MemberSearchSeachMessageLabel.Location = new Point(496, 11);
            MemberSearchSeachMessageLabel.Name = "MemberSearchSeachMessageLabel";
            MemberSearchSeachMessageLabel.Size = new Size(84, 15);
            MemberSearchSeachMessageLabel.TabIndex = 1;
            MemberSearchSeachMessageLabel.Text = "Message Label";
            // 
            // MemberSearchSearchTextBox
            // 
            MemberSearchSearchTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MemberSearchSearchTextBox.Location = new Point(73, 7);
            MemberSearchSearchTextBox.Name = "MemberSearchSearchTextBox";
            MemberSearchSearchTextBox.Size = new Size(417, 23);
            MemberSearchSearchTextBox.TabIndex = 2;
            // 
            // MemberSearchListView
            // 
            MemberSearchListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MemberSearchListView.Columns.AddRange(new ColumnHeader[] { MemberSearchIDColumnHeader, MemberSearchLastNameColumnHeader, MemberSearchFirstNameColumnHeader, MemberSearchPhoneNumberColumnHeader });
            MemberSearchTableLayoutPanel.SetColumnSpan(MemberSearchListView, 3);
            MemberSearchListView.Location = new Point(3, 41);
            MemberSearchListView.Name = "MemberSearchListView";
            MemberSearchListView.Size = new Size(699, 210);
            MemberSearchListView.TabIndex = 3;
            MemberSearchListView.UseCompatibleStateImageBehavior = false;
            MemberSearchListView.View = System.Windows.Forms.View.Details;
            // 
            // MemberSearchIDColumnHeader
            // 
            MemberSearchIDColumnHeader.Text = "Customer ID";
            // 
            // MemberSearchLastNameColumnHeader
            // 
            MemberSearchLastNameColumnHeader.Text = "Last Name";
            // 
            // MemberSearchFirstNameColumnHeader
            // 
            MemberSearchFirstNameColumnHeader.Text = "First Name";
            // 
            // MemberSearchPhoneNumberColumnHeader
            // 
            MemberSearchPhoneNumberColumnHeader.Text = "Phone Number";
            // 
            // MemberSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MemberSearchTableLayoutPanel);
            Name = "MemberSearch";
            Size = new Size(705, 254);
            MemberSearchTableLayoutPanel.ResumeLayout(false);
            MemberSearchTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MemberSearchTableLayoutPanel;
        private Label MemberSearchSearchLabel;
        private Label MemberSearchSeachMessageLabel;
        private TextBox MemberSearchSearchTextBox;
        private ListView MemberSearchListView;
        private ColumnHeader MemberSearchIDColumnHeader;
        private ColumnHeader MemberSearchLastNameColumnHeader;
        private ColumnHeader MemberSearchFirstNameColumnHeader;
        private ColumnHeader MemberSearchPhoneNumberColumnHeader;
    }
}
