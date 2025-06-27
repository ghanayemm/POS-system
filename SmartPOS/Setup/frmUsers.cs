using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SmartPOS.Setup
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        clsUers _User;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string UserName, Password, FullName, Job_Description;

            UserName = txtUserName.Text.Trim();
            Password = txtPassword.Text.Trim();
            FullName = txtFullName.Text.Trim();

            if(string.IsNullOrWhiteSpace(txtJobDiscription.Text))
            {
                Job_Description = txtJobDiscription.Text.Trim();
            }
            else
            {
                Job_Description = null;
            }


            try
            {
                _User = new clsUers();

                _User.UserName = UserName;
                _User.Password = Password;
                _User.FullName = FullName;
                _User.Job_Description = Job_Description;

                _User.AddNewUser();
                MessageBox.Show("The user has been saved successfully", "Information", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تنفيذ العملية:\n\n" + ex.Message,
                               "خطأ",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            ClearData();
        }


        private void ClearData()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtJobDiscription.Text = string.Empty;
        }

        //************** end ******************
    }
}
