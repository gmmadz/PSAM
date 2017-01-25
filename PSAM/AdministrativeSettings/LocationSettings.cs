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
    public partial class LocationSettings : MetroForm
    {
        public LocationSettings()
        {
            InitializeComponent();
        }
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //**CONNECTION STRING

        private void loadData(string query, DataGridView grid)
        {

            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt1 = new DataTable();
            string Display = query;//"SELECT GKKNAME, DISTRICT, ADDRESS FROM GkkDetails";
            MySqlCommand mycommand = new MySqlCommand(Display, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            grid.DataSource = dt1;
            grid.Columns["GKKID"].Visible = false;
            


        }

        private void updateGKK()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE gkkdetails SET gkkName = '"+metroTextBox4.Text+"', district = '"+metroComboBox2.Text+"', address = '"+metroTextBox3.Text+"' WHERE GKKID = '"+metroLabel7.Text+"' ";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
            MetroMessageBox.Show(this, "You have successfully uppdated GKK Details", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
        private void LocationSettings_Load(object sender, EventArgs e)
        {
            loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails", metroGrid1);
            loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails", metroGrid2);
            
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = metroGrid2.Rows[i];
            metroLabel7.Text = row.Cells[0].Value.ToString();
            metroTextBox4.Text = row.Cells[1].Value.ToString();
            metroComboBox2.Text = row.Cells[2].Value.ToString();
            metroTextBox3.Text = row.Cells[3].Value.ToString();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text == "" || metroTextBox4.Text == "")
            {
                MetroMessageBox.Show(this, "Please fill up the required information", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
            else
            {
                try
                {
                    updateGKK();
                    loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails", metroGrid2);
                    metroLabel7.Text = "";
                    metroTextBox4.Text = "";
                    metroComboBox2.Text = "";
                    metroTextBox3.Text = "";
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "There has been an error. Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            try
            {
                if (metroTextBox1.Text == "" || metroComboBox1.Text == "" || metroTextBox2.Text == "")
                {

                }
                else
                {
                    MySqlConnection connectMe = new MySqlConnection(connString);
                    connectMe.Open();
                    MySqlCommand newGKK = connectMe.CreateCommand();

                    newGKK.CommandText = "INSERT INTO gkkDetails(gkkName, district, address) VALUES(@gkkname, @dist, @address)";
                    newGKK.Parameters.AddWithValue("@gkkname", metroTextBox1.Text);
                    newGKK.Parameters.AddWithValue("@dist", metroComboBox1.Text);
                    newGKK.Parameters.AddWithValue("@address", metroTextBox2.Text);

                    newGKK.ExecuteNonQuery();
                    connectMe.Close();
                    MetroMessageBox.Show(this, "You have successfully added GKK Details", "Add Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails ORDER BY district", metroGrid1);
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "There has been an error. Please Try again. Error Message: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {

                if (byDistrict.Checked == false && viewAll.Checked == false && specific.Checked == false)
                {
                    MetroMessageBox.Show(this, "Please select from the two radio buttons.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (viewAll.Checked == true)
                {
                    loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails", metroGrid3);
                }
                else if (byDistrict.Checked == true)
                {
                    loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails WHERE district = '" + metroComboBox4.SelectedItem.ToString() + "'", metroGrid3);
                }
                else if (specific.Checked == true)
                {
                    loadData("SELECT GKKID, GKKNAME, DISTRICT, ADDRESS FROM GkkDetails WHERE district LIKE '%" + specificTextBox.Text + "%' OR gkkName LIKE '%" + specificTextBox.Text + "%' OR Address LIKE '%" + specificTextBox.Text + "%' ", metroGrid3);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "There has been an error. Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }

        private void specific_CheckedChanged(object sender, EventArgs e)
        {
            if (specific.Checked == true)
            {
                metroComboBox4.Visible = false;
                specificTextBox.Visible = true;
            }
        }

        private void viewAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (viewAll.Checked == true)
            {
                metroComboBox4.Visible = false;
                specificTextBox.Visible = false;
            }
        }

        private void byDistrict_CheckedChanged_1(object sender, EventArgs e)
        {
            if (byDistrict.Checked == true)
            {
                metroComboBox4.Visible = true;
                specificTextBox.Visible = false;
            }
           
        }
    }
}
