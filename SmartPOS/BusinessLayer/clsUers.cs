using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsUers
    {

        enum enMode { Addnew = 0, Update = 1 };
        enMode Mode = enMode.Addnew;


        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Job_Description { get; set; }

        public clsUers()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.FullName = "";
            this.Job_Description = "";

            Mode = enMode.Addnew;
        }


        private clsUers(int UserID, string UserName, string Password, string FullName, string Job_Description)
        {
            this.UserID = UserID;
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
            this.UserID = clsUsersData.AddNewUser(this.UserName, this.Password, this.FullName, this.Job_Description);
        }




        //******************* end  *****************
    }
}
