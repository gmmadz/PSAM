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
    public partial class CasualtiesAndDamages : MetroForm
    {
     

        public CasualtiesAndDamages()
        {
            InitializeComponent();
        }
            
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

        //**************************************************************************************
        private void CasualtiesAndDamages_Load(object sender, EventArgs e)
        {
            try
            {
                //loadDataGridView("SELECT respondentID, CONCAT(respondent.firstName, ' ', respondent.lastName) AS NAME, role AS ROLE FROM respondent, household", familyDGV);
                loadComboBox();
                loadDisaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //**************************************************************************************
        private void loadDataGridView(string query, DataGridView gridview)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.Columns["respondentID"].Visible = false;
        }
        //**************************************************************************************
        private void loadDisaster()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string disaster = "SELECT disasterID, CONCAT(disasterType, ': ', DATE_FORMAT(disasterDate,'%b %d %Y')) as disasterName FROM disaster";
            MySqlCommand mycommand = new MySqlCommand(disaster, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            typeOfDisaster.DataSource = dt;
            typeOfDisaster.DisplayMember = "disasterName";
            typeOfDisaster.ValueMember = "disasterID";
        }
        //**************************************************************************************
        private void loadComboBox()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string family = "SELECT householdID, lastName, CONCAT(lastName, ', ',  firstName, ' ', middleName) AS respondent FROM respondent WHERE hierarchy = 1 ORDER BY lastname ASC";
            MySqlCommand mycommand = new MySqlCommand(family, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            familyHead.DataSource = dt;
            familyHead.DisplayMember = "respondent";
            familyHead.ValueMember = "householdID";
        }
        //**************************************************************************************
        private void insertCasualties(string did, string rid, string cas)
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertCasualty = connectMe.CreateCommand();

            insertCasualty.CommandText = "INSERT INTO casualty(disasterID, respondentID, casualtyType) VALUES(@disID, @resID, @casType)";
            insertCasualty.Parameters.AddWithValue("@disID", did);
            insertCasualty.Parameters.AddWithValue("@resID", rid);
            insertCasualty.Parameters.AddWithValue("@casType", cas);
            insertCasualty.ExecuteNonQuery();
            connectMe.Close();

        }

        //**************************************************************************************
        private void insertDamages(string did, string hid, string di, string extent, float cost)
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertDamage = connectMe.CreateCommand();

            insertDamage.CommandText = "INSERT INTO damages(disasterID, householdID, damagedItem, extendOfDamage, estimatedCost) VALUES(@did, @hid, @di, @extent, @cost)";
            insertDamage.Parameters.AddWithValue("@did", did);
            insertDamage.Parameters.AddWithValue("@hid", hid);
            insertDamage.Parameters.AddWithValue("@di", di);
            insertDamage.Parameters.AddWithValue("@extent", extent);
            insertDamage.Parameters.AddWithValue("@cost", cost);
            insertDamage.ExecuteNonQuery();
            connectMe.Close();

        }
        private bool validateQuery(string query)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            MySqlDataAdapter da = new MySqlDataAdapter(query, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void insertAffectedArea(string did, string hid)
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertAffected = connectMe.CreateCommand();
            insertAffected.CommandText = "INSERT INTO affectedareas(disasterID, householdID) VALUES(@did, @hid)";
            insertAffected.Parameters.AddWithValue("@did", did);
            insertAffected.Parameters.AddWithValue("@hid", hid);
            insertAffected.ExecuteNonQuery();
            connectMe.Close();
        }
        //************************************************************************************** CASUALTIES
        //**************************************************************************************  
        //**************************************************************************************  
        //**************************************************************************************  
        //**************************************************************************************  
        //**************************************************************************************  
        //**************************************************************************************  
        //**************************************************************************************  
        //************************************************************************************** INJURED
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            
            
            foreach (DataGridViewRow row in familyDGV.SelectedRows)
            {

                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string role = row.Cells[2].Value.ToString();
                string remarks = "Injured";
                string query = "SELECT * from casualty where respondentID= '" + id + "' AND casualtyType = '" + remarks + "'";
                string multiQuery = "SELECT * FROM casualty WHERE disasterID = '" + typeOfDisaster.SelectedValue.ToString() + "' AND respondentID = '" + id + "'";

                if (validateQuery(query))
                {
                    MetroMessageBox.Show(this, "Person '" + name + "' is already marked " + remarks + " in other disaster. ", "Multiple Entries: Person is already marked dead.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (validateQuery(multiQuery))
                {
                    MetroMessageBox.Show(this, "Person '" + name + "' is already marked in the same Disaster. ", "Multiple Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    this.casualtiesDGV.Rows.Add(id, name, remarks, role);
                    this.familyDGV.Rows.RemoveAt(row.Index);
                }
                   
               
                
            }
        }
        //************************************************************************************** RESET
       private void metroTextButton4_Click(object sender, EventArgs e)
        {
            casualtiesDGV.Rows.Clear();
            casualtiesDGV.Refresh();
            loadDataGridView("SELECT respondentID, CONCAT(respondent.firstName, ' ', respondent.lastName) AS NAME, role AS ROLE FROM respondent, household WHERE household.householdID = respondent.householdID AND household.householdID = '" + familyHead.SelectedValue.ToString() + "'", familyDGV);
        
        }
       //************************************************************************************** MISSING
       private void metroTextButton2_Click(object sender, EventArgs e)
       {
           foreach (DataGridViewRow row in familyDGV.SelectedRows)
           {
               string id = row.Cells[0].Value.ToString();
               string name = row.Cells[1].Value.ToString();
               string role = row.Cells[2].Value.ToString();
               string remarks = "Missing";
               string query = "SELECT * from casualty where respondentID= '" + id + "' AND casualtyType = '" + remarks + "'";
               string multiQuery = "SELECT * FROM casualty WHERE disasterID = '" + typeOfDisaster.SelectedValue.ToString() + "' AND respondentID = '" + id + "'";

               if (validateQuery(query))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked " + remarks + " in other disaster. ", "Multiple Entries: Person is already marked dead.", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else if (validateQuery(multiQuery))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked in the same Disaster. ", "Multiple Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else
               {
                   this.casualtiesDGV.Rows.Add(id, name, remarks, role);
                   this.familyDGV.Rows.RemoveAt(row.Index);
               }
                   
           }
       }
       //************************************************************************************** DEAD
       private void metroTextButton3_Click(object sender, EventArgs e)
       {
           foreach (DataGridViewRow row in familyDGV.SelectedRows)
           {
               string id = row.Cells[0].Value.ToString();
               string name = row.Cells[1].Value.ToString();
               string role = row.Cells[2].Value.ToString();
               string remarks = "Dead";

               string query = "SELECT * from casualty where respondentID= '" + id + "' AND casualtyType = '" + remarks + "'";
               string multiQuery = "SELECT * FROM casualty WHERE disasterID = '" + typeOfDisaster.SelectedValue.ToString() + "' AND respondentID = '" + id + "'";

               if (validateQuery(query))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked " + remarks + " in other disaster. ", "Multiple Entries: Person is already marked dead.", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else if (validateQuery(multiQuery))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked in the same Disaster. ", "Multiple Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else
               {
                   this.casualtiesDGV.Rows.Add(id, name, remarks, role);
                   this.familyDGV.Rows.RemoveAt(row.Index);
               }
              
           }

           
       }
       //**************************************************************************************
       private void metroTile1_Click(object sender, EventArgs e)
       {

           try
           {
               foreach (DataGridViewRow row in casualtiesDGV.Rows)
               {
                   string id = row.Cells[0].Value.ToString();
                   string remarks = row.Cells[2].Value.ToString();
                   insertCasualties(typeOfDisaster.SelectedValue.ToString(), id, remarks);

               }

               string disasterID = typeOfDisaster.SelectedValue.ToString();
               string familyID = familyHead.SelectedValue.ToString();

               foreach (DataGridViewRow row in damages.Rows)
               {
                   string damItem = row.Cells[0].Value.ToString();
                   string extent = row.Cells[1].Value.ToString();
                   string estCost = row.Cells[2].Value.ToString();
                   insertDamages(disasterID, familyID, damItem, extent, float.Parse(estCost));
               }

               insertAffectedArea(disasterID, familyID);
               MetroMessageBox.Show(this, "You have successfully added the casualties / damages details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           catch (Exception ex)
           {

           }
       }

       //**************************************************************************************  
       //**************************************************************************************  
       //**************************************************************************************  
       //**************************************************************************************  
       //**************************************************************************************  
       //**************************************************************************************  
       //**************************************************************************************  
       //**************************************************************************************  DAMAGES

       //************************************************************************************** ADD DAMAGES
       private void metroTextButton5_Click(object sender, EventArgs e)
       {
           
           
           string itemDamageString = (itemDamaged.SelectedIndex!=2)?itemDamaged.SelectedItem.ToString():specifyItem.Text;
           string extent = itemExtent.SelectedItem.ToString();
           string cost = itemCost.Text;

           //add data validation here
           this.damages.Rows.Add(itemDamageString, extent, cost);

           itemCost.Text = "";
           itemExtent.Text = "";
           itemDamaged.Text = "";
           specifyItem.Text = "";

       }
       //************************************************************************************** 
       private void itemDamaged_SelectionChangeCommitted(object sender, EventArgs e)
       {
           if (itemDamaged.SelectedIndex == 2)
           {
               specifyItem.Visible = true;
               specifyItemLabel.Visible = true;
           }
           else
           {
               specifyItem.Visible = false;
               specifyItemLabel.Visible = false;
           }
       }
       //************************************************************************************** 
       private void metroTextButton6_Click(object sender, EventArgs e)
       {
          
       }

       private void familyHead_SelectionChangeCommitted(object sender, EventArgs e)
       {
           loadDataGridView("SELECT respondentID, CONCAT(respondent.firstName, ' ', respondent.lastName) AS NAME, role AS ROLE FROM respondent, household WHERE household.householdID = respondent.householdID AND household.householdID = '"+familyHead.SelectedValue.ToString()+"'", familyDGV);
       }

       private void familyHead_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void metroTile2_Click(object sender, EventArgs e)
       {
           damages.Rows.Clear();
           damages.Refresh();
       }

       private void metroTile3_Click(object sender, EventArgs e) //ADD DAMAGES
       {

           if (itemDamaged.SelectedIndex == -1 || itemCost.Text == "" || itemExtent.SelectedIndex == -1)
           {
               MetroMessageBox.Show(this, "Please fill up the required information. ", "Incomplete Details.", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
           else
           {
               string itemDamageString = (itemDamaged.SelectedIndex != 2) ? itemDamaged.SelectedItem.ToString() : specifyItem.Text;
               string extent = itemExtent.SelectedItem.ToString();
               string cost = itemCost.Text;

               //add data validation here
               this.damages.Rows.Add(itemDamageString, extent, cost);

               itemCost.Text = "";
               itemExtent.Text = "";
               itemDamaged.Text = "";
               specifyItem.Text = "";
           }
          
       }

       private void metroTile4_Click(object sender, EventArgs e) // INJURED
       {
           foreach (DataGridViewRow row in familyDGV.SelectedRows)
           {

               string id = row.Cells[0].Value.ToString();
               string name = row.Cells[1].Value.ToString();
               string role = row.Cells[2].Value.ToString();
               string remarks = "Injured";
               string query = "SELECT * from casualty where respondentID= '" + id + "' AND casualtyType = '" + remarks + "'";
               string multiQuery = "SELECT * FROM casualty WHERE disasterID = '" + typeOfDisaster.SelectedValue.ToString() + "' AND respondentID = '" + id + "'";

               if (validateQuery(query))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked " + remarks + " in other disaster. ", "Multiple Entries: Person is already marked dead.", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else if (validateQuery(multiQuery))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked in the same Disaster. ", "Multiple Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else
               {
                   this.casualtiesDGV.Rows.Add(id, name, remarks, role);
                   this.familyDGV.Rows.RemoveAt(row.Index);
               }



           }
       }

       private void metroTile5_Click(object sender, EventArgs e) //MISSING
       {
           foreach (DataGridViewRow row in familyDGV.SelectedRows)
           {
               string id = row.Cells[0].Value.ToString();
               string name = row.Cells[1].Value.ToString();
               string role = row.Cells[2].Value.ToString();
               string remarks = "Missing";
               string query = "SELECT * from casualty where respondentID= '" + id + "' AND casualtyType = '" + remarks + "'";
               string multiQuery = "SELECT * FROM casualty WHERE disasterID = '" + typeOfDisaster.SelectedValue.ToString() + "' AND respondentID = '" + id + "'";

               if (validateQuery(query))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked " + remarks + " in other disaster. ", "Multiple Entries: Person is already marked dead.", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else if (validateQuery(multiQuery))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked in the same Disaster. ", "Multiple Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else
               {
                   this.casualtiesDGV.Rows.Add(id, name, remarks, role);
                   this.familyDGV.Rows.RemoveAt(row.Index);
               }

           }
       }

       private void metroTile6_Click(object sender, EventArgs e) //DEAD
       {
           foreach (DataGridViewRow row in familyDGV.SelectedRows)
           {
               string id = row.Cells[0].Value.ToString();
               string name = row.Cells[1].Value.ToString();
               string role = row.Cells[2].Value.ToString();
               string remarks = "Dead";

               string query = "SELECT * from casualty where respondentID= '" + id + "' AND casualtyType = '" + remarks + "'";
               string multiQuery = "SELECT * FROM casualty WHERE disasterID = '" + typeOfDisaster.SelectedValue.ToString() + "' AND respondentID = '" + id + "'";

               if (validateQuery(query))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked " + remarks + " in other disaster. ", "Multiple Entries: Person is already marked dead.", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else if (validateQuery(multiQuery))
               {
                   MetroMessageBox.Show(this, "Person '" + name + "' is already marked in the same Disaster. ", "Multiple Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else
               {
                   this.casualtiesDGV.Rows.Add(id, name, remarks, role);
                   this.familyDGV.Rows.RemoveAt(row.Index);
               }

           }
       }

       private void metroTile7_Click(object sender, EventArgs e) //RESET
       {
           casualtiesDGV.Rows.Clear();
           casualtiesDGV.Refresh();
           loadDataGridView("SELECT respondentID, CONCAT(respondent.firstName, ' ', respondent.lastName) AS NAME, role AS ROLE FROM respondent, household WHERE household.householdID = respondent.householdID AND household.householdID = '" + familyHead.SelectedValue.ToString() + "'", familyDGV);
        
       }

       private void metroTile8_Click(object sender, EventArgs e)
       {
           casualtiesDGV.Rows.Clear();
           casualtiesDGV.Refresh();
           loadDataGridView("SELECT respondentID, CONCAT(respondent.firstName, ' ', respondent.lastName) AS NAME, role AS ROLE FROM respondent, household WHERE household.householdID = respondent.householdID AND household.householdID = '" + familyHead.SelectedValue.ToString() + "'", familyDGV);
        
       }
       
       
       
    }
}
