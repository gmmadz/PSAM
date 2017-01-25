using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAM
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private string conn;
        private MySqlConnection connect;

        private void db_connection()
        {
            try
            {
                conn = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
     
        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from employee where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = loginUsername.Text;
            string pass = loginPassword.Text;
            if (user == "" || pass == "")
            {
                MetroMessageBox.Show(this, "Please fill up the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {

                //************************************************************************************** CONNECTION STRING
                string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
                //************************************************************************************** CONNECTION STRING

                MySqlConnection myconn = new MySqlConnection(connString);
                string usern = "Select position from employee where username = '"+user+"' AND password ='"+pass+"'";

                MySqlDataAdapter da1 = new MySqlDataAdapter(usern, myconn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {

                }
                else
                {
                    MetroMessageBox.Show(this, "Welcome " + user + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home h = new Home(dt1.Rows[0][0].ToString());
                    this.Hide();
                    h.Show();
                }

                
            }
            else
               MetroMessageBox.Show(this, "Incorrect Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
