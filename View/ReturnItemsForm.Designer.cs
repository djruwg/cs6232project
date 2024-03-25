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
            ((System.ComponentModel.ISupportInitialize)ReturnItemsDataGridView).BeginInit();
            ReturnItemsTableLayoutPanel.SuspendLayout();
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
            ReturnItemsDataGridView.Location = new Point(3, 63);
            ReturnItemsDataGridView.Name = "ReturnItemsDataGridView";
            ReturnItemsDataGridView.RowHeadersVisible = false;
            ReturnItemsDataGridView.Size = new Size(794, 326);
            ReturnItemsDataGridView.TabIndex = 0;
            // 
            // ReturnItemsTableLayoutPanel
            // 
            ReturnItemsTableLayoutPanel.AutoSize = true;
            ReturnItemsTableLayoutPanel.ColumnCount = 2;
            ReturnItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnItemsTableLayoutPanel.Controls.Add(ReturnItemsDataGridView, 0, 1);
            ReturnItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ReturnItemsTableLayoutPanel.Location = new Point(0, 0);
            ReturnItemsTableLayoutPanel.Name = "ReturnItemsTableLayoutPanel";
            ReturnItemsTableLayoutPanel.RowCount = 3;
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846149F));
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.61539F));
            ReturnItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            ReturnItemsTableLayoutPanel.Size = new Size(800, 450);
            ReturnItemsTableLayoutPanel.TabIndex = 1;
            // 
            // ReturnItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnItemsTableLayoutPanel);
            Name = "ReturnItemsForm";
            Text = "Return Items";
            ((System.ComponentModel.ISupportInitialize)ReturnItemsDataGridView).EndInit();
            ReturnItemsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReturnItemsDataGridView;
        private TableLayoutPanel ReturnItemsTableLayoutPanel;
    }
}