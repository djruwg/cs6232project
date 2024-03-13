namespace RentMe.View
{
    partial class ReportForm
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
            ReportFormLayoutPanel = new TableLayoutPanel();
            ReportFormDataGridView = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ReportFormStartDateLabel = new Label();
            ReportFormStartDatePicker = new DateTimePicker();
            ReportFormEndDateLabel = new Label();
            ReportFormEndDatePicker = new DateTimePicker();
            ReportFormRunReportButton = new Button();
            ReportFormLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportFormDataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ReportFormLayoutPanel
            // 
            ReportFormLayoutPanel.ColumnCount = 1;
            ReportFormLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            ReportFormLayoutPanel.Controls.Add(ReportFormDataGridView, 0, 1);
            ReportFormLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 0);
            ReportFormLayoutPanel.Dock = DockStyle.Fill;
            ReportFormLayoutPanel.Location = new Point(0, 0);
            ReportFormLayoutPanel.Name = "ReportFormLayoutPanel";
            ReportFormLayoutPanel.RowCount = 2;
            ReportFormLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            ReportFormLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            ReportFormLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ReportFormLayoutPanel.Size = new Size(800, 450);
            ReportFormLayoutPanel.TabIndex = 0;
            // 
            // ReportFormDataGridView
            // 
            ReportFormDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportFormDataGridView.Dock = DockStyle.Fill;
            ReportFormDataGridView.Location = new Point(3, 47);
            ReportFormDataGridView.Name = "ReportFormDataGridView";
            ReportFormDataGridView.Size = new Size(794, 400);
            ReportFormDataGridView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            ReportFormLayoutPanel.SetColumnSpan(flowLayoutPanel1, 5);
            flowLayoutPanel1.Controls.Add(ReportFormStartDateLabel);
            flowLayoutPanel1.Controls.Add(ReportFormStartDatePicker);
            flowLayoutPanel1.Controls.Add(ReportFormEndDateLabel);
            flowLayoutPanel1.Controls.Add(ReportFormEndDatePicker);
            flowLayoutPanel1.Controls.Add(ReportFormRunReportButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel1.Size = new Size(794, 38);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // ReportFormStartDateLabel
            // 
            ReportFormStartDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportFormStartDateLabel.AutoSize = true;
            ReportFormStartDateLabel.Location = new Point(3, 12);
            ReportFormStartDateLabel.Name = "ReportFormStartDateLabel";
            ReportFormStartDateLabel.Size = new Size(58, 15);
            ReportFormStartDateLabel.TabIndex = 3;
            ReportFormStartDateLabel.Text = "Start Date";
            // 
            // ReportFormStartDatePicker
            // 
            ReportFormStartDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReportFormStartDatePicker.Format = DateTimePickerFormat.Short;
            ReportFormStartDatePicker.Location = new Point(67, 8);
            ReportFormStartDatePicker.Name = "ReportFormStartDatePicker";
            ReportFormStartDatePicker.Size = new Size(154, 23);
            ReportFormStartDatePicker.TabIndex = 2;
            // 
            // ReportFormEndDateLabel
            // 
            ReportFormEndDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportFormEndDateLabel.AutoSize = true;
            ReportFormEndDateLabel.Location = new Point(227, 12);
            ReportFormEndDateLabel.Name = "ReportFormEndDateLabel";
            ReportFormEndDateLabel.Size = new Size(54, 15);
            ReportFormEndDateLabel.TabIndex = 4;
            ReportFormEndDateLabel.Text = "End Date";
            // 
            // ReportFormEndDatePicker
            // 
            ReportFormEndDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReportFormEndDatePicker.Format = DateTimePickerFormat.Short;
            ReportFormEndDatePicker.Location = new Point(287, 8);
            ReportFormEndDatePicker.Name = "ReportFormEndDatePicker";
            ReportFormEndDatePicker.Size = new Size(154, 23);
            ReportFormEndDatePicker.TabIndex = 1;
            // 
            // ReportFormRunReportButton
            // 
            ReportFormRunReportButton.Location = new Point(447, 8);
            ReportFormRunReportButton.Name = "ReportFormRunReportButton";
            ReportFormRunReportButton.Size = new Size(75, 23);
            ReportFormRunReportButton.TabIndex = 5;
            ReportFormRunReportButton.Text = "Run Report";
            ReportFormRunReportButton.UseVisualStyleBackColor = true;
            ReportFormRunReportButton.Click += ReportFormRunReportButton_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportFormLayoutPanel);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporting";
            ReportFormLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReportFormDataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ReportFormLayoutPanel;
        private DataGridView ReportFormDataGridView;
        private DateTimePicker ReportFormEndDatePicker;
        private DateTimePicker ReportFormStartDatePicker;
        private Label ReportFormStartDateLabel;
        private Label ReportFormEndDateLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ReportFormRunReportButton;
    }
}