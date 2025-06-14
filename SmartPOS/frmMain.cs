using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SmartPOS.MainPOS;
using SmartPOS.Setup;
using SmartPOS.Options;
using SmartPOS.MainReport;

namespace SmartPOS
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private Button CurrentButton;
        private Form ActiveForm;
     
        private void OpenChildForm(Form cform, object btnSender)
        {
            //cform هو النموذج الفرعي الذي تريد فتحه.
            //btnSender هو الزر الذي ضغط عليه المستخدم، لترتبط به حالة تمييز.


            if (ActiveForm != null)
            {
                ActiveForm.Close();      //اذا كان هاك form مفتوح سابقا سيتم اغلاقه قبل فتح واحد جديد
            }

            ActiveForm = cform;
            ActiveButton(btnSender);

            cform.TopLevel = false;  // يجعل النموذج الفرعي غير مستقل (ليُعرض داخل نموذج آخر)
            cform.FormBorderStyle = FormBorderStyle.None;
            cform.Dock = DockStyle.Fill;
            pnlMainForm.Controls.Add(cform); // يضيف النموذج الفرعي إلى مكونات الـ Panel المسماة pnlMainForm
            pnlMainForm.Tag = cform;
            cform.BringToFront(); //يجلب النموذج إلى الواجهة
            cform.Show();  // يعرض النموذج على الشاشة.
        }


        //********************************************
        private Color SelectTheme()
        {
            if(CurrentButton.Text == "POS")
            {
                return Color.YellowGreen;
            }
            else if(CurrentButton.Text == "Setup")
            {
                return Color.Red;
            }
            else if (CurrentButton.Text == "Reports")
            {
                return Color.Blue;
            }
            else if (CurrentButton.Text == "Options")
            {
                return Color.Green;
            }
            else
            {
                return Color.Gray;
            }

        }

        private void ActiveButton(object sender)
        {
            if(sender != null)
            {
                if(CurrentButton != (Button) sender)
                {
                    unSelectButton();
                    CurrentButton = (Button)sender;
                    Color color = SelectTheme();
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    pnlTitle.BackColor = color;
                    lblTitle.Text = CurrentButton.Text;
                }
            }
        }

        private void unSelectButton()
        {
            foreach(Control ctr in pnlMenu.Controls)
            {
                if(ctr.GetType() == typeof(Button))
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                }
            }
        }


        private void btnPOS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainPointofSale(), sender);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainSetup(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReporting(), sender);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainOptions(), sender);
        }

        //***************************************
        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ghanayemm");
        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //************ end of text ***************
    }
}
