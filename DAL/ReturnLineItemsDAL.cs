using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    internal class ReturnLineItemsDAL
    {
        public Boolean SaveReturnlLineItem(SqlCommand command, ReturnLineItem returnLineItem)
        {
            ArgumentNullException.ThrowIfNull(returnLineItem);

            string statement = @"
                insert into ReturnLineItems (
                    ReturnID,
                    RentalID,
                    FurnitureID,
                    Quantity,
                    Fine,
                    Refund )
                values (
                    @ReturnID,
                    @RentalID,
                    @FurnitureID,
                    @Quantity,
                    @Fine,
                    @Refund )";

            command.CommandText = statement;
            if (!command.Parameters.Contains("@ReturnID"))
            {
                command.Parameters.Add("@ReturnID", SqlDbType.Int);
            }
            command.Parameters["@ReturnID"].Value = returnLineItem.ReturnID;

            if (!command.Parameters.Contains("@RentalID"))
            {
                command.Parameters.Add("@RentalID", SqlDbType.Int);
            }
            command.Parameters["@RentalID"].Value = returnLineItem.RentalID;

            if (!command.Parameters.Contains("@FurnitureID"))
            {
                command.Parameters.Add("@FurnitureID", SqlDbType.Int);
            }
            command.Parameters["@FurnitureID"].Value = returnLineItem.FurnitureID;

            if (!command.Parameters.Contains("@Quantity"))
            {
                command.Parameters.Add("@Quantity", SqlDbType.Int);
            }
            command.Parameters["@Quantity"].Value = returnLineItem.Quantity;

            if (!command.Parameters.Contains("@Fine"))
            {
                command.Parameters.Add("@Fine", SqlDbType.Money);
            }
            command.Parameters["@Fine"].Value = returnLineItem.Fine;

            if (!command.Parameters.Contains("@Refund"))
            {
                command.Parameters.Add("@Refund", SqlDbType.Money);
            }
            command.Parameters["@Refund"].Value = returnLineItem.Refund;

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                return true; // The operation was successful
            }
            else
            {
                return false; // The operation failed
            }
        }

    }
}
