namespace RentMe.View
{
    partial class ShowFurnitureForm
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
            ShowFurnitureFurnitureShowUserControl = new UserControls.FurnitureShow();
            SuspendLayout();
            // 
            // ShowFurnitureFurnitureShowUserControl
            // 
            ShowFurnitureFurnitureShowUserControl.Dock = DockStyle.Fill;
            ShowFurnitureFurnitureShowUserControl.Location = new Point(0, 0);
            ShowFurnitureFurnitureShowUserControl.Name = "ShowFurnitureFurnitureShowUserControl";
            ShowFurnitureFurnitureShowUserControl.Size = new Size(800, 450);
            ShowFurnitureFurnitureShowUserControl.TabIndex = 0;
            // 
            // ShowFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowFurnitureFurnitureShowUserControl);
            Name = "ShowFurnitureForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Furniture Details";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.FurnitureShow ShowFurnitureFurnitureShowUserControl;
    }
}