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
    public partial class payTuitionForm : Form
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

        // variable for initialize connection with database
        private MySqlConnection conn;
        private string server, database, uid, password;

        public int varPaymentNominal { get; set; }
        public string varPassword { get; set; }
        public string varFinanceID { get; set; }
        public string varDefaultInformation { get; set; }
        public string varStudentID { get; set; }


        public payTuitionForm()
        {
            InitializeComponent();
            //make the form rounded
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // create variable for connection to server
            server = "localhost";
            database = "finallproject";
            uid = "userFinall";
            password = "user";

            string connString;
            connString = $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}";
            conn = new MySqlConnection(connString);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            varFinanceID = tbFinanceId.Text;
            varPassword = tbPassword.Text;
            if(dataChecking(varStudentID, varFinanceID, varPassword))
            {
                dataInsert(varFinanceID);
            }
            else
            {
                MessageBox.Show("Failed recognized");
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
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

        // Insert payment tuition
        public void dataInsert(string financeID)
        {
            //fetch data from the form and pass it to database
            varPaymentNominal = Convert.ToInt32(tbPaymentNominal.Text);
            varDefaultInformation = "Transaction for payment tuition";

            string insertQuery = $"INSERT INTO transactionhistory (financeID, debit, credit, information) VALUES ('{financeID}',0,{varPaymentNominal},'{varDefaultInformation}');";
            string updateQuery = $"UPDATE accountbalance SET lastBalance=(SELECT SUM(debit + credit) FROM transactionhistory WHERE financeID = '{financeID}') WHERE financialID = '{financeID}';";

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn);
                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn);
                    if (cmdInsert.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("DATE Inserted");
                        if (cmdUpdate.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("DATE UPDATED");
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("DATA FAILED TO UPDATE");
                    }
                    conn.Close();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // Insert payment tuition
        public bool dataChecking(string studentID, string financeId, string password)
        {
            //fetch data from the form and pass it to database
            string query = $"SELECT login.studentID, login.password, accountbalance.financialID FROM login INNER JOIN accountbalance ON login.studentID = accountbalance.studentID WHERE login.studentID = '{studentID}';";

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetString("password") == password && reader.GetString("financialID") == financeId)
                        {
                            MessageBox.Show("User recognized");
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
                        MessageBox.Show("User unrecognized");
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
    }
}
