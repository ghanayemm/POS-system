using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsUers
    {

        enum enMode { Addnew = 0, Update = 1 };
        enMode Mode = enMode.Addnew;


        public int ID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Job_Description { get; set; }

        public clsUers()
        {
            this.ID = -1;
            this.UserName = "";
            this.Password = "";
            this.FullName = "";
            this.Job_Description = "";

            Mode = enMode.Addnew;
        }


        private clsUers(int ID, string UserName, string Password, string FullName, string Job_Description)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.FullName = FullName;
            this.Job_Description = Job_Description;

            Mode = enMode.Update;
        }

        //************** add new method *************

        public void AddNewUser()
        {
            //call data layer
            this.ID = clsUsersData.AddNewUser(this.UserName, this.Password, this.FullName, this.Job_Description);
        }

        //************** get data from database *************

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static string GetPassword(int ID)
        {
            return clsUsersData.GetPassword(ID);
        }

        public static clsUers GetUserInfoByID(int ID)
        {
            string UserName = "", Password = "", FullName = "", Job_Description = "";

            bool isfound = clsUsersData.GetUserInfoByID(ID, ref UserName, ref Password, ref FullName, ref Job_Description);

            if (isfound)
            {
                return new clsUers(ID, UserName, Password, FullName, Job_Description);
            }
            else
            {
                return null;
            }
        }

        public static bool ChangePassword(int ID, string Password)
        {
            return clsUsersData.ChangePassword(ID, Password);
        }
     

        //************** Update method *************

        public static string UpdateUserInfo(int ID, string UserName, string Password, string FullName, string Job_Description)
        {
            return clsUsersData.UpdateUser(ID, UserName, Password, FullName, Job_Description);
        }


        //************** Delete method *************

        public static bool DeleteUser(int ID)
        {
            return clsUsersData.DeleteUser(ID);
        }



        //******************* end  *****************
    }


}
