using MetroFramework.Forms;
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

namespace PSAM
{
    public partial class UserManagement : MetroForm
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //**CONNECTION STRING






        //**LOAD DATA
        //****************************************************************************************************************
        private void loadData()
        {

            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt1 = new DataTable();
            string Display = "SELECT USERNAME, PASSWORD, POSITION, FIRSTNAME, MIDDLENAME, LASTNAME FROM Employee";
            MySqlCommand mycommand = new MySqlCommand(Display, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            metroGrid1.DataSource = dt1;


        }



        //**FORM LOAD
        //****************************************************************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }





        //**REGISTER
        //****************************************************************************************************************
        private void metroButton1_Click(object sender, EventArgs e)
        {


            try
            {
                if (addUsername.Text == "" || addPassword.Text == "" || addFirstname.Text == "" || addMiddlename.Text == "" || addLastname.Text == "" || addPosition.Text == "")
                {
                    MessageBox.Show("There are inputs needed to be entered!");
                }

                else
                {


                    MySqlConnection connectMe = new MySqlConnection(connString);
                    connectMe.Open();
                    MySqlCommand verifyUsername = new MySqlCommand();
                    verifyUsername.CommandText = "SELECT username FROM Employee WHERE username=@usn";
                    verifyUsername.Parameters.AddWithValue("@usn", addUsername.Text);
                    verifyUsername.Connection = connectMe;
                    MySqlDataReader verify = verifyUsername.ExecuteReader();

                    if (verify.Read())
                    {
                        MessageBox.Show("The username already exists.");

                    }
                    else
                    {

                        string AddEmp = "INSERT INTO Employee (username, password, position, firstName, middleName, lastName)" +
                            " Values ('" + this.addUsername.Text + "', '" + addPassword.Text + "', '" + this.addPosition.SelectedItem.ToString() + "' , '" + this.addFirstname.Text + "', '" + this.addMiddlename.Text + "', '" + this.addLastname.Text + "' )";
                        MySqlConnection connect = new MySqlConnection(connString);
                        MySqlCommand cmdAddEmp = new MySqlCommand(AddEmp, connect);
                        MySqlDataReader rdr;

                        connect.Open();
                        rdr = cmdAddEmp.ExecuteReader();
                        connect.Close();
                        connectMe.Close();
                        addUsername.Text = "";
                        addPassword.Text = "";
                        addFirstname.Text = "";
                        addMiddlename.Text = "";
                        addLastname.Text = "";
                        addPosition.Text = "";
                        MessageBox.Show("User successfully registered.");
                        loadData();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //**FILL IN TEXTBOXES
        //****************************************************************************************************************
        
        string empID = "";
        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                string input = editEnterUsn.Text.Trim();

                MySqlConnection myconn = new MySqlConnection(connString);

                string sql = "SELECT username, password, position, firstName, middleName, lastName, employeeID FROM employee WHERE username ='" + input + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, myconn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(input + " does not exist.", "Not Exists");
                }
                else
                {
                    editUsername.Text = dt.Rows[0][0] + "";
                    editPassword.Text = dt.Rows[0][1] + "";
                    editPosition.Text = dt.Rows[0][2] + "";
                    editFirstname.Text = dt.Rows[0][3] + "";
                    editMiddlename.Text = dt.Rows[0][4] + "";
                    editLastname.Text = dt.Rows[0][5] + "";
                    empID = "" + dt.Rows[0][6];

                }
                updateButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //**UPDATE BUTTON
        //****************************************************************************************************************
        private void updateButton_Click(object sender, EventArgs e)
        {

            try
            {
                string SQLUpdateEmployee = "UPDATE Employee SET password ='" + editPassword.Text + "', position ='" + editPosition.SelectedItem.ToString() + "', firstname ='" + editFirstname.Text + "', middlename ='" + editMiddlename.Text + "', lastname='" + editLastname.Text + "' WHERE EmployeeID = ' " + empID + " ' ";
                MySqlConnection connect = new MySqlConnection(connString);
                MySqlCommand cmdUpdateEmployee = new MySqlCommand(SQLUpdateEmployee, connect);
                MySqlDataReader rdr;
                connect.Open();
                rdr = cmdUpdateEmployee.ExecuteReader();
                connect.Close();
                loadData();

                MessageBox.Show("Data Updated");
                editUsername.Text = "";
                editPassword.Text = "";
                editPosition.Text = "";
                editFirstname.Text = "";
                editMiddlename.Text = "";
                editLastname.Text = "";

                updateButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //**SEARCH
        //****************************************************************************************************************
       
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string search = searchText.Text.ToString();
                MySqlConnection myconn = new MySqlConnection(connString);
                DataTable dt1 = new DataTable();
                string searchString = "SELECT USERNAME, PASSWORD, POSITION, FIRSTNAME, MIDDLENAME, LASTNAME FROM Employee WHERE username LIKE '%" + search + "%' OR position LIKE '%" + search + "%' OR firstname LIKE '%" + search + "%' OR middlename LIKE '%" + search + "%' OR lastname LIKE '%" + search + "%'";
                MySqlCommand mycommand = new MySqlCommand(searchString, myconn);
                MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
                da1.Fill(dt1);
                metroGrid1.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //****************************************************************************************************************
       

    }
}
