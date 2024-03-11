namespace RentMe.View
{
    partial class ShowMemberForm
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
            ShowMemberTableLayoutPanel = new TableLayoutPanel();
            ShowMemberFlowLayoutPanel = new FlowLayoutPanel();
            ShowMemberReturnItemsButton = new Button();
            ShowMembersAttachCartButton = new Button();
            ShowMemberCloseButton = new Button();
            ShowMemberMemberShowUserControl = new UserControls.MemberShow();
            ShowMemberTableLayoutPanel.SuspendLayout();
            ShowMemberFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ShowMemberTableLayoutPanel
            // 
            ShowMemberTableLayoutPanel.ColumnCount = 1;
            ShowMemberTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ShowMemberTableLayoutPanel.Controls.Add(ShowMemberFlowLayoutPanel, 0, 1);
            ShowMemberTableLayoutPanel.Controls.Add(ShowMemberMemberShowUserControl, 0, 0);
            ShowMemberTableLayoutPanel.Dock = DockStyle.Fill;
            ShowMemberTableLayoutPanel.Location = new Point(0, 0);
            ShowMemberTableLayoutPanel.Name = "ShowMemberTableLayoutPanel";
            ShowMemberTableLayoutPanel.RowCount = 2;
            ShowMemberTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ShowMemberTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            ShowMemberTableLayoutPanel.Size = new Size(800, 450);
            ShowMemberTableLayoutPanel.TabIndex = 0;
            // 
            // ShowMemberFlowLayoutPanel
            // 
            ShowMemberFlowLayoutPanel.Controls.Add(ShowMemberReturnItemsButton);
            ShowMemberFlowLayoutPanel.Controls.Add(ShowMembersAttachCartButton);
            ShowMemberFlowLayoutPanel.Controls.Add(ShowMemberCloseButton);
            ShowMemberFlowLayoutPanel.Dock = DockStyle.Fill;
            ShowMemberFlowLayoutPanel.Location = new Point(3, 403);
            ShowMemberFlowLayoutPanel.Name = "ShowMemberFlowLayoutPanel";
            ShowMemberFlowLayoutPanel.Size = new Size(794, 44);
            ShowMemberFlowLayoutPanel.TabIndex = 0;
            // 
            // ShowMemberReturnItemsButton
            // 
            ShowMemberReturnItemsButton.Location = new Point(3, 3);
            ShowMemberReturnItemsButton.Name = "ShowMemberReturnItemsButton";
            ShowMemberReturnItemsButton.Size = new Size(100, 23);
            ShowMemberReturnItemsButton.TabIndex = 0;
            ShowMemberReturnItemsButton.Text = "Return Items";
            ShowMemberReturnItemsButton.UseVisualStyleBackColor = true;
            ShowMemberReturnItemsButton.Click += ShowMemberReturnItemsButton_Click;
            // 
            // ShowMembersAttachCartButton
            // 
            ShowMembersAttachCartButton.Location = new Point(109, 3);
            ShowMembersAttachCartButton.Name = "ShowMembersAttachCartButton";
            ShowMembersAttachCartButton.Size = new Size(100, 23);
            ShowMembersAttachCartButton.TabIndex = 1;
            ShowMembersAttachCartButton.Text = "Attach To Cart";
            ShowMembersAttachCartButton.UseVisualStyleBackColor = true;
            ShowMembersAttachCartButton.Click += ShowMembersAttachCartButton_Click;
            // 
            // ShowMemberCloseButton
            // 
            ShowMemberCloseButton.Location = new Point(215, 3);
            ShowMemberCloseButton.Name = "ShowMemberCloseButton";
            ShowMemberCloseButton.Size = new Size(100, 23);
            ShowMemberCloseButton.TabIndex = 2;
            ShowMemberCloseButton.Text = "Close";
            ShowMemberCloseButton.UseVisualStyleBackColor = true;
            ShowMemberCloseButton.Click += ShowMemberCloseButton_Click;
            // 
            // ShowMemberMemberShowUserControl
            // 
            ShowMemberMemberShowUserControl.Location = new Point(3, 3);
            ShowMemberMemberShowUserControl.Name = "ShowMemberMemberShowUserControl";
            ShowMemberMemberShowUserControl.Size = new Size(794, 394);
            ShowMemberMemberShowUserControl.TabIndex = 1;
            // 
            // ShowMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowMemberTableLayoutPanel);
            Name = "ShowMemberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Show Member";
            ShowMemberTableLayoutPanel.ResumeLayout(false);
            ShowMemberFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ShowMemberTableLayoutPanel;
        private FlowLayoutPanel ShowMemberFlowLayoutPanel;
        private Button ShowMemberReturnItemsButton;
        private Button ShowMembersAttachCartButton;
        private Button ShowMemberCloseButton;
        private UserControls.MemberShow ShowMemberMemberShowUserControl;
    }
}