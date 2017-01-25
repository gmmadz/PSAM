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
using MetroFramework;

namespace PSAM
{
    public partial class ProfileGridEdit : MetroForm
    {

        public ProfileGridEdit()
        {
            InitializeComponent();
        }

        private void ProfileGridEdit_Load(object sender, EventArgs e)
        {
            loadComboBox();
            showAllGKKDetails();
        }
        private void saveProfile_Click(object sender, EventArgs e)
        {
            updateHouseHold(familyHead.SelectedValue.ToString());
            updateProfile.Visible = true;
            modePanel.Visible = false;
            pageDivTile.BackColor = MetroFramework.MetroColors.Silver;
           //clearAll();

        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

        string gkkName;
        private void loadGKK(string dist)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT gkkName FROM gkkdetails WHERE district = '"+dist+"'";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            showGKK.DataSource = dt;
            showGKK.DisplayMember = "gkkName";
        }

        private void loadAddress(string dist, string gkk)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT address FROM gkkdetails WHERE district = '"+dist+"' AND gkkName = '"+gkk+"'";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            showBarangay.DataSource = dt;
            showBarangay.DisplayMember = "address";
        }


        private void showAllGKKDetails()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT gkkID, CONCAT(district, ' - ', gkkName, ' - ', address) as address FROM gkkdetails";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            showAllGKK.DataSource = dt;
            showAllGKK.DisplayMember = "address";
            showAllGKK.ValueMember = "gkkID";
        }
        
        private void loadComboBox()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string family = "SELECT respondentID, lastName, CONCAT(lastName, ', ',  firstName, ' ', middleName) AS respondent FROM respondent WHERE hierarchy = 1 ORDER BY lastname ASC";
            MySqlCommand mycommand = new MySqlCommand(family, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            familyHead.DataSource = dt;
            familyHead.DisplayMember = "respondent";
            familyHead.ValueMember = "respondentID";
        }
        //************************************************************************************* loadCivilStatus
        private void loadCivilStatus(string rID)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadDataCivil = "SELECT civilStatus, marriageType FROM respondent WHERE respondentID = '" + rID + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(loadDataCivil, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("It does not exist.", "Not Exists");
            }
            else
            {
                civilStatus.Text = dt.Rows[0][0] + "";
                marriedType.Text = dt.Rows[0][1] + "";
            }
        }
        //************************************************************************************* loadHousehold
        private void loadHousehold(string rID)
        {
            string id = "(SELECT householdID FROM respondent WHERE respondentID = '" + rID + "' AND hierarchy = 1)";
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadHousehold = "SELECT g.gkkName, g.address, g.district, h.familyMonthlyIncome, h.houseOccupancy, h.houseStructure, h.residenceLocation, h.isFloodProne, h.preparation, h.isMemberGovOrg, h.position, h.ifCanHelp, h.surveyor, h.dateOfSurvey FROM household h, gkkdetails g WHERE householdID = " + id + " AND h.gkkID = g.gkkID";
            MySqlDataAdapter da = new MySqlDataAdapter(loadHousehold, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("It does not exist.", "Not Exists");
            }
            else
            {
                
                showGKK.Text = dt.Rows[0][0] + "";
                showBarangay.Text = dt.Rows[0][1] + "";
                showDistrict.Text = dt.Rows[0][2] + "";
                detailsIncome.Text = dt.Rows[0][3] + "";
                detailsResidenceType.Text = dt.Rows[0][4] + "";
                detailsMaterials.Text = dt.Rows[0][5] + "";
                detailsLocation.Text = dt.Rows[0][6] + "";
                detailsProneToFlood.Text = dt.Rows[0][7] + "";
                detailsIfYesProne.Text = dt.Rows[0][8] + "";
                detailsMember.Text = dt.Rows[0][9] + "";
                detailsIfYesMember.Text = dt.Rows[0][10] + "";
                detailsIsAbleToHelp.Text = dt.Rows[0][11] + "";
                surveyor.Text = dt.Rows[0][12] + "";
                dateOfSurvey.Text = dt.Rows[0][13] + "";
                loadSelectedGKK(rID);

                if (detailsProneToFlood.SelectedIndex == 0)
                {
                    detailsIfYesProne.Visible = true;
                    detailsIfYesProneLabel.Visible = true;
                }
                else
                {
                    detailsIfYesProne.Visible = false;
                    detailsIfYesProneLabel.Visible = false;
                }

                if (detailsMember.SelectedIndex == 0)
                {
                    detailsIfYesMember.Visible = true;
                    detailsIfMemberLabel.Visible = true;
                }
                else
                {
                    detailsIfYesMember.Visible = false;
                    detailsIfMemberLabel.Visible = false;
                }


            
            }
        }




        private void loadSelectedGKK(string rID)
        {
            string id = "(SELECT householdID FROM respondent WHERE respondentID = '" + rID + "' AND hierarchy = 1)";
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadHousehold = "SELECT CONCAT(district, ' - ', gkkName, ' - ', address) as address From household, gkkdetails WHERE household.householdID = " + id + " AND gkkdetails.gkkID = household.gkkID";
            MySqlDataAdapter da = new MySqlDataAdapter(loadHousehold, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("It does not exist.", "Not Exists");
            }
            else
            {
                showAllGKK.Text = dt.Rows[0][0].ToString();
            }

               
        }
        //************************************************************************************* UPDATE METHODS

        private void updateHouseHold(string rid)
        {
            try
            {

                DataRowView drv = (DataRowView)showAllGKK.SelectedItem;
                string detinc = drv["gkkID"].ToString();
                string a = detailsMaterials.SelectedItem.ToString();
                string b = detinc;
                MySqlConnection myconn = new MySqlConnection(connString);
                string id = "(SELECT householdID FROM respondent WHERE respondentID = " + rid + " AND hierarchy = 1)";
                string queryHouseHold = "UPDATE household SET familyMonthlyIncome = '" + detailsIncome.SelectedItem.ToString() + 
                    "', houseOccupancy = '" + detailsResidenceType.SelectedItem.ToString() +
                    "', houseStructure = '" + detailsMaterials.SelectedItem.ToString() + 
                    "', residenceLocation = '" + detailsLocation.SelectedItem.ToString() + 
                   "', isFloodProne = '" + detailsProneToFlood.SelectedItem.ToString() +
                     "', preparation = '" + detailsProneToFlood.SelectedItem.ToString() +
                     "', isMemberGovOrg = '" + detailsMember.SelectedItem.ToString() + 
                    "', position = '" + detailsMember.SelectedItem.ToString() +
                     "', ifCanHelp = '" + detailsIsAbleToHelp.SelectedItem.ToString() + 
                     "', surveyor = '" + surveyor.Text + 
                     "', dateOfSurvey = '" + dateOfSurvey.Value.Date.ToString("yyyy-MM-dd") +
                    "', gkkID = '" + detinc + 
                    "'  WHERE householdID = " + id + "";
                MySqlCommand update = new MySqlCommand(queryHouseHold, myconn);
                MySqlDataReader rdr;
                myconn.Open();
                rdr = update.ExecuteReader();
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void updateDependents(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE respondent SET firstName = '"+dependentFirstName.Text+"', middleName = '"+dependentMiddleName.Text+"', lastName = '"+dependentLastName.Text+"', gender = '"+dependentGender.SelectedItem.ToString()+"', role = '"+dependentRelation.Text+"', ageDependent = '"+dependentAge.Text+"', grade = '"+dependentGrade.Text+"', school = '"+dependentSchool.Text+"', OSY = '"+dependentOSY.Text+"' WHERE respondentID = "+id+"";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
        }


        private void updateHusband(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE respondent SET firstName = '" + hFirstName.Text + "', middleName = '" + hMiddleName.Text + "', lastName = '" + hLastName.Text + "', nickName = '" + hNickName.Text + "', birthDate = '" + hBirthDate.Value.ToString("yyyy-MM-dd") + "', birthPlace = '" + hBirthPlace.Text + "', tribe = '" + hTribe.Text + "', employmentType = '" + ((hEmpStatus.SelectedItem == null) ? " " : hEmpStatus.SelectedItem.ToString()) + "', position = '" + hEmpPosition.Text + "', company = '" + hEmpCompany.Text + "', companyAddress = '" + hEmpCompAddress.Text + "', business = '" + hBusiness.Text + "', businessType = '" + hBusinessType.Text + "', contactNo = '" + hContactNum.Text + "', ageDependent = '" +(DateTime.Now.Year - hBirthDate.Value.Year) + "' WHERE respondentID = " + id + " ";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
        }

        private void updateWife(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            string query = "UPDATE respondent SET firstName = '" + wFirstName.Text + "', middleName = '" + wMiddleName.Text + "', lastName = '" + wLastName.Text + "', nickName = '" + wNickName.Text + "', birthDate = '" + wBirthDate.Value.ToString("yyyy-MM-dd") + "', birthPlace = '" + hBirthPlace.Text + "', tribe = '" + wTribe.Text + "', employmentType = '" + ((wEmpStatus.SelectedItem == null) ? " " : wEmpStatus.SelectedItem.ToString()) + "', position = '" + wEmpPosition.Text + "', company = '" + wEmpComp.Text + "', companyAddress = '" + wEmpCompAddress.Text + "', business = '" + wBusiness.Text + "', businessType = '" + wBusinessType.Text + "', contactNo = '" + wContactNum.Text + "', ageDependent = '" +(DateTime.Now.Year - wBirthDate.Value.Year)+"' WHERE respondentID = " + id + " ";
            MySqlCommand update = new MySqlCommand(query, myconn);
            MySqlDataReader rdr;
            myconn.Open();
            rdr = update.ExecuteReader();
            myconn.Close();
        }

        //************************************************************************************* loadHusband
        private void loadHusband(string id)
        {

            MySqlConnection myconn = new MySqlConnection(connString);
            string loadWife = "SELECT firstName, middleName, LastName, nickName, DATE_FORMAT(birthDate,'%M %d, %Y'), birthPlace, tribe, employmentType, position, company, companyAddress, business, businessType, contactNo FROM respondent WHERE respondentID = '" + id + "' AND hierarchy = 1 AND role = 'Husband'";
            MySqlDataAdapter da = new MySqlDataAdapter(loadWife, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {

            }
            else
            {
                hFirstName.Text = dt.Rows[0][0] + "";
                hMiddleName.Text = dt.Rows[0][1] + "";
                hLastName.Text = dt.Rows[0][2] + "";
                hNickName.Text = dt.Rows[0][3] + "";
                hBirthDate.Text = dt.Rows[0][4] + "";
                hBirthPlace.Text = dt.Rows[0][5] + "";
                hTribe.Text = dt.Rows[0][6] + "";
                hEmpStatus.Text = dt.Rows[0][7] + "";
                hEmpPosition.Text = dt.Rows[0][8] + "";
                hEmpCompany.Text = dt.Rows[0][9] + "";
                hEmpCompAddress.Text = dt.Rows[0][10] + "";
                hBusiness.Text = dt.Rows[0][11] + "";
                hBusinessType.Text = dt.Rows[0][12] + "";
                hContactNum.Text = dt.Rows[0][13] + "";

            }


        }


        //************************************************************************************* loadWife
        private void loadWife(string id)
        {

            MySqlConnection myconn = new MySqlConnection(connString);
            string loadWife = "SELECT firstName, middleName, LastName, nickName, DATE_FORMAT(birthDate,'%M %d, %Y'), birthPlace, tribe, employmentType, position, company, companyAddress, business, businessType, contactNo FROM respondent WHERE (respondentID = '" + id + "' AND role = 'Wife') OR (relatedTo ='" + id + "' AND hierarchy = 2 AND role = 'Wife')";
            MySqlDataAdapter da = new MySqlDataAdapter(loadWife, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {


            }
            else
            {
                wFirstName.Text = dt.Rows[0][0] + "";
                wMiddleName.Text = dt.Rows[0][1] + "";
                wLastName.Text = dt.Rows[0][2] + "";
                wNickName.Text = dt.Rows[0][3] + "";
                wBirthDate.Text = dt.Rows[0][4] + "";
                wBirthPlace.Text = dt.Rows[0][5] + "";
                wTribe.Text = dt.Rows[0][6] + "";
                wEmpStatus.Text = dt.Rows[0][7] + "";
                wEmpPosition.Text = dt.Rows[0][8] + "";
                wEmpComp.Text = dt.Rows[0][9] + "";
                wEmpCompAddress.Text = dt.Rows[0][10] + "";
                wBusiness.Text = dt.Rows[0][11] + "";
                wBusinessType.Text = dt.Rows[0][12] + "";
                wContactNum.Text = dt.Rows[0][13] + "";

            }


        }
        //************************************************************************************* loadDependents
        private void loadDependents(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt1 = new DataTable();
            string Display = "SELECT FIRSTNAME, MIDDLENAME, LASTNAME, GENDER, ROLE, ageDependent AS AGE, GRADE, SCHOOL, OSY, RESPONDENTID AS ID FROM respondent WHERE relatedTo = '" + id + "' AND hierarchy = 3";
            MySqlCommand mycommand = new MySqlCommand(Display, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dependentsGridView.DataSource = dt1;
            dependentsGridView.Columns["ID"].Visible = false;

        }
        //*************************************************************************************
        private void familyHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void saveProfile_Click_1(object sender, EventArgs e)
        {

            try
            {
                if ((hFirstName.Text == "" && hLastName.Text == "") && (wFirstName.Text == "" && wLastName.Text == ""))
                {
                    MessageBox.Show("Please Enter at least ONE Family Head");
                }
                else if (hFirstName.Text == "" && hLastName.Text == "")
                {
                    saveProfile.Visible = false;
                    updateProfile.Visible = true;
                    updateHouseHold(familyHead.SelectedValue.ToString());
                    updateWife(familyHead.SelectedValue.ToString());
                    clearAll();
                    MetroMessageBox.Show(this, "You have successfully updated the respondent details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    familyHead.Enabled = true;

                }
                else if (wFirstName.Text == "" && wLastName.Text == "")
                {
                    saveProfile.Visible = false;
                    updateProfile.Visible = true;
                    updateHouseHold(familyHead.SelectedValue.ToString());
                    updateHusband(familyHead.SelectedValue.ToString());
                    clearAll();
                    MetroMessageBox.Show(this, "You have successfully updated the respondent details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    familyHead.Enabled = true;
                }
                else
                {
                    int a = (Convert.ToInt32(familyHead.SelectedValue));
                    saveProfile.Visible = false;
                    updateProfile.Visible = true;
                    updateHouseHold(familyHead.SelectedValue.ToString());
                    updateHusband(familyHead.SelectedValue.ToString());
                    updateWife((a + 1).ToString());
                    clearAll();
                    MetroMessageBox.Show(this, "You have successfully updated the respondent details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    familyHead.Enabled = true;
                }

                loadComboBox();
            }
            catch(Exception ex){

            }











        }
        private void clearAll()
        {
            hFirstName.Text = "";
            hMiddleName.Text = "";
            hLastName.Text = "";
            hNickName.Text = "";
            hBirthDate.Text = "";
            hBirthPlace.Text = "";
            hTribe.Text = "";
            hEmpStatus.Text = "";
            hEmpPosition.Text = "";
            hEmpCompany.Text = "";
            hEmpCompAddress.Text = "";
            hBusiness.Text = "";
            hBusinessType.Text = "";
            hContactNum.Text = "";
            wFirstName.Text = "";
            wMiddleName.Text = "";
            wLastName.Text = "";
            wNickName.Text = "";
            wBirthDate.Text = "";
            wBirthPlace.Text = "";
            wTribe.Text = "";
            wEmpStatus.Text = "";
            wEmpPosition.Text = "";
            wEmpComp.Text = "";
            wEmpCompAddress.Text = "";
            wBusiness.Text = "";
            wBusinessType.Text = "";
            wContactNum.Text = "";
            showBarangay.Text = "";
            showDistrict.Text = "";
            showGKK.Text = "";
            detailsIncome.Text = "";
            detailsMaterials.Text = "";
            detailsResidenceType.Text = "";
            detailsLocation.Text = "";
            detailsIfYesProne.Text = "";
            detailsIfYesMember.Text = "";
            detailsProneToFlood.Text = "";
            detailsMember.Text = "";
            detailsIsAbleToHelp.Text = "";
            surveyor.Text = "";
            dateOfSurvey.Text = "";
            dependentsGridView.ClearSelection();

        }
        private void updateProfile_Click(object sender, EventArgs e)
        {
            familyHead.Enabled = false;
            try
            {
                clearAll();
                loadHousehold(familyHead.SelectedValue.ToString());
                loadDependents(familyHead.SelectedValue.ToString());
                loadHusband(familyHead.SelectedValue.ToString());
                loadWife(familyHead.SelectedValue.ToString());
                //loadSelectedGKK (gkkID);
                loadCivilStatus(familyHead.SelectedValue.ToString());
                modePanel.Visible = true;
                saveProfile.Visible = true;
                updateProfile.Visible = false;
                pageDivTile.BackColor = MetroFramework.MetroColors.Pink;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        string depID;
        private void dependentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dependentsGridView.Rows[i];
            dependentFirstName.Text = row.Cells[0].Value.ToString();
            dependentMiddleName.Text = row.Cells[1].Value.ToString();
            dependentLastName.Text = row.Cells[2].Value.ToString();
            dependentGender.Text = row.Cells[3].Value.ToString();
            dependentRelation.Text = row.Cells[4].Value.ToString();
            dependentAge.Text = row.Cells[5].Value.ToString();
            dependentGrade.Text = row.Cells[6].Value.ToString();
            dependentSchool.Text = row.Cells[7].Value.ToString();
            dependentOSY.Text = row.Cells[8].Value.ToString();
            depID = row.Cells[9].Value.ToString();

        }
        //************************************************************************************ UPDATE DEPENDENTS
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            updateDependents(depID);
            loadDependents(familyHead.SelectedValue.ToString());
        }



        //************************************************************************************ COMBOBOX EVENTS
      
        private void showGKK_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void showDistrict_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadGKK(showDistrict.SelectedItem.ToString());
            
        }

        private void showGKK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)showGKK.SelectedItem;
            gkkName = drv["gkkName"].ToString();
            loadAddress(gkkName, showDistrict.SelectedItem.ToString());
        }
    }
}
