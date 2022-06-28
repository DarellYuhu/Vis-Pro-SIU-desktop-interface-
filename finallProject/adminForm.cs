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
    public partial class adminForm : Form
    {
        // create rounded design
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
        public Form loginForm { get; set; }

        public adminForm()
        {
            InitializeComponent();
            //make the form rounded
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //profileBtn
            pnlNav.Height = btnStudentProfile.Height;
            pnlNav.Top = btnStudentProfile.Top;
            pnlNav.Left = btnStudentProfile.Left;
            btnStudentProfile.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.loginForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudentProfile_Click(object sender, EventArgs e)
        {
            //display form
            contentPanel.Controls.Clear();
            adminStudentForm frm = new adminStudentForm();
            //frm.varStudentID = studentID;
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();

            //Button effect
            btnUpdate.BackColor = Color.FromArgb(36, 42, 88);
            btnPayTuition.BackColor = Color.FromArgb(36, 42, 88);
            pnlNav.Height = btnStudentProfile.Height;
            pnlNav.Top = btnStudentProfile.Top;
            pnlNav.Left = btnStudentProfile.Left;
            btnStudentProfile.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //display form
            contentPanel.Controls.Clear();
            adminUpdateStudent frm = new adminUpdateStudent();
            //frm.varStudentID = studentID;
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();

            //Button effect
            btnStudentProfile.BackColor = Color.FromArgb(36, 42, 88);
            btnPayTuition.BackColor = Color.FromArgb(36, 42, 88);
            pnlNav.Height = btnUpdate.Height;
            pnlNav.Top = btnUpdate.Top;
            pnlNav.Left = btnUpdate.Left;
            btnUpdate.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            //display form
            contentPanel.Controls.Clear();
            adminStudentForm frm = new adminStudentForm();
            //frm.varStudentID = studentID;
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnPayTuition_Click(object sender, EventArgs e)
        {
            //display form
            contentPanel.Controls.Clear();
            payTuitionForm frm = new payTuitionForm();
            frm.TopLevel = false;
            contentPanel.Controls.Add(frm);
            frm.Show();

            //Button effect
            btnStudentProfile.BackColor = Color.FromArgb(36, 42, 88);
            btnUpdate.BackColor = Color.FromArgb(36, 42, 88);
            pnlNav.Height = btnPayTuition.Height;
            pnlNav.Top = btnPayTuition.Top;
            pnlNav.Left = btnPayTuition.Left;
            btnPayTuition.BackColor = Color.FromArgb(75, 75, 75);
        }
    }
}
