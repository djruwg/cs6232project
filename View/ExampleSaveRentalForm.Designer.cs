﻿namespace RentMe.View
{
    partial class ExampleSaveRentalForm
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
            save = new Button();
            TheReturnID = new TextBox();
            TheSum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            message = new Label();
            label3 = new Label();
            TheCount = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(TheReturnID, 2, 0);
            tableLayoutPanel1.Controls.Add(TheSum, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(save, 0, 3);
            tableLayoutPanel1.Controls.Add(message, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(TheCount, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.None;
            save.Location = new Point(95, 381);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 1;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // TheReturnID
            // 
            TheReturnID.Anchor = AnchorStyles.None;
            TheReturnID.Location = new Point(616, 44);
            TheReturnID.Name = "TheReturnID";
            TheReturnID.Size = new Size(100, 23);
            TheReturnID.TabIndex = 2;
            // 
            // TheSum
            // 
            TheSum.Anchor = AnchorStyles.None;
            TheSum.Location = new Point(616, 156);
            TheSum.Name = "TheSum";
            TheSum.Size = new Size(100, 23);
            TheSum.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(371, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Return ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(383, 160);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "SUM";
            // 
            // message
            // 
            message.Anchor = AnchorStyles.None;
            message.AutoSize = true;
            message.ForeColor = Color.Red;
            message.Location = new Point(372, 385);
            message.Name = "message";
            message.Size = new Size(53, 15);
            message.TabIndex = 5;
            message.Text = "Message";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(339, 272);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 6;
            label3.Text = "How many line items";
            // 
            // TheCount
            // 
            TheCount.Anchor = AnchorStyles.None;
            TheCount.Location = new Point(616, 268);
            TheCount.Name = "TheCount";
            TheCount.Size = new Size(100, 23);
            TheCount.TabIndex = 7;
            // 
            // ExampleSaveRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ExampleSaveRentalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExampleSaveRentalForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button save;
        private TextBox TheReturnID;
        private TextBox TheSum;
        private Label label1;
        private Label label2;
        private Label message;
        private Label label3;
        private TextBox TheCount;
    }
}