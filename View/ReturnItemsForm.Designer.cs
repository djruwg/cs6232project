namespace RentMe.View
{
    partial class ReturnItemsForm
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
            ReturnItemsFormDataGridView = new DataGridView();
            ReturnItemsTableLayoutPanel = new TableLayoutPanel();
            ReturnItemsFormReturnItemsButton = new Button();
            ReturnItemsFormMessageLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ReturnItemsFormNetCostTextBox = new TextBox();
            label2 = new Label();
            testingButton = new Button();
            ReturnItemsFormCloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ReturnItemsFormDataGridView).BeginInit();
            ReturnItemsTableLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ReturnItemsFormDataGridView
            // 
            ReturnItemsFormDataGridView.AllowUserToAddRows = false;
            ReturnItemsFormDataGridView.AllowUserToDeleteRows = false;
            ReturnItemsFormDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            ReturnItemsFormDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnItemsTableLayoutPanel.SetColumnSpan(ReturnItemsFormDataGridView, 2);
            ReturnItemsFormDataGridView.Dock = DockStyle.Fill;
            ReturnItemsFormDataGridView.Location = new Point(3, 39);
            ReturnItemsFormDataGridView.Name = "ReturnItemsFormDataGridView";
            ReturnItemsFormDataGridView.RowHeadersVisible = false;
            ReturnItemsFormDataGridView.Size = new Size(794, 336);
            ReturnItemsFormDataGridView.TabIndex = 0;
            ReturnItemsFormDataGridView.CellValidating += ReturnItemsDataGridView_CellValidating;
            ReturnItemsFormDataGridView.CellValueChanged += ReturnItemsDataGridView_CellValueChanged;
            // 
            // ReturnItemsTableLayoutPanel
            // 
            ReturnItemsTableLayoutPanel.AutoSize = true;
            ReturnItemsTableLayoutPanel.ColumnCount = 2;
            ReturnItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsFormDataGridView, 0, 1);
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsFormReturnItemsButton, 0, 3);
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsFormMessageLabel, 0, 2);
            ReturnItemsTableLayoutPanel.Controls.Add(flowLayoutPanel1, 1, 2);
            ReturnItemsTableLayoutPanel.Controls.Add(testingButton, 1, 0);
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsFormCloseButton, 1, 3);
            ReturnItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ReturnItemsTableLayoutPanel.Location = new Point(0, 0);
            ReturnItemsTableLayoutPanel.Name = "ReturnItemsTableLayoutPanel";
            ReturnItemsTableLayoutPanel.RowCount = 4;
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            ReturnItemsTableLayoutPanel.Size = new Size(800, 450);
            ReturnItemsTableLayoutPanel.TabIndex = 1;
            // 
            // ReturnItemsFormReturnItemsButton
            // 
            ReturnItemsFormReturnItemsButton.Anchor = AnchorStyles.Left;
            ReturnItemsFormReturnItemsButton.Location = new Point(3, 420);
            ReturnItemsFormReturnItemsButton.Name = "ReturnItemsFormReturnItemsButton";
            ReturnItemsFormReturnItemsButton.Size = new Size(121, 23);
            ReturnItemsFormReturnItemsButton.TabIndex = 1;
            ReturnItemsFormReturnItemsButton.Text = "Return Items";
            ReturnItemsFormReturnItemsButton.UseVisualStyleBackColor = true;
            ReturnItemsFormReturnItemsButton.Click += ReturnItemsFormButton_Click;
            // 
            // ReturnItemsFormMessageLabel
            // 
            ReturnItemsFormMessageLabel.Anchor = AnchorStyles.Left;
            ReturnItemsFormMessageLabel.AutoSize = true;
            ReturnItemsFormMessageLabel.ForeColor = Color.Red;
            ReturnItemsFormMessageLabel.Location = new Point(3, 388);
            ReturnItemsFormMessageLabel.Name = "ReturnItemsFormMessageLabel";
            ReturnItemsFormMessageLabel.Size = new Size(76, 15);
            ReturnItemsFormMessageLabel.TabIndex = 2;
            ReturnItemsFormMessageLabel.Text = "message text";
            ReturnItemsFormMessageLabel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ReturnItemsFormNetCostTextBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(403, 381);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(394, 30);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // ReturnItemsFormNetCostTextBox
            // 
            ReturnItemsFormNetCostTextBox.Anchor = AnchorStyles.Right;
            ReturnItemsFormNetCostTextBox.Location = new Point(222, 3);
            ReturnItemsFormNetCostTextBox.Name = "ReturnItemsFormNetCostTextBox";
            ReturnItemsFormNetCostTextBox.Size = new Size(169, 23);
            ReturnItemsFormNetCostTextBox.TabIndex = 1;
            ReturnItemsFormNetCostTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(163, 7);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Net Cost";
            // 
            // testingButton
            // 
            testingButton.Anchor = AnchorStyles.None;
            testingButton.Location = new Point(562, 6);
            testingButton.Name = "testingButton";
            testingButton.Size = new Size(75, 23);
            testingButton.TabIndex = 4;
            testingButton.Text = "testing";
            testingButton.UseVisualStyleBackColor = true;
            testingButton.Click += testingButton_Click;
            // 
            // ReturnItemsFormCloseButton
            // 
            ReturnItemsFormCloseButton.Anchor = AnchorStyles.Right;
            ReturnItemsFormCloseButton.Location = new Point(676, 420);
            ReturnItemsFormCloseButton.Name = "ReturnItemsFormCloseButton";
            ReturnItemsFormCloseButton.Size = new Size(121, 23);
            ReturnItemsFormCloseButton.TabIndex = 5;
            ReturnItemsFormCloseButton.Text = "Close";
            ReturnItemsFormCloseButton.UseVisualStyleBackColor = true;
            ReturnItemsFormCloseButton.Click += ReturnItemsFormCloseButton_Click;
            // 
            // ReturnItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnItemsTableLayoutPanel);
            Name = "ReturnItemsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Return Items";
            ((System.ComponentModel.ISupportInitialize)ReturnItemsFormDataGridView).EndInit();
            ReturnItemsTableLayoutPanel.ResumeLayout(false);
            ReturnItemsTableLayoutPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReturnItemsFormDataGridView;
        private TableLayoutPanel ReturnItemsTableLayoutPanel;
        private Button ReturnItemsFormReturnItemsButton;
        private Label ReturnItemsFormMessageLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox ReturnItemsFormNetCostTextBox;
        private Label label2;
        private Button testingButton;
        private Button ReturnItemsFormCloseButton;
    }
}