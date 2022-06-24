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
using MySql.Data.MySqlClient;

namespace finallProject
{
    public partial class changePassForm : Form
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

        // variable for initiate connection with database
        private MySqlConnection conn;
        private string server, database, uid, password;

        public string studentID { get; set; }
        public changePassForm()
        {
            InitializeComponent();
            //make the form rounded
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // create variable for connection to server
            server = "localhost";
            database = "finallproject";
            uid = "userFinall";
            password = "user";

            string connString = $"SERVER = {server}; DATABASE = {database}; UID = {uid}; PASSWORD = {password}";
            conn = new MySqlConnection(connString);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(dataChecking(studentID))
            {
                updatePassord(tbNewPass.Text, tbRePass.Text);
            }
            else
            {
                MessageBox.Show("Wrong Password !!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // checking the connection if its up and running
        private bool openConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Eonnection to server failed");
                        break;

                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }

        // check if the password correct
        public bool dataChecking(string studentID)
        {
            string query = $"SELECT * FROM login WHERE studentID = {studentID}";
            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        if(reader.GetString("password") == tbCurrentPass.Text)
                        {
                            reader.Close();
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return false;
            }
        }

        // update user password
        public void updatePassord(string newPass, string reNewPass)
        {
            string query = $"UPDATE login SET password = '{newPass}' WHERE studentID = {studentID};";
            try
            {
                if (openConnection())
                {
                    if(newPass == reNewPass)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Password Changed Successfully");
                            conn.Close();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed changing password");
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password and confirmation password is not the same");
                        conn.Close();
                    }
                }
                else
                {
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
