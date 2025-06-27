using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace DataAccess
{
    public class clsUsersData
    {
        public static int AddNewUser(string UserName, string Password ,  string FullName ,  string Job_Description)
        {
            int userID = -1;

           try
            {
                using (SqlConnection connection = new SqlConnection(clsDataSccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Job_Description", string.IsNullOrEmpty(Job_Description) ? (object)DBNull.Value : Job_Description);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(),out int insertedID))
                        {
                            userID = insertedID;
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Error adding new user", ex);
            }
            return userID;
        }
       



      //************ end *************
     }

    
}
