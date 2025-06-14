using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SmartPOS.Options
{
    public partial class MainOptions : Form
    {
        public MainOptions()
        {
            InitializeComponent();
        }

        clsOptions _option;

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




        public static void TestConnection()  //هذا الكود لفحص نجاح الاتصال مع قاعدة البيانات
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=.;Database=SmartPOS_System;User Id=sa;Password=sa123456;"))
                {
                    connection.Open();
                    MessageBox.Show("✅ الاتصال ناجح!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ فشل الاتصال: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string restaurantName, Printer, Address, ReceiptLine1, Phone, logo;

            restaurantName = txtRestaurantName.Text.Trim();
            Printer = txtPrinter.Text.Trim();
            Address = txtAddress.Text.Trim();
            ReceiptLine1 = txtReceiptLine1.Text.Trim();
            Phone = txtPhone.Text.Trim();
            logo = pictureBox1.ImageLocation;




            try
            {
                if (_option == null)
                {
                    _option = new clsOptions();
                }

                _option.restaurantName = restaurantName;
                _option.Printer = Printer;
                _option.Address = Address;
                _option.ReceiptLine1 = ReceiptLine1;
                _option.Phone = Phone;
                _option.logo = logo;

                _option.AddNewOption();
                MessageBox.Show("تم حفظ الإعدادات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تنفيذ العملية:\n\n" + ex.Message,
                               "خطأ",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }

        }





        //********** end of section ***********
    }
}
