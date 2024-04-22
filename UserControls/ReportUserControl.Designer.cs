namespace RentMe.UserControls
{
    partial class ReportUserControl
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
            ReportUserControlDataGridView = new DataGridView();
            ReportUserControlLayoutPanel = new TableLayoutPanel();
            ReportUserControlFlowLayoutPane = new FlowLayoutPanel();
            ReportUserControlStartDateLabel = new Label();
            ReportUserControlStartDatePicker = new DateTimePicker();
            ReportUserControlEndDateLabel = new Label();
            ReportUserControlEndDatePicker = new DateTimePicker();
            ReportUserControlRunReportButton = new Button();
            ReportUserControlMessageLabel = new Label();
            ReportUserControlDescriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ReportUserControlDataGridView).BeginInit();
            ReportUserControlLayoutPanel.SuspendLayout();
            ReportUserControlFlowLayoutPane.SuspendLayout();
            SuspendLayout();
            // 
            // ReportUserControlDataGridView
            // 
            ReportUserControlDataGridView.AllowUserToAddRows = false;
            ReportUserControlDataGridView.AllowUserToDeleteRows = false;
            ReportUserControlDataGridView.AllowUserToResizeRows = false;
            ReportUserControlDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportUserControlDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportUserControlDataGridView.Dock = DockStyle.Fill;
            ReportUserControlDataGridView.Location = new Point(3, 47);
            ReportUserControlDataGridView.MultiSelect = false;
            ReportUserControlDataGridView.Name = "ReportUserControlDataGridView";
            ReportUserControlDataGridView.ReadOnly = true;
            ReportUserControlDataGridView.RowHeadersVisible = false;
            ReportUserControlDataGridView.Size = new Size(795, 453);
            ReportUserControlDataGridView.TabIndex = 0;
            // 
            // ReportUserControlLayoutPanel
            // 
            ReportUserControlLayoutPanel.ColumnCount = 1;
            ReportUserControlLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            ReportUserControlLayoutPanel.Controls.Add(ReportUserControlDataGridView, 0, 1);
            ReportUserControlLayoutPanel.Controls.Add(ReportUserControlFlowLayoutPane, 0, 0);
            ReportUserControlLayoutPanel.Controls.Add(ReportUserControlDescriptionLabel, 0, 2);
            ReportUserControlLayoutPanel.Dock = DockStyle.Fill;
            ReportUserControlLayoutPanel.Location = new Point(0, 0);
            ReportUserControlLayoutPanel.Name = "ReportUserControlLayoutPanel";
            ReportUserControlLayoutPanel.RowCount = 3;
            ReportUserControlLayoutPanel.RowStyles.Add(new RowStyle());
            ReportUserControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ReportUserControlLayoutPanel.RowStyles.Add(new RowStyle());
            ReportUserControlLayoutPanel.Size = new Size(801, 547);
            ReportUserControlLayoutPanel.TabIndex = 1;
            // 
            // ReportUserControlFlowLayoutPane
            // 
            ReportUserControlLayoutPanel.SetColumnSpan(ReportUserControlFlowLayoutPane, 5);
            ReportUserControlFlowLayoutPane.Controls.Add(ReportUserControlStartDateLabel);
            ReportUserControlFlowLayoutPane.Controls.Add(ReportUserControlStartDatePicker);
            ReportUserControlFlowLayoutPane.Controls.Add(ReportUserControlEndDateLabel);
            ReportUserControlFlowLayoutPane.Controls.Add(ReportUserControlEndDatePicker);
            ReportUserControlFlowLayoutPane.Controls.Add(ReportUserControlRunReportButton);
            ReportUserControlFlowLayoutPane.Controls.Add(ReportUserControlMessageLabel);
            ReportUserControlFlowLayoutPane.Dock = DockStyle.Fill;
            ReportUserControlFlowLayoutPane.Location = new Point(3, 3);
            ReportUserControlFlowLayoutPane.Name = "ReportUserControlFlowLayoutPane";
            ReportUserControlFlowLayoutPane.Padding = new Padding(0, 5, 0, 0);
            ReportUserControlFlowLayoutPane.Size = new Size(795, 38);
            ReportUserControlFlowLayoutPane.TabIndex = 5;
            // 
            // ReportUserControlStartDateLabel
            // 
            ReportUserControlStartDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportUserControlStartDateLabel.AutoSize = true;
            ReportUserControlStartDateLabel.Location = new Point(3, 12);
            ReportUserControlStartDateLabel.Name = "ReportUserControlStartDateLabel";
            ReportUserControlStartDateLabel.Size = new Size(58, 15);
            ReportUserControlStartDateLabel.TabIndex = 3;
            ReportUserControlStartDateLabel.Text = "Start Date";
            // 
            // ReportUserControlStartDatePicker
            // 
            ReportUserControlStartDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReportUserControlStartDatePicker.Format = DateTimePickerFormat.Short;
            ReportUserControlStartDatePicker.Location = new Point(67, 8);
            ReportUserControlStartDatePicker.Name = "ReportUserControlStartDatePicker";
            ReportUserControlStartDatePicker.Size = new Size(154, 23);
            ReportUserControlStartDatePicker.TabIndex = 2;
            // 
            // ReportUserControlEndDateLabel
            // 
            ReportUserControlEndDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportUserControlEndDateLabel.AutoSize = true;
            ReportUserControlEndDateLabel.Location = new Point(227, 12);
            ReportUserControlEndDateLabel.Name = "ReportUserControlEndDateLabel";
            ReportUserControlEndDateLabel.Size = new Size(54, 15);
            ReportUserControlEndDateLabel.TabIndex = 4;
            ReportUserControlEndDateLabel.Text = "End Date";
            // 
            // ReportUserControlEndDatePicker
            // 
            ReportUserControlEndDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReportUserControlEndDatePicker.Format = DateTimePickerFormat.Short;
            ReportUserControlEndDatePicker.Location = new Point(287, 8);
            ReportUserControlEndDatePicker.Name = "ReportUserControlEndDatePicker";
            ReportUserControlEndDatePicker.Size = new Size(154, 23);
            ReportUserControlEndDatePicker.TabIndex = 1;
            // 
            // ReportUserControlRunReportButton
            // 
            ReportUserControlRunReportButton.Location = new Point(447, 8);
            ReportUserControlRunReportButton.Name = "ReportUserControlRunReportButton";
            ReportUserControlRunReportButton.Size = new Size(75, 23);
            ReportUserControlRunReportButton.TabIndex = 5;
            ReportUserControlRunReportButton.Text = "Run Report";
            ReportUserControlRunReportButton.UseVisualStyleBackColor = true;
            ReportUserControlRunReportButton.Click += ReportFormRunReportButton_Click;
            // 
            // ReportUserControlMessageLabel
            // 
            ReportUserControlMessageLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportUserControlMessageLabel.AutoSize = true;
            ReportUserControlMessageLabel.ForeColor = Color.Red;
            ReportUserControlMessageLabel.Location = new Point(528, 12);
            ReportUserControlMessageLabel.Name = "ReportUserControlMessageLabel";
            ReportUserControlMessageLabel.Size = new Size(84, 15);
            ReportUserControlMessageLabel.TabIndex = 6;
            ReportUserControlMessageLabel.Text = "Message Label";
            // 
            // ReportUserControlDescriptionLabel
            // 
            ReportUserControlDescriptionLabel.Dock = DockStyle.Fill;
            ReportUserControlDescriptionLabel.Location = new Point(3, 503);
            ReportUserControlDescriptionLabel.Name = "ReportUserControlDescriptionLabel";
            ReportUserControlDescriptionLabel.Size = new Size(795, 44);
            ReportUserControlDescriptionLabel.TabIndex = 7;
            ReportUserControlDescriptionLabel.Text = "Gets the statistics that show the most popular furniture during the specified period for furniture with the same furninture ID that was rented out in at least two transactions.";
            // 
            // ReportUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(ReportUserControlLayoutPanel);
            Name = "ReportUserControl";
            Size = new Size(801, 547);
            ((System.ComponentModel.ISupportInitialize)ReportUserControlDataGridView).EndInit();
            ReportUserControlLayoutPanel.ResumeLayout(false);
            ReportUserControlFlowLayoutPane.ResumeLayout(false);
            ReportUserControlFlowLayoutPane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReportUserControlDataGridView;
        private TableLayoutPanel ReportUserControlLayoutPanel;
        private FlowLayoutPanel ReportUserControlFlowLayoutPane;
        private Label ReportUserControlStartDateLabel;
        private DateTimePicker ReportUserControlStartDatePicker;
        private Label ReportUserControlEndDateLabel;
        private DateTimePicker ReportUserControlEndDatePicker;
        private Button ReportUserControlRunReportButton;
        private Label ReportUserControlMessageLabel;
        private Label ReportUserControlDescriptionLabel;
    }
}
