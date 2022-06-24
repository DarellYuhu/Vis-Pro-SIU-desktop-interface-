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
using System.IO;

namespace finallProject
{
    public partial class profileForm : Form
    {
        // variable for initialize connection with database
        private MySqlConnection conn;
        private string server, database, uid, password;
        private MemoryStream ms;

        // variable for each element in database mahasiswa
        public string varFamilyName { get; set; }
        public string varName { get; set; }
        public string varStudentID { get; set; }
        public string varRegistID { get; set; }
        public string varFaculty { get; set; }
        public string varProgStudy { get; set; }
        public string varAddress { get; set; }
        public string varPlaceBirth { get; set; }
        public DateTime varDateBirth { get; set; }
        public string varGender { get; set; }
        public string varReligion { get; set; }
        public string varAcademicStatus { get; set; }
        public string varResidence { get; set; }

        public profileForm()
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

        private void profileForm_Load(object sender, EventArgs e)
        {
            dataFetch(varStudentID);
            lblRegistID.Text = varRegistID;
            lblStudentID.Text = varStudentID;
            lblFacMaj.Text = (varFaculty + " / " + varProgStudy);
            lblReligion.Text = varReligion;
            lblAcdStatus.Text = varAcademicStatus;
            lblResidence.Text = varResidence;
            lblAddress.Text = varAddress;
            lblBirth.Text = (varPlaceBirth + " / " + varDateBirth.ToString("dd'-'MM'-'yyyy"));
            lblGender.Text = varGender;
            lblName.Text = (varFamilyName + ", " + varName);
            profilePict.Image = Image.FromStream(ms);
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
                        varRegistID = reader.GetString("financialID");
                        varFaculty = reader.GetString("faculty");
                        varProgStudy = reader.GetString("progStudy");
                        varAddress = reader.GetString("address");
                        varPlaceBirth = reader.GetString("placeBirth");
                        varDateBirth = reader.GetDateTime("dateBirth");
                        varGender = reader.GetString("gender");
                        varReligion = reader.GetString("religion");
                        varAcademicStatus = reader.GetString("academicStatus");
                        varResidence = reader.GetString("residence");
                        byte[] img = (byte[])reader[12];
                        ms = new MemoryStream(img);


                        reader.Close();
                        conn.Close();
                    }
                    else
                    {
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
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

    }
}
