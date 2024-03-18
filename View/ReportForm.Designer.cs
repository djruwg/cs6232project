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
            ReportFormFlowLayoutPane = new FlowLayoutPanel();
            ReportFormStartDateLabel = new Label();
            ReportFormStartDatePicker = new DateTimePicker();
            ReportFormEndDateLabel = new Label();
            ReportFormEndDatePicker = new DateTimePicker();
            ReportFormRunReportButton = new Button();
            ReportFormMessageLabel = new Label();
            ReportFormLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportFormDataGridView).BeginInit();
            ReportFormFlowLayoutPane.SuspendLayout();
            SuspendLayout();
            // 
            // ReportFormLayoutPanel
            // 
            ReportFormLayoutPanel.ColumnCount = 1;
            ReportFormLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            ReportFormLayoutPanel.Controls.Add(ReportFormDataGridView, 0, 1);
            ReportFormLayoutPanel.Controls.Add(ReportFormFlowLayoutPane, 0, 0);
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
            // ReportFormFlowLayoutPane
            // 
            ReportFormLayoutPanel.SetColumnSpan(ReportFormFlowLayoutPane, 5);
            ReportFormFlowLayoutPane.Controls.Add(ReportFormStartDateLabel);
            ReportFormFlowLayoutPane.Controls.Add(ReportFormStartDatePicker);
            ReportFormFlowLayoutPane.Controls.Add(ReportFormEndDateLabel);
            ReportFormFlowLayoutPane.Controls.Add(ReportFormEndDatePicker);
            ReportFormFlowLayoutPane.Controls.Add(ReportFormRunReportButton);
            ReportFormFlowLayoutPane.Controls.Add(ReportFormMessageLabel);
            ReportFormFlowLayoutPane.Dock = DockStyle.Fill;
            ReportFormFlowLayoutPane.Location = new Point(3, 3);
            ReportFormFlowLayoutPane.Name = "ReportFormFlowLayoutPane";
            ReportFormFlowLayoutPane.Padding = new Padding(0, 5, 0, 0);
            ReportFormFlowLayoutPane.Size = new Size(794, 38);
            ReportFormFlowLayoutPane.TabIndex = 5;
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
            // ReportFormMessageLabel
            // 
            ReportFormMessageLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportFormMessageLabel.AutoSize = true;
            ReportFormMessageLabel.ForeColor = Color.Red;
            ReportFormMessageLabel.Location = new Point(528, 12);
            ReportFormMessageLabel.Name = "ReportFormMessageLabel";
            ReportFormMessageLabel.Size = new Size(84, 15);
            ReportFormMessageLabel.TabIndex = 6;
            ReportFormMessageLabel.Text = "Message Label";
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
            ReportFormFlowLayoutPane.ResumeLayout(false);
            ReportFormFlowLayoutPane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ReportFormLayoutPanel;
        private DataGridView ReportFormDataGridView;
        private DateTimePicker ReportFormEndDatePicker;
        private DateTimePicker ReportFormStartDatePicker;
        private Label ReportFormStartDateLabel;
        private Label ReportFormEndDateLabel;
        private FlowLayoutPanel ReportFormFlowLayoutPane;
        private Button ReportFormRunReportButton;
        private Label ReportFormMessageLabel;
    }
}