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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartPOS.Setup
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        clsUers _User;

        private int _CurrentUserID;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string UserName, Password, FullName, Job_Description;

            
            if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please Enter User Name");
                txtUserName.Focus();
                return;
            }
            UserName = txtUserName.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter the Password");
                txtPassword.Focus();
                return;
            }
            Password = txtPassword.Text.Trim();


            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please Enter the Full Name");
                txtFullName.Focus();
                return;
            }
            FullName = txtFullName.Text.Trim();

            if(!string.IsNullOrWhiteSpace(txtJobDiscription.Text))
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
            _RefreshData();
        }


        private void ClearData()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtJobDiscription.Text = string.Empty;
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                _CurrentUserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            }
        }

        //----------------show users in table-----------------

        private static DataTable _AllUsers = clsUers.GetAllUsers();

        private DataTable _Users = _AllUsers.DefaultView.ToTable(false, "ID", "UserName", "FullName", "Job_Description");

        private void _RefreshData()
        {
            _AllUsers = clsUers.GetAllUsers();
            _Users = _AllUsers.DefaultView.ToTable(false, "ID", "UserName", "FullName", "Job_Description");

            dgvUsers.DataSource = _Users;

            int numberOfUsers = Convert.ToInt32(dgvUsers.Rows.Count);

            lblnumberofUsers.Text = numberOfUsers.ToString();
        }

        private void LoadData()
        {
            dgvUsers.DataSource = _Users;

            dgvUsers.Columns[0].HeaderText = "UserID";
            dgvUsers.Columns[0].Width = 50;


            dgvUsers.Columns[1].HeaderText = "User Name";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 150;

            dgvUsers.Columns[3].HeaderText = "Job_Description";
            dgvUsers.Columns[3].Width = 200;


            
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadData();
            txtUserName.Focus();
            btnUpdate.Enabled = false;

            UpdateUserCountLabel();
        }

      

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnUpdate.Enabled = true;
            txtUserName.Enabled = false;

            if (int.TryParse(dgvUsers.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                _User = clsUers.GetUserInfoByID(ID);

                if(_User != null)
                {
                    txtUserName.Text = _User.UserName.ToString();
                    txtPassword.Text = _User.Password.ToString();
                    txtFullName.Text = _User.FullName.ToString();
                    txtJobDiscription.Text = _User.Job_Description.ToString();
                }
                else
                {
                    MessageBox.Show("تعذر تحميل بيانات المستخدم.");
                }

            }
            else
            {
                MessageBox.Show("رقم المستخدم غير صالح.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Update _User object's data from the form fields

            int ID = _CurrentUserID;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string FullName =txtFullName.Text;
            string Job_Description = txtJobDiscription.Text;

            // Update user in database and get the updated user object (if your method is designed that way)

            string result=  clsUers.UpdateUserInfo(ID, UserName, Password, FullName, Job_Description);
            ClearData();
            MessageBox.Show(result);
            _RefreshData();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_User = new clsUers();
            int ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            bool isDeleted= clsUers.DeleteUser(ID);

            if(isDeleted)
            {
                MessageBox.Show("ser removal completed");
            }
            else
            {
                MessageBox.Show("User deletion failed is linked to other data.");
            }
            _RefreshData();
        }

        private void UpdateUserCountLabel()
        {

            int numberOfUsers = Convert.ToInt32(dgvUsers.Rows.Count);

            lblnumberofUsers.Text = numberOfUsers.ToString();
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                row.Selected = false;
            }

            if(dgvUsers.Rows.Count >0)
            {
                dgvUsers.CurrentCell = dgvUsers.CurrentRow.Cells[0];
                dgvUsers.Rows[0].Selected = true;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                row.Selected = false;
            }


            if (dgvUsers.Rows.Count > 0)
            {
                int lastRowIndex = dgvUsers.Rows.Count - 1;

                dgvUsers.CurrentCell = dgvUsers.Rows[lastRowIndex].Cells[0];
                dgvUsers.Rows[lastRowIndex].Selected = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    row.Selected = false;
                }

                if (dgvUsers.Rows.Count > 0 && dgvUsers.CurrentRow != null)
                {
                    int currentRowIndex = dgvUsers.CurrentRow.Index;
                    int NewxtRowIndex = currentRowIndex + 1;
                    dgvUsers.CurrentCell = dgvUsers.Rows[NewxtRowIndex].Cells[0];
                    dgvUsers.Rows[NewxtRowIndex].Selected = true;
                }
             
            }
            catch(Exception ex)
            {
                MessageBox.Show("this is the last Row");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    row.Selected = false;
                }

                if (dgvUsers.Rows.Count > 0 && dgvUsers.CurrentRow != null)
                {
                    int currentRowIndex = dgvUsers.CurrentRow.Index;
                    int previousRowIndex = currentRowIndex -1;

                    if(previousRowIndex >=0)
                    {
                        dgvUsers.CurrentCell = dgvUsers.Rows[previousRowIndex].Cells[0];
                        dgvUsers.Rows[previousRowIndex].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("this is the First Row");
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("this is the First Row");
            }
        }












        //************** end ******************
    }
}
