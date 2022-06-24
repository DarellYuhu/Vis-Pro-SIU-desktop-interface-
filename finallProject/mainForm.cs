using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace finallProject
{
    public partial class mainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public string studentID { get; set; }
        public Form loginForm { get; set; }

        public mainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //profileBtn
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;

            //show home form when first inisialization
            contentPanel.Controls.Clear();
            homeForm frm = new homeForm();
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(48, 183, 212);

            contentPanel.Controls.Clear();
            homeForm frm = new homeForm();
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Button effect
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(75, 75, 75);

            //display form
            contentPanel.Controls.Clear();
            profileForm frm = new profileForm();
            frm.varStudentID = studentID;
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnSchdl_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSchdl.Height;
            pnlNav.Top = btnSchdl.Top;
            pnlNav.Left = btnSchdl.Left;
            btnSchdl.BackColor = Color.FromArgb(75, 75, 75);

            //display form
            contentPanel.Controls.Clear();
            schdlForm frm = new schdlForm();
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            pnlNav.Left = btnAccount.Left;
            btnAccount.BackColor = Color.FromArgb(75, 75, 75);

            //display form
            contentPanel.Controls.Clear();
            accBalanceForm frm = new accBalanceForm();
            frm.varStudentID = studentID;
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnLastGrd_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLastGrd.Height;
            pnlNav.Top = btnLastGrd.Top;
            pnlNav.Left = btnLastGrd.Left;
            btnLastGrd.BackColor = Color.FromArgb(75, 75, 75);

            //display form
            contentPanel.Controls.Clear();
            lastGrdForm frm = new lastGrdForm();
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(36, 42, 88);
        }

        private void btnSchdl_Leave(object sender, EventArgs e)
        {
            btnSchdl.BackColor = Color.FromArgb(36, 42, 88);
        }

        private void btnAccount_Leave(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(36, 42, 88);
        }

        private void btnLastGrd_Leave(object sender, EventArgs e)
        {
            btnLastGrd.BackColor = Color.FromArgb(36, 42, 88);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(48, 183, 212);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            changePassForm frm = new changePassForm();
            frm.studentID = studentID;
            frm.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.loginForm.Show();
            this.Close();
        }
    }
}
