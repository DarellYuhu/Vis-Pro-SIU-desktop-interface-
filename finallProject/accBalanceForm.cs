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
    public partial class accBalanceForm : Form
    {
        // variable for initialize connection with database
        private MySqlConnection conn;
        private string server, database, uid, password;

        public string varStudentID { get; set; }
        public string varFinancialID { get; set; }

        public accBalanceForm()
        {
            InitializeComponent();

            // create variable for connection to server
            server = "localhost";
            database = "finallproject";
            uid = "userFinall";
            password = "user";

            string connString;
            connString = $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}";
            conn = new MySqlConnection(connString);
        }

        private void accBalanceForm_Load(object sender, EventArgs e)
        {
            financeFetch(varStudentID);
            dgvTransacHist.DataSource = getTransactionHist(varFinancialID);
            dataFetch(varStudentID);
        }

        private void btnGetCr_Click(object sender, EventArgs e)
        {
            laporanKeuangan frm = new laporanKeuangan();
            frm.varFinancialID = varFinancialID;
            frm.Show();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            payTuitionForm frm  = new payTuitionForm();
            frm.varStudentID = varStudentID;
            frm.Show();
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

        // fetch all the data needed
        public void dataFetch(string studentID)
        {
            string query = $"SELECT mahasiswa.familyName, mahasiswa.name, accountbalance.lastBalance, accountbalance.financialID " +
                $"FROM accountbalance INNER JOIN mahasiswa ON accountbalance.financialID = mahasiswa.financialID WHERE " +
                $"mahasiswa.studentID = '{studentID}';";
            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        //fetch * from the database
                        fullName.Text = (reader.GetString("familyName") + ", " + reader.GetString("name"));
                        financeID.Text = (reader.GetString("financialID") + " / " + reader.GetString("financialID"));
                        lastBalance.Text = reader.GetString("lastBalance");

                        reader.Close();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("failed fetch data");
                        reader.Close();
                        conn.Close();
                    }
                }
                else
                {
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conncection to server failed. err code: " + ex);
                conn.Close();
            }
        }

        // fetch all the data needed in datagridview table
        public DataTable getTransactionHist(string financeID)
        {
            DataTable dtTransacHIst = new DataTable();
            string query = $"SELECT date AS \"Date\", information AS \"Information\", debit AS \"Debit\", credit AS \"Credit\" FROM transactionhistory WHERE financeID = '{financeID}';";
            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtTransacHIst.Load(reader);
                    reader.Close();
                    conn.Close();
                    return dtTransacHIst;
                }
                else
                {
                    conn.Close();
                    return dtTransacHIst;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error code " + ex);
                conn.Close();
                return dtTransacHIst;
            }
        }

        // fetch financial id
        public bool financeFetch(string studentID)
        {
            string query = $"SELECT * FROM mahasiswa WHERE studentID = '{studentID}';";
            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        //fetch financial id from the database
                        varFinancialID = reader.GetString("financialID");

                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No student with ID " + studentID);
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
    }
}
