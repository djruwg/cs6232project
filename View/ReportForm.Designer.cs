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
            reportUserControl1 = new UserControls.ReportUserControl();
            SuspendLayout();
            // 
            // reportUserControl1
            // 
            reportUserControl1.Dock = DockStyle.Fill;
            reportUserControl1.Location = new Point(0, 0);
            reportUserControl1.Name = "reportUserControl1";
            reportUserControl1.Size = new Size(800, 450);
            reportUserControl1.TabIndex = 0;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportUserControl1);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporting";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.ReportUserControl reportUserControl1;
    }
}