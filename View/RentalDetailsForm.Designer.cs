﻿namespace RentMe.View
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
            RentalDetailsTableLayoutPanel = new TableLayoutPanel();
            RentalDetailsRentalIDLabel = new Label();
            RentalDetailsDueDateLabel = new Label();
            RentalDetailsRentalIDTextBox = new TextBox();
            RentalDetailsDataGridView = new DataGridView();
            RentalDetailsDueDateTimePicker = new DateTimePicker();
            RentalDetailsTotalLabel = new Label();
            RentalDetailsTotalTextBox = new TextBox();
            RentalDetailsConfirmButton = new Button();
            RentalDetailsCloseBotton = new Button();
            RentalDetailsCancelButton = new Button();
            RentalDetailsMessageLabel = new Label();
            RentalDetailsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RentalDetailsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // RentalDetailsTableLayoutPanel
            // 
            RentalDetailsTableLayoutPanel.ColumnCount = 5;
            RentalDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            RentalDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            RentalDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            RentalDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            RentalDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsRentalIDLabel, 0, 0);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsDueDateLabel, 2, 0);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsRentalIDTextBox, 1, 0);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsDataGridView, 0, 1);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsDueDateTimePicker, 3, 0);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsTotalLabel, 2, 2);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsTotalTextBox, 3, 2);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsConfirmButton, 0, 4);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsCloseBotton, 1, 4);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsCancelButton, 4, 4);
            RentalDetailsTableLayoutPanel.Controls.Add(RentalDetailsMessageLabel, 0, 2);
            RentalDetailsTableLayoutPanel.Dock = DockStyle.Fill;
            RentalDetailsTableLayoutPanel.Location = new Point(0, 0);
            RentalDetailsTableLayoutPanel.Name = "RentalDetailsTableLayoutPanel";
            RentalDetailsTableLayoutPanel.RowCount = 4;
            RentalDetailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            RentalDetailsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RentalDetailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            RentalDetailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            RentalDetailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            RentalDetailsTableLayoutPanel.Size = new Size(800, 450);
            RentalDetailsTableLayoutPanel.TabIndex = 0;
            // 
            // RentalDetailsRentalIDLabel
            // 
            RentalDetailsRentalIDLabel.Anchor = AnchorStyles.Right;
            RentalDetailsRentalIDLabel.AutoSize = true;
            RentalDetailsRentalIDLabel.Location = new Point(103, 7);
            RentalDetailsRentalIDLabel.Name = "RentalDetailsRentalIDLabel";
            RentalDetailsRentalIDLabel.Size = new Size(54, 15);
            RentalDetailsRentalIDLabel.TabIndex = 0;
            RentalDetailsRentalIDLabel.Text = "Rental ID";
            // 
            // RentalDetailsDueDateLabel
            // 
            RentalDetailsDueDateLabel.Anchor = AnchorStyles.Right;
            RentalDetailsDueDateLabel.AutoSize = true;
            RentalDetailsDueDateLabel.Location = new Point(422, 7);
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
            RentalDetailsRentalIDTextBox.ReadOnly = true;
            RentalDetailsRentalIDTextBox.Size = new Size(154, 23);
            RentalDetailsRentalIDTextBox.TabIndex = 2;
            // 
            // RentalDetailsDataGridView
            // 
            RentalDetailsDataGridView.AllowUserToAddRows = false;
            RentalDetailsDataGridView.AllowUserToDeleteRows = false;
            RentalDetailsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            RentalDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentalDetailsTableLayoutPanel.SetColumnSpan(RentalDetailsDataGridView, 5);
            RentalDetailsDataGridView.Dock = DockStyle.Fill;
            RentalDetailsDataGridView.Location = new Point(3, 32);
            RentalDetailsDataGridView.Name = "RentalDetailsDataGridView";
            RentalDetailsDataGridView.ReadOnly = true;
            RentalDetailsDataGridView.RowHeadersVisible = false;
            RentalDetailsDataGridView.Size = new Size(794, 357);
            RentalDetailsDataGridView.TabIndex = 4;
            // 
            // RentalDetailsDueDateTimePicker
            // 
            RentalDetailsDueDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RentalDetailsTableLayoutPanel.SetColumnSpan(RentalDetailsDueDateTimePicker, 2);
            RentalDetailsDueDateTimePicker.Location = new Point(483, 3);
            RentalDetailsDueDateTimePicker.Name = "RentalDetailsDueDateTimePicker";
            RentalDetailsDueDateTimePicker.Size = new Size(314, 23);
            RentalDetailsDueDateTimePicker.TabIndex = 6;
            RentalDetailsDueDateTimePicker.ValueChanged += RentalDetailsDueDateTimePicker_ValueChanged;
            // 
            // RentalDetailsTotalLabel
            // 
            RentalDetailsTotalLabel.Anchor = AnchorStyles.Right;
            RentalDetailsTotalLabel.AutoSize = true;
            RentalDetailsTotalLabel.Location = new Point(445, 399);
            RentalDetailsTotalLabel.Name = "RentalDetailsTotalLabel";
            RentalDetailsTotalLabel.Size = new Size(32, 15);
            RentalDetailsTotalLabel.TabIndex = 7;
            RentalDetailsTotalLabel.Text = "Total";
            // 
            // RentalDetailsTotalTextBox
            // 
            RentalDetailsTotalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RentalDetailsTableLayoutPanel.SetColumnSpan(RentalDetailsTotalTextBox, 2);
            RentalDetailsTotalTextBox.Enabled = false;
            RentalDetailsTotalTextBox.Location = new Point(483, 395);
            RentalDetailsTotalTextBox.Name = "RentalDetailsTotalTextBox";
            RentalDetailsTotalTextBox.Size = new Size(314, 23);
            RentalDetailsTotalTextBox.TabIndex = 8;
            // 
            // RentalDetailsConfirmButton
            // 
            RentalDetailsConfirmButton.Anchor = AnchorStyles.Top;
            RentalDetailsConfirmButton.Location = new Point(42, 424);
            RentalDetailsConfirmButton.Name = "RentalDetailsConfirmButton";
            RentalDetailsConfirmButton.Size = new Size(75, 23);
            RentalDetailsConfirmButton.TabIndex = 9;
            RentalDetailsConfirmButton.Text = "Confirm";
            RentalDetailsConfirmButton.UseVisualStyleBackColor = true;
            RentalDetailsConfirmButton.Click += RentalDetailsConfirmButton_Click;
            // 
            // RentalDetailsCloseBotton
            // 
            RentalDetailsCloseBotton.Anchor = AnchorStyles.Top;
            RentalDetailsCloseBotton.Enabled = false;
            RentalDetailsCloseBotton.Location = new Point(202, 424);
            RentalDetailsCloseBotton.Name = "RentalDetailsCloseBotton";
            RentalDetailsCloseBotton.Size = new Size(75, 23);
            RentalDetailsCloseBotton.TabIndex = 10;
            RentalDetailsCloseBotton.Text = "Close";
            RentalDetailsCloseBotton.UseVisualStyleBackColor = true;
            RentalDetailsCloseBotton.Click += RentalDetailsCloseBotton_Click;
            // 
            // RentalDetailsCancelButton
            // 
            RentalDetailsCancelButton.Anchor = AnchorStyles.Top;
            RentalDetailsCancelButton.Location = new Point(682, 424);
            RentalDetailsCancelButton.Name = "RentalDetailsCancelButton";
            RentalDetailsCancelButton.Size = new Size(75, 23);
            RentalDetailsCancelButton.TabIndex = 11;
            RentalDetailsCancelButton.Text = "Canel";
            RentalDetailsCancelButton.UseVisualStyleBackColor = true;
            RentalDetailsCancelButton.Click += RentalDetailsCancelButton_Click;
            // 
            // RentalDetailsMessageLabel
            // 
            RentalDetailsMessageLabel.Anchor = AnchorStyles.Left;
            RentalDetailsMessageLabel.AutoSize = true;
            RentalDetailsTableLayoutPanel.SetColumnSpan(RentalDetailsMessageLabel, 2);
            RentalDetailsMessageLabel.ForeColor = Color.Red;
            RentalDetailsMessageLabel.Location = new Point(20, 399);
            RentalDetailsMessageLabel.Margin = new Padding(20, 0, 3, 0);
            RentalDetailsMessageLabel.Name = "RentalDetailsMessageLabel";
            RentalDetailsMessageLabel.Size = new Size(78, 15);
            RentalDetailsMessageLabel.TabIndex = 12;
            RentalDetailsMessageLabel.Text = "Message area";
            RentalDetailsMessageLabel.Visible = false;
            // 
            // RentalDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RentalDetailsTableLayoutPanel);
            Name = "RentalDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rental Transaction Details";
            RentalDetailsTableLayoutPanel.ResumeLayout(false);
            RentalDetailsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RentalDetailsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel RentalDetailsTableLayoutPanel;
        private Label RentalDetailsRentalIDLabel;
        private Label RentalDetailsDueDateLabel;
        private TextBox RentalDetailsRentalIDTextBox;
        private DataGridView RentalDetailsDataGridView;
        private DateTimePicker RentalDetailsDueDateTimePicker;
        private Label RentalDetailsTotalLabel;
        private TextBox RentalDetailsTotalTextBox;
        private Button RentalDetailsConfirmButton;
        private Button RentalDetailsCloseBotton;
        private Button RentalDetailsCancelButton;
        private Label RentalDetailsMessageLabel;
    }
}