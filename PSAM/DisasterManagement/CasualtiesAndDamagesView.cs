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
    public partial class CasualtiesAndDamagesView : MetroForm
    {
        public CasualtiesAndDamagesView()
        {
            InitializeComponent();
          
        }
          
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

        
        private void loadDataGridView(string query, DataGridView gridview)
        {

            gridview.DataSource = null;
            gridview.Refresh();
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gridview.DataSource = dt;
        }
        private void loadComboBox()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string family = "SELECT respondent.householdID, CONCAT(respondent.lastName,', ', respondent.firstName) AS NAME FROM respondent, casualty WHERE respondent.respondentID = casualty.respondentID AND respondent.relatedTo = 0 GROUP BY respondent.householdID";
            MySqlCommand mycommand = new MySqlCommand(family, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            familyHead.DataSource = dt;
            familyHead.DisplayMember = "NAME";
            familyHead.ValueMember = "householdID";
        }

        //**************************************************************************************
        private void CasualtiesAndDamagesView_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }
        //**************************************************************************************
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioViewAll_CheckedChanged(object sender, EventArgs e)
        {
            casualtiesDGV.DataSource = null;
            damagesDGV.DataSource = null;
            if (radioViewAll.Checked == true)
            {
                comboDisaster.Visible = false;
                string queryViewAllCasualties = "SELECT concat(respondent.lastName,', ', respondent.firstName) AS 'NAME', casualty.casualtyType AS 'REMARKS', disaster.disasterType AS 'DISASTER'	FROM casualty, respondent, disaster WHERE casualty.respondentID = respondent.respondentID AND disaster.disasterID = casualty.disasterID";
                string queryViewAllDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID GROUP BY damages.damagesID";
                loadDataGridView(queryViewAllCasualties, casualtiesDGV);
                loadDataGridView(queryViewAllDamages, damagesDGV);
            }
        }

        private void radioType_CheckedChanged(object sender, EventArgs e)
        {
            casualtiesDGV.DataSource = null;
            damagesDGV.DataSource = null;
            if (radioType.Checked == true) {

                comboDisaster.Visible = true;
                labelType.Visible = true;

                to.Visible = false;
                from.Visible = false;
                filterByDateFrom.Visible = false;
                filterByDateTo.Visible = false;
                viewSpecific.Visible = false;
                labelFamilyHead.Visible = false;
                familyHead.Visible = false;
                viewFamilyHead.Visible = false;
            }
        }

        private void comboDisaster_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (radioType.Checked == true)
            {
                string queryFilterByTypeCasualties = "SELECT concat(respondent.lastName,', ', respondent.firstName) AS 'NAME', casualty.casualtyType AS 'REMARKS', disaster.disasterType AS 'DISASTER'	FROM casualty, respondent, disaster WHERE casualty.respondentID = respondent.respondentID AND disaster.disasterID = casualty.disasterID AND disaster.disasterType = '" + comboDisaster.SelectedItem.ToString() + "'";
                string queryFilterByTypeDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID AND disaster.disasterType = '" + comboDisaster.SelectedItem.ToString() + "' GROUP BY damages.damagesID";
                loadDataGridView(queryFilterByTypeCasualties, casualtiesDGV);
                loadDataGridView(queryFilterByTypeDamages, damagesDGV);
            }
        }

        private void radioDate_CheckedChanged(object sender, EventArgs e)
        {
            casualtiesDGV.DataSource = null;
            damagesDGV.DataSource = null;
            if (radioDate.Checked == true)
            {
                to.Visible = true;
                from.Visible = true;
                filterByDateFrom.Visible = true;
                filterByDateTo.Visible = true;
                viewSpecific.Visible = true;

                comboDisaster.Visible = false;
                labelType.Visible = false;

               
                labelFamilyHead.Visible = false;
                familyHead.Visible = false;
                viewFamilyHead.Visible = false;
            }
        }

        private void viewSpecific_Click(object sender, EventArgs e)
        {
            if (radioDate.Checked == true)
            {
                string queryDateDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID AND disasterDate BETWEEN '" + filterByDateFrom.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + filterByDateTo.Value.Date.ToString("yyyy-MM-dd") + "' GROUP BY damages.damagesID";
                string queryDateCasualties = "SELECT concat(respondent.lastName,', ', respondent.firstName) AS 'NAME', casualty.casualtyType AS 'REMARKS', disaster.disasterType AS 'DISASTER' FROM casualty, respondent, disaster WHERE casualty.respondentID = respondent.respondentID AND disaster.disasterID = casualty.disasterID AND disaster.disasterDate BETWEEN '" + filterByDateFrom.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + filterByDateTo.Value.Date.ToString("yyyy-MM-dd") + "'";
                loadDataGridView(queryDateCasualties, casualtiesDGV);
                loadDataGridView(queryDateDamages, damagesDGV);
            }
            else if (radioTypeDate.Checked == true)
            {
                string queryDateTypeCasualties = "SELECT concat(respondent.lastName,', ', respondent.firstName) AS 'NAME', casualty.casualtyType AS 'REMARKS', disaster.disasterType AS 'DISASTER' FROM casualty, respondent, disaster WHERE casualty.respondentID = respondent.respondentID AND disaster.disasterID = casualty.disasterID AND disaster.disasterType = '" + comboDisaster.SelectedItem.ToString() + "' AND disaster.disasterDate BETWEEN '" + filterByDateFrom.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + filterByDateTo.Value.Date.ToString("yyyy-MM-dd") + "'";
                string queryDateTypeDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID AND disaster.disasterType = 'Tsunami' AND disaster.disasterDate BETWEEN '2009-01-01' AND '2016-01-01' GROUP BY damages.damagesID";
                loadDataGridView(queryDateTypeCasualties, casualtiesDGV);
                loadDataGridView(queryDateTypeDamages, damagesDGV);
            }
            
       }

        private void radioTypeDate_CheckedChanged(object sender, EventArgs e)
        {
            casualtiesDGV.DataSource = null;
            damagesDGV.DataSource = null;
            if (radioTypeDate.Checked == true)
            {
                to.Visible = true;
                from.Visible = true;
                filterByDateFrom.Visible = true;
                filterByDateTo.Visible = true;
                viewSpecific.Visible = true;
                comboDisaster.Visible = true;
                labelType.Visible = true;

                
                labelFamilyHead.Visible = false;
                familyHead.Visible = false;
                viewFamilyHead.Visible = false;
            }
        }

        private void radioTypeFamHead_CheckedChanged(object sender, EventArgs e)
        {
            casualtiesDGV.DataSource = null;
            damagesDGV.DataSource = null;

            if (radioTypeFamHead.Checked == true)
            {
                familyHead.Visible = true;
                comboDisaster.Visible = true;
                viewFamilyHead.Visible = true;



                labelType.Visible = true;

                to.Visible = false;
                from.Visible = false;
                filterByDateFrom.Visible = false;
                filterByDateTo.Visible = false;
                viewSpecific.Visible = false;
               
            }
        }
        ///FINALIZE MORE combofamilyhead is redundant 
        private void familyHead_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboDisaster.Text))
            {
                DataRowView drv = (DataRowView)familyHead.SelectedItem;
                string houseID = drv["householdID"].ToString();
                string queryTypeFamHeadCasualty = "SELECT concat(respondent.lastName,', ', respondent.firstName) AS 'NAME', casualty.casualtyType AS 'REMARKS', disaster.disasterType AS 'DISASTER'	FROM casualty, respondent, disaster, affectedareas WHERE casualty.respondentID = respondent.respondentID AND disaster.disasterID = casualty.disasterID AND disaster.disasterType = '" + comboDisaster.SelectedItem.ToString() + "' AND affectedareas.houseHoldID = '" + houseID + "' AND respondent.houseHoldID = affectedareas.houseHoldID GROUP BY casualty.respondentID";
                string queryTypeFamHeadDamages = "SELECT CONCAT(respondent.lastName, ', ', respondent.firstName) AS FAMILY, disaster.disasterType AS DISASTER, damages.damagedItem AS ITEM, damages.extendOfDamage AS EXTENT, damages.estimatedCost AS COST FROM damages, respondent, disaster, household WHERE respondent.relatedTo = 0 AND damages.houseHoldID = respondent.houseHoldID AND damages.disasterID = disaster.disasterID AND disaster.disasterType = '" + comboDisaster.SelectedItem.ToString() + "' AND respondent.houseHoldID = '" + houseID + "' GROUP BY respondent.householdID";
                loadDataGridView(queryTypeFamHeadCasualty, casualtiesDGV);
                loadDataGridView(queryTypeFamHeadDamages, damagesDGV);
            }
            else
            {
                MessageBox.Show("Please Complete the needed fields!");
            }
        }
    }
}
