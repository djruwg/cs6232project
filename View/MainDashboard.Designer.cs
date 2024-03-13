﻿namespace RentMe.View
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
            SearchMembersTabPage = new TabPage();
            MemberSearchUserControl = new UserControls.MemberSearch();
            RegisterMemberTabPage = new TabPage();
            MainDashboardMemberEditorUserControl = new UserControls.MemberEditor();
            SearchFurnitureTabPage = new TabPage();
            CartTabPage = new TabPage();
            MainDashboardFlowLayoutPanel = new FlowLayoutPanel();
            MainDashboardAdminLinkLabel = new LinkLabel();
            MainDashboardLogoutLinkLabel = new LinkLabel();
            MainDashboardTableLayoutPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            SearchMembersTabPage.SuspendLayout();
            RegisterMemberTabPage.SuspendLayout();
            MainDashboardFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainDashboardTableLayoutPanel
            // 
            MainDashboardTableLayoutPanel.ColumnCount = 1;
            MainDashboardTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainDashboardTableLayoutPanel.Controls.Add(MainTabControl, 0, 1);
            MainDashboardTableLayoutPanel.Controls.Add(MainDashboardFlowLayoutPanel, 0, 0);
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
            MainTabControl.Controls.Add(SearchMembersTabPage);
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
            // SearchMembersTabPage
            // 
            SearchMembersTabPage.Controls.Add(MemberSearchUserControl);
            SearchMembersTabPage.Location = new Point(4, 24);
            SearchMembersTabPage.Name = "SearchMembersTabPage";
            SearchMembersTabPage.Padding = new Padding(3);
            SearchMembersTabPage.RightToLeft = RightToLeft.No;
            SearchMembersTabPage.Size = new Size(192, 72);
            SearchMembersTabPage.TabIndex = 1;
            SearchMembersTabPage.Text = "Search Members";
            SearchMembersTabPage.UseVisualStyleBackColor = true;
            // 
            // MemberSearchUserControl
            // 
            MemberSearchUserControl.Dock = DockStyle.Fill;
            MemberSearchUserControl.Location = new Point(3, 3);
            MemberSearchUserControl.Name = "MemberSearchUserControl";
            MemberSearchUserControl.Size = new Size(186, 66);
            MemberSearchUserControl.TabIndex = 0;
            // 
            // RegisterMemberTabPage
            // 
            RegisterMemberTabPage.Controls.Add(MainDashboardMemberEditorUserControl);
            RegisterMemberTabPage.Location = new Point(4, 24);
            RegisterMemberTabPage.Name = "RegisterMemberTabPage";
            RegisterMemberTabPage.Padding = new Padding(3);
            RegisterMemberTabPage.Size = new Size(192, 72);
            RegisterMemberTabPage.TabIndex = 2;
            RegisterMemberTabPage.Text = "Register Member";
            RegisterMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboardMemberEditorUserControl
            // 
            MainDashboardMemberEditorUserControl.Dock = DockStyle.Fill;
            MainDashboardMemberEditorUserControl.Location = new Point(3, 3);
            MainDashboardMemberEditorUserControl.Name = "MainDashboardMemberEditorUserControl";
            MainDashboardMemberEditorUserControl.Size = new Size(186, 66);
            MainDashboardMemberEditorUserControl.TabIndex = 0;
            // 
            // SearchFurnitureTabPage
            // 
            SearchFurnitureTabPage.Location = new Point(4, 24);
            SearchFurnitureTabPage.Name = "SearchFurnitureTabPage";
            SearchFurnitureTabPage.Padding = new Padding(3);
            SearchFurnitureTabPage.Size = new Size(192, 72);
            SearchFurnitureTabPage.TabIndex = 3;
            SearchFurnitureTabPage.Text = "Search Furniture";
            SearchFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // CartTabPage
            // 
            CartTabPage.Location = new Point(4, 24);
            CartTabPage.Name = "CartTabPage";
            CartTabPage.Padding = new Padding(3);
            CartTabPage.Size = new Size(192, 72);
            CartTabPage.TabIndex = 4;
            CartTabPage.Text = "Cart";
            CartTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboardFlowLayoutPanel
            // 
            MainDashboardFlowLayoutPanel.Controls.Add(MainDashboardAdminLinkLabel);
            MainDashboardFlowLayoutPanel.Controls.Add(MainDashboardLogoutLinkLabel);
            MainDashboardFlowLayoutPanel.Dock = DockStyle.Fill;
            MainDashboardFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            MainDashboardFlowLayoutPanel.Location = new Point(3, 3);
            MainDashboardFlowLayoutPanel.Name = "MainDashboardFlowLayoutPanel";
            MainDashboardFlowLayoutPanel.Size = new Size(794, 53);
            MainDashboardFlowLayoutPanel.TabIndex = 1;
            // 
            // MainDashboardAdminLinkLabel
            // 
            MainDashboardAdminLinkLabel.AutoSize = true;
            MainDashboardAdminLinkLabel.Location = new Point(740, 0);
            MainDashboardAdminLinkLabel.Name = "MainDashboardAdminLinkLabel";
            MainDashboardAdminLinkLabel.Size = new Size(51, 15);
            MainDashboardAdminLinkLabel.TabIndex = 2;
            MainDashboardAdminLinkLabel.TabStop = true;
            MainDashboardAdminLinkLabel.Text = "(Admin)";
            MainDashboardAdminLinkLabel.LinkClicked += MainDashboardAdminLinkLabel_LinkClicked;
            // 
            // MainDashboardLogoutLinkLabel
            // 
            MainDashboardLogoutLinkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MainDashboardLogoutLinkLabel.AutoSize = true;
            MainDashboardLogoutLinkLabel.Location = new Point(689, 0);
            MainDashboardLogoutLinkLabel.Name = "MainDashboardLogoutLinkLabel";
            MainDashboardLogoutLinkLabel.Size = new Size(45, 15);
            MainDashboardLogoutLinkLabel.TabIndex = 1;
            MainDashboardLogoutLinkLabel.TabStop = true;
            MainDashboardLogoutLinkLabel.Text = "Logout";
            MainDashboardLogoutLinkLabel.LinkClicked += MainDashboardLogoutLinkLabel_LinkClicked;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(MainDashboardTableLayoutPanel);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Shown += MainDashboard_Shown;
            MainDashboardTableLayoutPanel.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            SearchMembersTabPage.ResumeLayout(false);
            RegisterMemberTabPage.ResumeLayout(false);
            MainDashboardFlowLayoutPanel.ResumeLayout(false);
            MainDashboardFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainDashboardTableLayoutPanel;
        private TabControl MainTabControl;
        private TabPage WelcomeTabPage;
        private TabPage SearchMembersTabPage;
        private TabPage RegisterMemberTabPage;
        private TabPage SearchFurnitureTabPage;
        private TabPage CartTabPage;
        private UserControls.MemberEditor MainDashboardMemberEditorUserControl;
        private UserControls.MemberSearch MemberSearchUserControl;
        private FlowLayoutPanel MainDashboardFlowLayoutPanel;
        private LinkLabel MainDashboardAdminLinkLabel;
        private LinkLabel MainDashboardLogoutLinkLabel;
    }
}