using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS.Setup
{
    public partial class MainSetup : Form
    {
        public MainSetup()
        {
            InitializeComponent();
        }

        private void MainSetup_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //Form frm = new frmUsers();
            //frm.ShowDialog();
            //this.Close();

            this.Hide(); // إخفاء النموذج الحالي (بدلاً من إغلاقه مباشرة)
           

            using (frmUsers frm = new frmUsers())
            {
                frm.ShowDialog(); // عرض النموذج الجديد
            }

            this.Show(); // إعادة عرض النموذج الحالي بعد إغلاق النموذج الجديد

        }
    }
}
