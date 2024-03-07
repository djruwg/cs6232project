namespace RentMe.View
{
    partial class EditMemberForm
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
            EditMemberTableLayoutPanel = new TableLayoutPanel();
            EditMemberFormMemberIDLabel = new Label();
            EditMemberMemberEditorUserControl = new UserControls.MemberEditor();
            EditMemberFormMemberIDTextBox = new TextBox();
            EditMemberTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EditMemberTableLayoutPanel
            // 
            EditMemberTableLayoutPanel.ColumnCount = 3;
            EditMemberTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            EditMemberTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            EditMemberTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 556F));
            EditMemberTableLayoutPanel.Controls.Add(EditMemberFormMemberIDLabel, 0, 0);
            EditMemberTableLayoutPanel.Controls.Add(EditMemberMemberEditorUserControl, 0, 1);
            EditMemberTableLayoutPanel.Controls.Add(EditMemberFormMemberIDTextBox, 1, 0);
            EditMemberTableLayoutPanel.Dock = DockStyle.Fill;
            EditMemberTableLayoutPanel.Location = new Point(5, 5);
            EditMemberTableLayoutPanel.Name = "EditMemberTableLayoutPanel";
            EditMemberTableLayoutPanel.RowCount = 2;
            EditMemberTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.888889F));
            EditMemberTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 93.1111145F));
            EditMemberTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EditMemberTableLayoutPanel.Size = new Size(790, 440);
            EditMemberTableLayoutPanel.TabIndex = 0;
            // 
            // EditMemberFormMemberIDLabel
            // 
            EditMemberFormMemberIDLabel.Anchor = AnchorStyles.Left;
            EditMemberFormMemberIDLabel.AutoSize = true;
            EditMemberFormMemberIDLabel.Location = new Point(3, 7);
            EditMemberFormMemberIDLabel.Name = "EditMemberFormMemberIDLabel";
            EditMemberFormMemberIDLabel.Padding = new Padding(3, 0, 0, 0);
            EditMemberFormMemberIDLabel.Size = new Size(69, 15);
            EditMemberFormMemberIDLabel.TabIndex = 0;
            EditMemberFormMemberIDLabel.Text = "Member ID";
            // 
            // EditMemberMemberEditorUserControl
            // 
            EditMemberTableLayoutPanel.SetColumnSpan(EditMemberMemberEditorUserControl, 3);
            EditMemberMemberEditorUserControl.Dock = DockStyle.Fill;
            EditMemberMemberEditorUserControl.Location = new Point(3, 33);
            EditMemberMemberEditorUserControl.Name = "EditMemberMemberEditorUserControl";
            EditMemberMemberEditorUserControl.Size = new Size(784, 404);
            EditMemberMemberEditorUserControl.TabIndex = 2;
            // 
            // EditMemberFormMemberIDTextBox
            // 
            EditMemberFormMemberIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EditMemberFormMemberIDTextBox.Enabled = false;
            EditMemberFormMemberIDTextBox.Location = new Point(80, 3);
            EditMemberFormMemberIDTextBox.Name = "EditMemberFormMemberIDTextBox";
            EditMemberFormMemberIDTextBox.Size = new Size(149, 23);
            EditMemberFormMemberIDTextBox.TabIndex = 1;
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditMemberTableLayoutPanel);
            Name = "EditMemberForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMemberForm";
            EditMemberTableLayoutPanel.ResumeLayout(false);
            EditMemberTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel EditMemberTableLayoutPanel;
        private Label EditMemberFormMemberIDLabel;
        private TextBox EditMemberFormMemberIDTextBox;
        private UserControls.MemberEditor EditMemberMemberEditorUserControl;
    }
}