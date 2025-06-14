using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace BusinessLayer
{
    public class clsOptions
    {

        public enum enMode { AddNew =0,Update =1 };
        enMode Mode = enMode.AddNew;

        public int optionID { set; get; }
        public string restaurantName { set; get; }
        public string Printer { set; get; }
        public string Address { set; get; }
        public string ReceiptLine1 { set; get; }
        public string Phone { set; get; }

        private string _LogoPath;
        public string logo
        {
            get { return _LogoPath; }
            set { _LogoPath = value; }
        }

        public clsOptions()
        {
            this.optionID = -1;
            this.restaurantName = "";
            this.Printer = "";
            this.Address = "";
            this.ReceiptLine1 = "";
            this.Phone = "";
            this.logo = "";

            Mode = enMode.AddNew;
        }

        private clsOptions(int optionID, string restaurantName, string Printer, string Address, string ReceiptLine1
                                , string Phone, string logo)
        {
            this.optionID = optionID;
            this.restaurantName = restaurantName;
            this.Printer = Printer;
            this.Address = Address;
            this.ReceiptLine1 = ReceiptLine1;
            this.Phone = Phone;
            this.logo = logo;

            Mode = enMode.Update;
        }
        //------------- methods------------------
        // first method its how to add new option 

        public void AddNewOption()
        {
            //call data layer

            this.optionID = clsOptionsData.AddNewOption(this.restaurantName, this.Printer, this.Address, this.ReceiptLine1
                                , this.Phone, this.logo);
           
        }


        //*********** end of section *************
    }
}
