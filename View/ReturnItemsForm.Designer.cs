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
            ReturnItemsDataGridView = new DataGridView();
            ReturnItemsTableLayoutPanel = new TableLayoutPanel();
            button1 = new Button();
            ReturnItemsFormLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReturnItemsDataGridView).BeginInit();
            ReturnItemsTableLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ReturnItemsDataGridView
            // 
            ReturnItemsDataGridView.AllowUserToAddRows = false;
            ReturnItemsDataGridView.AllowUserToDeleteRows = false;
            ReturnItemsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            ReturnItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnItemsTableLayoutPanel.SetColumnSpan(ReturnItemsDataGridView, 2);
            ReturnItemsDataGridView.Dock = DockStyle.Fill;
            ReturnItemsDataGridView.Location = new Point(3, 39);
            ReturnItemsDataGridView.Name = "ReturnItemsDataGridView";
            ReturnItemsDataGridView.RowHeadersVisible = false;
            ReturnItemsDataGridView.Size = new Size(794, 336);
            ReturnItemsDataGridView.TabIndex = 0;
            ReturnItemsDataGridView.CellDoubleClick += ReturnItemsDataGridView_CellDoubleClick;
            ReturnItemsDataGridView.CellValidating += ReturnItemsDataGridView_CellValidating;
            ReturnItemsDataGridView.CellValueChanged += ReturnItemsDataGridView_CellValueChanged;
            // 
            // ReturnItemsTableLayoutPanel
            // 
            ReturnItemsTableLayoutPanel.AutoSize = true;
            ReturnItemsTableLayoutPanel.ColumnCount = 2;
            ReturnItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsDataGridView, 0, 1);
            ReturnItemsTableLayoutPanel.Controls.Add(button1, 0, 3);
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsFormLabel, 0, 2);
            ReturnItemsTableLayoutPanel.Controls.Add(flowLayoutPanel1, 1, 2);
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(3, 420);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 1;
            button1.Text = "Return Items";
            button1.UseVisualStyleBackColor = true;
            // 
            // ReturnItemsFormLabel
            // 
            ReturnItemsFormLabel.Anchor = AnchorStyles.Left;
            ReturnItemsFormLabel.AutoSize = true;
            ReturnItemsFormLabel.ForeColor = Color.Red;
            ReturnItemsFormLabel.Location = new Point(3, 388);
            ReturnItemsFormLabel.Name = "ReturnItemsFormLabel";
            ReturnItemsFormLabel.Size = new Size(76, 15);
            ReturnItemsFormLabel.TabIndex = 2;
            ReturnItemsFormLabel.Text = "message text";
            ReturnItemsFormLabel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(403, 381);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(394, 30);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(222, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 1;
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
            // ReturnItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnItemsTableLayoutPanel);
            Name = "ReturnItemsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Return Items";
            ((System.ComponentModel.ISupportInitialize)ReturnItemsDataGridView).EndInit();
            ReturnItemsTableLayoutPanel.ResumeLayout(false);
            ReturnItemsTableLayoutPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReturnItemsDataGridView;
        private TableLayoutPanel ReturnItemsTableLayoutPanel;
        private Button button1;
        private Label ReturnItemsFormLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Label label2;
    }
}