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
    public partial class CasualtiesAndDamagesEdit : MetroForm
    {
        public CasualtiesAndDamagesEdit()
        {
            InitializeComponent();
        }

        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

        private void loadDisasterCombo()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT disasterID, CONCAT(disasterType, ': ', disasterDate) as disasterName FROM disaster ORDER BY disasterDate DESC";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            disasterCombo.DataSource = dt;
            disasterCombo.DisplayMember = "disasterName";
            disasterCombo.ValueMember = "disasterID";
        }

        //**************************************************************************************
        private void loadComboBox(string disID)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string family = "SELECT respondent.householdID, CONCAT(respondent.lastName,', ', respondent.firstName) AS NAME FROM respondent, casualty WHERE respondent.respondentID = casualty.respondentID AND casualty.disasterID = '"+disID+"' AND respondent.relatedTo = 0";
            MySqlCommand mycommand = new MySqlCommand(family, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            familyHead.DataSource = dt;
            familyHead.DisplayMember = "NAME";
            familyHead.ValueMember = "householdID";
        }
        //**************************************************************************************
        private void loadDataGridView(string query, DataGridView gridview)
        {
            gridview.Refresh();
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gridview.DataSource = dt;

            gridview.Columns["ID"].Visible = false;
        }


        //**************************************************************************************
        private void CasualtiesAndDamagesEdit_Load(object sender, EventArgs e)
        {
            loadDisasterCombo();
            loadComboBox(disasterCombo.SelectedValue.ToString());
        }
        //**************************************************************************************
        private void disasterCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboBox(disasterCombo.SelectedValue.ToString());
        }
        //**************************************************************************************

               
        private void metroTextButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string queryGlobalCasualty = "SELECT respondent.respondentID AS ID, CONCAT(respondent.LastName, ', ', respondent.firstName) AS NAME, casualty.casualtyType AS REMARKS FROM respondent, casualty WHERE respondent.respondentID = casualty.respondentID AND respondent.houseHoldID = '" + familyHead.SelectedValue.ToString() + "' AND casualty.disasterID = '" + disasterCombo.SelectedValue.ToString() + "'";
                loadDataGridView(queryGlobalCasualty, casualtiesDGV);
                DataRowView drv = (DataRowView)familyHead.SelectedItem;
                string houseID = drv["householdID"].ToString();
               
                DataRowView drv1 = (DataRowView)disasterCombo.SelectedItem;
                string disID = drv1["disasterID"].ToString();
                string queryTypeFamHeadDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST, damages.damagesID AS ID FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID AND disaster.disasterID = '" + disID + "' AND respondent.houseHoldID = '" + houseID + "' GROUP BY respondent.householdID";
                loadDataGridView(queryTypeFamHeadDamages, damages);
            }
            catch (Exception ex)
            {
               // MessageBox.Show("No Result. Please select something else.");
                MessageBox.Show("" + ex);
            }
        }


        private void updateCasualty(string id, string type)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE casualty SET casualtyType = '" + type + "' WHERE respondentID ='" +id+ "'";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
            MessageBox.Show("Saved");
        }
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in casualtiesDGV.SelectedRows)
                {
                    string queryGlobal = "SELECT respondent.respondentID AS ID, CONCAT(respondent.LastName, ', ', respondent.firstName) AS NAME, casualty.casualtyType AS REMARKS FROM respondent, casualty WHERE respondent.respondentID = casualty.respondentID AND respondent.houseHoldID = '" + familyHead.SelectedValue.ToString() + "' AND casualty.disasterID = '" + disasterCombo.SelectedValue.ToString() + "'";
                    string id = row.Cells[0].Value.ToString();
                    updateCasualty(id, "Injured");
                    loadDataGridView(queryGlobal, casualtiesDGV);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void missingButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in casualtiesDGV.SelectedRows)
            {
                string queryGlobal = "SELECT respondent.respondentID AS ID, CONCAT(respondent.LastName, ', ', respondent.firstName) AS NAME, casualty.casualtyType AS REMARKS FROM respondent, casualty WHERE respondent.respondentID = casualty.respondentID AND respondent.houseHoldID = '" + familyHead.SelectedValue.ToString() + "' AND casualty.disasterID = '" + disasterCombo.SelectedValue.ToString() + "'";
                string id = row.Cells[0].Value.ToString();
                updateCasualty(id, "Missing");
                loadDataGridView(queryGlobal, casualtiesDGV);
            }
        }

        private void deadButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in casualtiesDGV.SelectedRows)
            {
                string queryGlobal = "SELECT respondent.respondentID AS ID, CONCAT(respondent.LastName, ', ', respondent.firstName) AS NAME, casualty.casualtyType AS REMARKS FROM respondent, casualty WHERE respondent.respondentID = casualty.respondentID AND respondent.houseHoldID = '" + familyHead.SelectedValue.ToString() + "' AND casualty.disasterID = '" + disasterCombo.SelectedValue.ToString() + "'";
                string id = row.Cells[0].Value.ToString();
                updateCasualty(id, "Dead");
                loadDataGridView(queryGlobal, casualtiesDGV);
            }
        }
        private void updateDamages(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE damages SET damagedItem = '"+damagedItem.Text+"', extendOfDamage = '"+itemExtent.SelectedItem.ToString()+"', estimatedCost = '"+itemCost.Text+"' WHERE damagesID = '"+id+"'";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
        }
       string damageID;
        private void damages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = damages.Rows[i];
            damagedItem.Text = row.Cells[2].Value.ToString();
            itemExtent.Text = row.Cells[3].Value.ToString();
            itemCost.Text = row.Cells[4].Value.ToString();
            damageID = row.Cells[5].Value.ToString();
            

        }
        //************************************************************************************** update damages
        private void metroTextButton5_Click(object sender, EventArgs e)
        {
          
            updateDamages(damageID);

            DataRowView drv = (DataRowView)familyHead.SelectedItem;
            string houseID = drv["householdID"].ToString();

            DataRowView drv1 = (DataRowView)disasterCombo.SelectedItem;
            string disID = drv1["disasterID"].ToString();
            string queryTypeFamHeadDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST, damages.damagesID AS ID FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID AND disaster.disasterID = '" + disID + "' AND respondent.houseHoldID = '" + houseID + "' GROUP BY respondent.householdID";
            loadDataGridView(queryTypeFamHeadDamages, damages);
        }

        private void metroTextButton1_Click_1(object sender, EventArgs e)
        {
            damagedItem.Text = "";
            itemExtent.Text = "";
            itemCost.Text = "";
            casualtiesDGV.DataSource = null;
            damages.DataSource = null;
            MessageBox.Show("Casualties and Damages successfully updated!");
        }

        //**************************************************************************************
    }
}
