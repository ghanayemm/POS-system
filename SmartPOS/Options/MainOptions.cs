using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        //نعرف جزء من object

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


        private  void ClearData()
        {
            txtRestaurantName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtReceiptLine1.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPrinter.Text = string.Empty;
            txtPhoto.Text = string.Empty;
            pictureBox1.BackgroundImage = null;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            string restaurantName, Printer, Address, ReceiptLine1, Phone;
            byte[] logoBytes = null;

            if(string.IsNullOrWhiteSpace(txtRestaurantName.Text))
            {
                MessageBox.Show("Please Enter Restuarant Name");
                txtRestaurantName.Focus();
                return;
            }

            restaurantName = txtRestaurantName.Text.Trim();

            Printer = txtPrinter.Text.Trim();
            Address = txtAddress.Text.Trim();
            ReceiptLine1 = txtReceiptLine1.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please Enter Phone Number");
                txtPhone.Focus();
                return;
            }

            Phone = txtPhone.Text.Trim();

            if (pictureBox1.BackgroundImage != null)
            {
                using (MemoryStream ms = new MemoryStream()) 
                {
                    pictureBox1.BackgroundImage.Save(ms, pictureBox1.BackgroundImage.RawFormat);
                    logoBytes = ms.ToArray();
                }
            }





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
                _option.logo = logoBytes;

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
            ClearData();
        }

        private void MainOptions_Load(object sender, EventArgs e)
        {
            txtRestaurantName.Focus();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPhoto.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtPhoto.Text);
            }

        }


        //public  DataTable getData()
        //{
        //    DataTable dt = new DataTable();
        //    return dt;
        //    //this function will be add later when i need to get data from server to  main options form to print by printer; 
        //}


        //********** end of section ***********
    }
}
