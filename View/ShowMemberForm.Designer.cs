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
            ShowMemberMemberShowUserControl = new UserControls.MemberShow();
            SuspendLayout();
            // 
            // ShowMemberMemberShowUserControl
            // 
            ShowMemberMemberShowUserControl.Dock = DockStyle.Fill;
            ShowMemberMemberShowUserControl.Location = new Point(0, 0);
            ShowMemberMemberShowUserControl.Name = "ShowMemberMemberShowUserControl";
            ShowMemberMemberShowUserControl.Size = new Size(800, 450);
            ShowMemberMemberShowUserControl.TabIndex = 0;
            // 
            // ShowMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowMemberMemberShowUserControl);
            Name = "ShowMemberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Show Member";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.MemberShow ShowMemberMemberShowUserControl;
    }
}