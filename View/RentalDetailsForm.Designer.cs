namespace RentMe.View
{
    partial class RentalDetailsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            RentalDetailsRentalIDLabel = new Label();
            RentalDetailsDueDateLabel = new Label();
            RentalDetailsRentalIDTextBox = new TextBox();
            RentalDetailsDataGridView = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            RentalDetailsDueDateTimePicker = new DateTimePicker();
            RentalDetailsTotalLabel = new Label();
            RentalDetailsTotalTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RentalDetailsDataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(RentalDetailsRentalIDLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(RentalDetailsDueDateLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(RentalDetailsRentalIDTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(RentalDetailsDataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(RentalDetailsDueDateTimePicker, 3, 0);
            tableLayoutPanel1.Controls.Add(RentalDetailsTotalLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(RentalDetailsTotalTextBox, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RentalDetailsRentalIDLabel
            // 
            RentalDetailsRentalIDLabel.Anchor = AnchorStyles.Left;
            RentalDetailsRentalIDLabel.AutoSize = true;
            RentalDetailsRentalIDLabel.Location = new Point(3, 7);
            RentalDetailsRentalIDLabel.Name = "RentalDetailsRentalIDLabel";
            RentalDetailsRentalIDLabel.Size = new Size(54, 15);
            RentalDetailsRentalIDLabel.TabIndex = 0;
            RentalDetailsRentalIDLabel.Text = "Rental ID";
            // 
            // RentalDetailsDueDateLabel
            // 
            RentalDetailsDueDateLabel.Anchor = AnchorStyles.Left;
            RentalDetailsDueDateLabel.AutoSize = true;
            RentalDetailsDueDateLabel.Location = new Point(323, 7);
            RentalDetailsDueDateLabel.Name = "RentalDetailsDueDateLabel";
            RentalDetailsDueDateLabel.Size = new Size(55, 15);
            RentalDetailsDueDateLabel.TabIndex = 1;
            RentalDetailsDueDateLabel.Text = "Due Date";
            // 
            // RentalDetailsRentalIDTextBox
            // 
            RentalDetailsRentalIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RentalDetailsRentalIDTextBox.Location = new Point(163, 3);
            RentalDetailsRentalIDTextBox.Name = "RentalDetailsRentalIDTextBox";
            RentalDetailsRentalIDTextBox.Size = new Size(154, 23);
            RentalDetailsRentalIDTextBox.TabIndex = 2;
            // 
            // RentalDetailsDataGridView
            // 
            RentalDetailsDataGridView.AllowUserToAddRows = false;
            RentalDetailsDataGridView.AllowUserToDeleteRows = false;
            RentalDetailsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            RentalDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(RentalDetailsDataGridView, 5);
            RentalDetailsDataGridView.Dock = DockStyle.Fill;
            RentalDetailsDataGridView.Location = new Point(3, 32);
            RentalDetailsDataGridView.Name = "RentalDetailsDataGridView";
            RentalDetailsDataGridView.ReadOnly = true;
            RentalDetailsDataGridView.RowHeadersVisible = false;
            RentalDetailsDataGridView.Size = new Size(794, 280);
            RentalDetailsDataGridView.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 5);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 347);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 100);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(84, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // RentalDetailsDueDateTimePicker
            // 
            RentalDetailsDueDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RentalDetailsDueDateTimePicker.Location = new Point(483, 3);
            RentalDetailsDueDateTimePicker.Name = "RentalDetailsDueDateTimePicker";
            RentalDetailsDueDateTimePicker.Size = new Size(154, 23);
            RentalDetailsDueDateTimePicker.TabIndex = 6;
            // 
            // RentalDetailsTotalLabel
            // 
            RentalDetailsTotalLabel.Anchor = AnchorStyles.Left;
            RentalDetailsTotalLabel.AutoSize = true;
            RentalDetailsTotalLabel.Location = new Point(323, 322);
            RentalDetailsTotalLabel.Name = "RentalDetailsTotalLabel";
            RentalDetailsTotalLabel.Size = new Size(32, 15);
            RentalDetailsTotalLabel.TabIndex = 7;
            RentalDetailsTotalLabel.Text = "Total";
            // 
            // RentalDetailsTotalTextBox
            // 
            RentalDetailsTotalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RentalDetailsTotalTextBox.Enabled = false;
            RentalDetailsTotalTextBox.Location = new Point(483, 318);
            RentalDetailsTotalTextBox.Name = "RentalDetailsTotalTextBox";
            RentalDetailsTotalTextBox.Size = new Size(154, 23);
            RentalDetailsTotalTextBox.TabIndex = 8;
            // 
            // RentalDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "RentalDetailsForm";
            Text = "Rental Transaction Details";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RentalDetailsDataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label RentalDetailsRentalIDLabel;
        private Label RentalDetailsDueDateLabel;
        private TextBox RentalDetailsRentalIDTextBox;
        private DataGridView RentalDetailsDataGridView;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private DateTimePicker RentalDetailsDueDateTimePicker;
        private Label RentalDetailsTotalLabel;
        private TextBox RentalDetailsTotalTextBox;
    }
}