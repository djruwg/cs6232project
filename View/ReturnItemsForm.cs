﻿using RentMe.Controller;
using RentMe.Model;
using System.ComponentModel;

namespace RentMe.View
{
    /// <summary>
    /// Form for returning furniture.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReturnItemsForm : Form
    {
        private ReturnTransaction returnTransaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItemsForm"/> class.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        public ReturnItemsForm(int memberID)
        {
            InitializeComponent();

            this.ConfigureDataGridView();
            returnTransaction = new ReturnsController().GetReturnableForMember(memberID);
            ReturnItemsFormDataGridView.DataSource = returnTransaction.LineItems;
            RefreshDataGridView();
        }

        private void ConfigureDataGridView()
        {
            ReturnItemsFormDataGridView.AutoGenerateColumns = false;

            this.AddColumn("Rental ID", "RentalID", true);
            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("Days Overdue", "DueDelta", true);
            this.AddColumn("Daily Rate", "DailyRentalRate", true);
            this.AddColumn("Qty Rented", "QuantityOutStanding", true);
            this.AddColumn("Qty Returned", "Quantity", false);
            this.AddColumn("Net Cost", "AmountOwed", true);

            ReturnItemsFormDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
            ReturnItemsFormDataGridView.Columns["AmountOwed"].DefaultCellStyle.Format = "c";

        }

        private void AddColumn(string headerText, string properyName, bool readOnly)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = properyName;
            column.Name = properyName;
            column.HeaderText = headerText;
            column.ReadOnly = readOnly;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReturnItemsFormDataGridView.Columns.Add(column);
        }

        private void RefreshDataGridView()
        {
            ReturnItemsFormDataGridView.DataSource = null;
            ReturnItemsFormDataGridView.DataSource = returnTransaction.LineItems;
            double sum = 0;
            foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
            {
                sum += lineItem.AmountOwed;
            }

            ReturnItemsFormNetCostTextBox.Text = sum.ToString("C");
        }

        private void ReturnItemsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 7) return;

            if (ReturnItemsFormDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int quantity = (int)ReturnItemsFormDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                RefreshDataGridView();
            }
        }

        private void ReturnItemsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 7) return;

            ReturnItemsFormMessageLabel.Visible = false;

            int.TryParse(e.FormattedValue?.ToString(), out int newValue);
            int.TryParse(ReturnItemsFormDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString(), out int maxValue);

            if (newValue > maxValue)
            {
                ReturnItemsFormMessageLabel.Text = "Can't return more than is outstanding";
                ReturnItemsFormMessageLabel.Visible = true;
                e.Cancel = true;

            }

            if (!int.TryParse(e.FormattedValue?.ToString(), out int newInteger) || newInteger < 0)
            {
                ReturnItemsFormMessageLabel.Text = "Cell must be a positive integer";
                ReturnItemsFormMessageLabel.Visible = true;
                e.Cancel = true;
            }

        }

        private void PerformReturn()
        {
            ReturnTransaction returnCart = new ReturnTransaction();

            returnCart.ReturnID = returnTransaction.ReturnID;
            returnCart.MemberID = returnTransaction.MemberID;
            returnCart.EmployeeID = returnTransaction.EmployeeID;
            returnCart.DateReturned = returnTransaction.DateReturned;
            returnCart.LineItems = new BindingList<ReturnLineItem>();

            foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
            {
                if (lineItem.Quantity != 0)
                {
                    returnCart.LineItems.Add(lineItem);
                }
            }

            if (returnCart.LineItems.Count > 0)
            {
                SaveReturnForm saveReturnForm = new SaveReturnForm(returnCart);
                this.ReturnItemsFormReturnItemsButton.Enabled = false;
                this.ReturnItemsFormReturnEverythingButton.Enabled = false;
                if (DialogResult.OK == saveReturnForm.ShowDialog())
                {
                    Close();
                }
                this.ReturnItemsFormReturnItemsButton.Enabled = true;
                this.ReturnItemsFormReturnEverythingButton.Enabled = true;
            }
            else
            {
                ReturnItemsFormMessageLabel.Text = "Must be returning at least one item";
                ReturnItemsFormMessageLabel.Visible = true;
            }
        }

        private void ReturnItemsFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReturnItemsFormReturnItemsButton_Click(object sender, EventArgs e)
        {
            this.PerformReturn();
        }

        private void ReturnItemsFormReturnEverythingButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ReturnItemsFormDataGridView.Rows)
            {
                row.Cells[7].Value = row.Cells[6].Value;
            }

            this.PerformReturn();
        }
    }
}
