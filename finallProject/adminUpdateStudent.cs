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
    public partial class adminUpdateStudent : Form
    {
        // variable for initialize connection with database
        private MySqlConnection conn;
        private string server, database, uid, password;

        // variable for each element in database mahasiswa
        public string varFamilyName { get; set; }
        public string varName { get; set; }
        public string varStudentID { get; set; }
        public string varAddress { get; set; }
        public string varPlaceBirth { get; set; }
        public string varDateBirth { get; set; }
        public string varGender { get; set; }
        public string varReligion { get; set; }
        public string varAcademicStatus { get; set; }
        public string varResidence { get; set; }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            varStudentID = txtSearch.Text;
            if(dataFetch(varStudentID))
            {
                tbFamilyName.Text = varFamilyName;
                tbGivenName.Text = varName;
                tbAddress.Text = varAddress;
                tbPlaceBirth.Text = varPlaceBirth;
                dtpDateBirth.Value = Convert.ToDateTime(varDateBirth);
                cbGender.Text = varGender;
                cbReligion.Text = varReligion;
                cbAcademicStat.Text = varAcademicStatus;
                cbResidence.Text = varResidence;
            }
        }

        public adminUpdateStudent()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataUpdate(varStudentID);
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
        public bool dataFetch(string studentID)
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
                        //fetch * from the database
                        varFamilyName = reader.GetString("familyName");
                        varName = reader.GetString("name");
                        varAddress = reader.GetString("address");
                        varPlaceBirth = reader.GetString("placeBirth");
                        varDateBirth = Convert.ToString(reader.GetDateTime("dateBirth"));
                        varGender = reader.GetString("gender");
                        varReligion = reader.GetString("religion");
                        varAcademicStatus = reader.GetString("academicStatus");
                        varResidence = reader.GetString("residence");

                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No Student With ID " + studentID);
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

        // Update user profile
        public void dataUpdate(string studentID)
        {
            //fetch * from the form and pass it to database
            varFamilyName = tbFamilyName.Text;
            varName = tbGivenName.Text;
            varAddress = tbAddress.Text;
            varPlaceBirth = tbPlaceBirth.Text;
            varDateBirth = dtpDateBirth.Text;
            varGender = cbGender.Text;
            varReligion = cbReligion.Text;
            varAcademicStatus = cbAcademicStat.Text;
            varResidence = cbResidence.Text;

            string updateQuery = $"UPDATE mahasiswa SET familyName = '{varFamilyName}', " +
                $"name = '{varName}', address = '{varAddress}', placeBirth = '{varPlaceBirth}', " +
                $"dateBirth = '{varDateBirth}', gender = '{varGender}', religion = '{varReligion}', " +
                $"academicStatus = '{varAcademicStatus}', residence = '{varResidence}' WHERE studentID = '{studentID}';";

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn);
                    if (cmdUpdate.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("DATE UPDATED");
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
    }
}
