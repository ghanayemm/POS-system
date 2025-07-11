using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataAccess
{
    public class clsUsersData
    {
        //------------ Add new user-----------------
        public static int AddNewUser(string UserName, string Password ,  string FullName ,  string Job_Description)
        {
            int userID = -1;

           try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        Password = Computehash(Password);

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = UserName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 256).Value = Password;
                        command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = FullName;
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
       
        //------------ Get Data Form DataBase-----------------

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }                    
                 
                    }

                }

            }
            catch(Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred while fetching users.", ex);
            }
            return dt;
        }

        public static string GetPassword(int ID)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT Password FROM Users WHERE ID = @ID", connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        connection.Open();
                        var result = command.ExecuteScalar();
                        return (result != null && result != DBNull.Value) ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception here as needed
                throw; // Rethrow or handle as per your logging policy
            }
        }

        public static bool GetUserInfoByID(int ID, ref string UserName, ref string Password, ref string FullName, ref string Job_Description)
        {
            bool isfound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT UserName, Password, FullName, Job_Description FROM Users WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                UserName = reader["UserName"] as string ?? "";
                                Password = reader["Password"] as string ?? "";
                                FullName = reader["FullName"] as string ?? "";
                                Job_Description = reader["Job_Description"] == DBNull.Value ? "" : reader["Job_Description"] as string;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new ApplicationException("An unexpected error occurred while fetching user info.", ex);
            }
            return isfound;
        }


        //------------ Update User-----------------

        public static string UpdateUser(int ID, string UserName, string Password, string FullName, string Job_Description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("st_UpdateUserIfExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    Password = Computehash(Password);

                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@Job_Description", string.IsNullOrEmpty(Job_Description) ? (object)DBNull.Value : Job_Description);

                    SqlParameter outputParam = new SqlParameter("@ResultMessage", SqlDbType.NVarChar, 100)
                    {
                        Direction = ParameterDirection.Output //هذا الباراميتر ليس لإرسال قيمة إلى SQL، بل لاستقبال قيمة من SQL بعد تنفيذ
                    };
                    command.Parameters.Add(outputParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return outputParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new ApplicationException("An unexpected error occurred while updating user.", ex);
            }
        }

        //------------ Delete User-----------------

        public static bool DeleteUser(int ID)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("St_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int)).Value = ID;
                        SqlParameter outputParam = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        connection.Open();
                        command.ExecuteNonQuery();
                        result = Convert.ToInt32(outputParam.Value) == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new ApplicationException("An unexpected error occurred while Deleting user.", ex);
            }
            return result;
        }


        //------------- hashing Password -----------------

        public static bool ChangePassword(int ID , string NewPassword)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Users  
                                 SET Password =@Password  WHERE ID=@ID;";

                    using(SqlCommand command= new SqlCommand(query,connection))
                    {
                        string hashedPassword = Computehash(NewPassword);

                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@ID", ID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return rowsAffected > 0;
        }

        public static string Computehash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                Byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


        //************************* end *************************
    }

}

