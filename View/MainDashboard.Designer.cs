namespace RentMe.View
{
    partial class MainDashboard
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
            MainDashboardTableLayoutPanel = new TableLayoutPanel();
            MainTabControl = new TabControl();
            WelcomeTabPage = new TabPage();
            SearchMembers = new TabPage();
            RegisterMemberTabPage = new TabPage();
            SearchFurnitureTabPage = new TabPage();
            CartTabPage = new TabPage();
            LogoutLinkLabel = new LinkLabel();
            MainDashboardTableLayoutPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // MainDashboardTableLayoutPanel
            // 
            MainDashboardTableLayoutPanel.ColumnCount = 1;
            MainDashboardTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainDashboardTableLayoutPanel.Controls.Add(MainTabControl, 0, 1);
            MainDashboardTableLayoutPanel.Controls.Add(LogoutLinkLabel, 0, 0);
            MainDashboardTableLayoutPanel.Dock = DockStyle.Fill;
            MainDashboardTableLayoutPanel.Location = new Point(0, 0);
            MainDashboardTableLayoutPanel.Name = "MainDashboardTableLayoutPanel";
            MainDashboardTableLayoutPanel.RowCount = 2;
            MainDashboardTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7777777F));
            MainDashboardTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 88.22222F));
            MainDashboardTableLayoutPanel.Size = new Size(800, 508);
            MainDashboardTableLayoutPanel.TabIndex = 0;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(WelcomeTabPage);
            MainTabControl.Controls.Add(SearchMembers);
            MainTabControl.Controls.Add(RegisterMemberTabPage);
            MainTabControl.Controls.Add(SearchFurnitureTabPage);
            MainTabControl.Controls.Add(CartTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(3, 62);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(794, 443);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // WelcomeTabPage
            // 
            WelcomeTabPage.Location = new Point(4, 24);
            WelcomeTabPage.Name = "WelcomeTabPage";
            WelcomeTabPage.Padding = new Padding(3);
            WelcomeTabPage.Size = new Size(786, 415);
            WelcomeTabPage.TabIndex = 0;
            WelcomeTabPage.Text = "Welcome";
            WelcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchMembers
            // 
            SearchMembers.Location = new Point(4, 24);
            SearchMembers.Name = "SearchMembers";
            SearchMembers.Padding = new Padding(3);
            SearchMembers.Size = new Size(786, 363);
            SearchMembers.TabIndex = 1;
            SearchMembers.Text = "Search Members";
            SearchMembers.UseVisualStyleBackColor = true;
            // 
            // RegisterMemberTabPage
            // 
            RegisterMemberTabPage.Location = new Point(4, 24);
            RegisterMemberTabPage.Name = "RegisterMemberTabPage";
            RegisterMemberTabPage.Padding = new Padding(3);
            RegisterMemberTabPage.Size = new Size(786, 363);
            RegisterMemberTabPage.TabIndex = 2;
            RegisterMemberTabPage.Text = "Register Member";
            RegisterMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchFurnitureTabPage
            // 
            SearchFurnitureTabPage.Location = new Point(4, 24);
            SearchFurnitureTabPage.Name = "SearchFurnitureTabPage";
            SearchFurnitureTabPage.Padding = new Padding(3);
            SearchFurnitureTabPage.Size = new Size(786, 363);
            SearchFurnitureTabPage.TabIndex = 3;
            SearchFurnitureTabPage.Text = "Search Furniture";
            SearchFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // CartTabPage
            // 
            CartTabPage.Location = new Point(4, 24);
            CartTabPage.Name = "CartTabPage";
            CartTabPage.Padding = new Padding(3);
            CartTabPage.Size = new Size(786, 363);
            CartTabPage.TabIndex = 4;
            CartTabPage.Text = "Cart";
            CartTabPage.UseVisualStyleBackColor = true;
            // 
            // LogoutLinkLabel
            // 
            LogoutLinkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Location = new Point(752, 0);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new Size(45, 15);
            LogoutLinkLabel.TabIndex = 0;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(MainDashboardTableLayoutPanel);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDashboard";
            Shown += MainDashboard_Shown;
            MainDashboardTableLayoutPanel.ResumeLayout(false);
            MainDashboardTableLayoutPanel.PerformLayout();
            MainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainDashboardTableLayoutPanel;
        private TabControl MainTabControl;
        private TabPage WelcomeTabPage;
        private TabPage SearchMembers;
        private TabPage RegisterMemberTabPage;
        private TabPage SearchFurnitureTabPage;
        private TabPage CartTabPage;
        private LinkLabel LogoutLinkLabel;
    }
}