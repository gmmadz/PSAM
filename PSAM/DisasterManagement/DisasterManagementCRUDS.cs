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
    public partial class DisasterManagement : MetroForm
    {

        public static long disasterID;
        public DisasterManagement()
        {
            InitializeComponent();
        }

        private void DisasterManagement_Load(object sender, EventArgs e)
        {
            loadDisasterCombo();
            loadDataGridView("SELECT disasterType AS TYPE, disasterCause AS REPORTED_CAUSE, disasterDate AS DATE_OF_OCCURENCE FROM disaster", disasterGridView);
        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

        private void loadDataGridView(string query, DataGridView gridview)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gridview.DataSource = dt;
        }
        private void loadDisasterCombo()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT disasterID, CONCAT(disasterType, ': ', disasterDate) as disasterName FROM disaster ORDER BY disasterDate DESC";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            disastersCombo.DataSource = dt;
            disastersCombo.DisplayMember = "disasterName";
            disastersCombo.ValueMember = "disasterID";
        }
        //************************************************************************************** 
        private void insertDisaster()
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertDisaster = connectMe.CreateCommand();
            insertDisaster.CommandText = "INSERT INTO disaster(disasterType, disasterDate, disasterCause) VALUES (@type, @date, @cause)";
            insertDisaster.Parameters.AddWithValue("@type", disasterType.SelectedItem.ToString());
            insertDisaster.Parameters.AddWithValue("@date", disasterDate.Value.Date.ToString("yyyy-MM-dd"));
            insertDisaster.Parameters.AddWithValue("@cause", disasterCause.Text);
            insertDisaster.ExecuteNonQuery();
            disasterID = insertDisaster.LastInsertedId;
            connectMe.Close();
            loadDisasterCombo();

        }

        //************************************************************************************** 
        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                insertDisaster();
                loadDataGridView("SELECT disasterType AS TYPE, disasterCause AS REPORTED_CAUSE, disasterDate AS DATE_OF_OCCURENCE FROM disaster", disasterGridView);
                MetroMessageBox.Show(this, "You have successfully added the disaster details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
            
            }
            catch (Exception ex)
            {

            }
        }
        //************************************************************************************** 
        private void disastersCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadDetails = "SELECT disasterType, disasterDate, disasterCause FROM disaster WHERe disasterID = "+disastersCombo.SelectedValue.ToString()+"";
            MySqlDataAdapter da = new MySqlDataAdapter(loadDetails, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {

            }
            else
            {
                editDisasterType.Text = dt.Rows[0][0] + "";
                editDisasterDate.Text = dt.Rows[0][1] + "";
                editDisasterCause.Text = dt.Rows[0][2] + "";
                detailsPanel.Visible = true;
            }
        }
        //************************************************************************************** 
        private void metroTile3_Click(object sender, EventArgs e)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE disaster SET disasterType = '"+editDisasterType.SelectedItem.ToString()+"', disasterDate = '"+editDisasterDate.Value.Date.ToString("yyyy-MM-dd")+"', disasterCause = '"+editDisasterCause.Text+"' WHERE disasterId = '"+disastersCombo.SelectedValue.ToString()+"'";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
            detailsPanel.Visible = false;
            MessageBox.Show("Saved");
            loadDisasterCombo();
            loadDataGridView("SELECT disasterType AS TYPE, disasterCause AS REPORTED_CAUSE, disasterDate AS DATE_OF_OCCURENCE FROM disaster", disasterGridView);
           
            
        }
        //************************************************************************************** 
        private void disastersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (viewAll.Checked == true)
            {
                loadDataGridView("SELECT disasterType AS TYPE, disasterCause AS REPORTED_CAUSE, disasterDate AS DATE_OF_OCCURENCE FROM disaster", disasterGridView);
                filterDisasterType.Visible = false;
                from.Visible = false;
                to.Visible = false;
                filterByDateFrom.Visible = false;
                filterByDateTo.Visible = false;
                viewSpecific.Visible = false;
            }
        }

        private void filterByType_CheckedChanged(object sender, EventArgs e)
        {
            if (filterByType.Checked == true)
            {
                filterDisasterType.Visible = true;
                from.Visible = false;
                to.Visible = false;
                filterByDateFrom.Visible = false;
                filterByDateTo.Visible = false;
                viewSpecific.Visible = false;
            }
        }

        private void filterDisasterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadDataGridView("SELECT disasterType AS TYPE, disasterCause AS REPORTED_CAUSE, disasterDate AS DATE_OF_OCCURENCE FROM disaster WHERE disasterType = '"+filterDisasterType.SelectedItem.ToString()+"'", disasterGridView);
        }

      

        private void filterByDate_CheckedChanged(object sender, EventArgs e)
        {
            filterDisasterType.Visible = false;
            from.Visible = true;
            to.Visible = true;
            filterByDateFrom.Visible = true;
            filterByDateTo.Visible = true;
            viewSpecific.Visible = true;

           
        }

        private void filterDisasterDatePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void viewSpecific_Click(object sender, EventArgs e)
        {
            string whereClause = "WHERE disasterDate BETWEEN '" + filterByDateFrom.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + filterByDateTo.Value.Date.ToString("yyyy-MM-dd") + "'";
            loadDataGridView("SELECT disasterType AS TYPE, disasterCause AS REPORTED_CAUSE, disasterDate AS DATE_OF_OCCURENCE FROM disaster "+whereClause+"", disasterGridView);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            insertDisaster();
            CasualtiesAndDamages casdam = new CasualtiesAndDamages();
            this.Hide();
            casdam.Show();
        }
    }
}
