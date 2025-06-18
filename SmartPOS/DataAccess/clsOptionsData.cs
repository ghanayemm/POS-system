using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace DataAccess
{
    public class clsOptionsData
    {
       
        public static int AddNewOption(string restaurantName, string Printer, string Address, string ReceiptLine1, string Phone, byte[] logo)
        {
            int optionID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataSccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Options(restaurantName,Printer,Address,ReceiptLine1,Phone,Logo)   
                             VALUES (@restaurantName,@Printer,@Address,@ReceiptLine1,@Phone,@Logo);
                             SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@restaurantName", restaurantName);
                        command.Parameters.AddWithValue("@Printer", string.IsNullOrEmpty(Printer) ? (object)DBNull.Value : Printer);
                        command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(Address) ? (object)DBNull.Value : Address);
                        command.Parameters.AddWithValue("@ReceiptLine1", string.IsNullOrEmpty(ReceiptLine1) ? (object)DBNull.Value : ReceiptLine1);
                        command.Parameters.AddWithValue("@Phone",Phone);
                        command.Parameters.Add("@Logo", SqlDbType.Image).Value = (logo == null) ? DBNull.Value : (object)logo;


                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            optionID = insertedID;
                            MessageBox.Show("تمت إضافة البيانات بنجاح، ID: " + optionID);
                        }
                        else
                        {
                            MessageBox.Show("لم يتم إدخال البيانات.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الإدخال: " + ex.Message);
            }

            return optionID;
        }



        //*********** end of methods **************
    }

}
