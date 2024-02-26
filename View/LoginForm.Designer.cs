namespace RentMe.View
{
    partial class LoginForm
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ErrorMessageLabel = new Label();
            LoginButton = new Button();
            LoginTableLayoutPanel = new TableLayoutPanel();
            LoginTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(7, 5);
            UsernameLabel.Margin = new Padding(2, 0, 2, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(7, 30);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Location = new Point(84, 6);
            UsernameTextBox.Margin = new Padding(2, 1, 2, 1);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(233, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(84, 31);
            PasswordTextBox.Margin = new Padding(2, 1, 2, 1);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(233, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.AutoSize = true;
            LoginTableLayoutPanel.SetColumnSpan(ErrorMessageLabel, 2);
            ErrorMessageLabel.ForeColor = Color.Red;
            ErrorMessageLabel.Location = new Point(7, 55);
            ErrorMessageLabel.Margin = new Padding(2, 0, 2, 0);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(0, 15);
            ErrorMessageLabel.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(84, 71);
            LoginButton.Margin = new Padding(2, 1, 2, 1);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(81, 22);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginTableLayoutPanel
            // 
            LoginTableLayoutPanel.ColumnCount = 2;
            LoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            LoginTableLayoutPanel.Controls.Add(UsernameLabel, 0, 0);
            LoginTableLayoutPanel.Controls.Add(LoginButton, 1, 3);
            LoginTableLayoutPanel.Controls.Add(PasswordTextBox, 1, 1);
            LoginTableLayoutPanel.Controls.Add(ErrorMessageLabel, 0, 2);
            LoginTableLayoutPanel.Controls.Add(PasswordLabel, 0, 1);
            LoginTableLayoutPanel.Controls.Add(UsernameTextBox, 1, 0);
            LoginTableLayoutPanel.Dock = DockStyle.Fill;
            LoginTableLayoutPanel.Location = new Point(0, 0);
            LoginTableLayoutPanel.Margin = new Padding(2, 1, 2, 1);
            LoginTableLayoutPanel.Name = "LoginTableLayoutPanel";
            LoginTableLayoutPanel.Padding = new Padding(5, 5, 5, 5);
            LoginTableLayoutPanel.RowCount = 4;
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            LoginTableLayoutPanel.Size = new Size(324, 102);
            LoginTableLayoutPanel.TabIndex = 6;
            // 
            // LoginForm
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 102);
            Controls.Add(LoginTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LoginTableLayoutPanel.ResumeLayout(false);
            LoginTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label ErrorMessageLabel;
        private Button LoginButton;
        private TableLayoutPanel LoginTableLayoutPanel;
    }
}
