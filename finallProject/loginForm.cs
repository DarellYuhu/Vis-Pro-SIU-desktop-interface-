using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace finallProject
{
    public partial class loginForm : Form
    {
        private MySqlConnection conn;
        private string server, database, uid, password;
        public string studentID { get; set; }
        public string userType { get; set; }

        public loginForm()
        {
            InitializeComponent();
            server = "localhost";
            database = "finallproject";
            uid = "userFinall";
            password = "user";

            string connString;
            connString = $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}";
            conn = new MySqlConnection(connString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = tbUsername.Text;
            string password = tbPassword.Text;

            if (isLogin(user, password))
            {
                if (userType == "user")
                {
                    mainForm frm = new mainForm();
                    frm.studentID = studentID; // send studentID to other form
                    frm.loginForm = this;
                    frm.Show();
                    this.Hide();
                }

                else if (userType == "admin")
                {
                    adminForm frm = new adminForm();
                    frm.loginForm = this;
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show($"{user} does not exist or password is incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool isLogin(string user, string password)
        {
            string query = $"SELECT * FROM login WHERE userName = '{user}' AND password = '{password}';";
            try
            {
                if(openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        //fetch studentID & userType from the database
                        if(reader.GetString("userType") == "user")
                        {
                            studentID = reader.GetString("studentID");
                        }
                        userType = reader.GetString(3);
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
                    conn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return false;
            }
        }

        private bool openConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("connection to server faild!");
                        break;

                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }
    }
}
