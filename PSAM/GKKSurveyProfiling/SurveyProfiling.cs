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
    public partial class SurveyProfiling : MetroForm
    {
        public SurveyProfiling()
        {
            InitializeComponent();
        }

        
        long houseHoldID;
        long respondentID;  //DEFAULT FOR TRIAL ONLY BITCH
        long employeeID = 1;
        string gkkID;
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        private void loadGKK(string dist)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT gkkName FROM gkkdetails WHERE district = '"+dist+"'";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gkk.DataSource = dt;
            gkk.DisplayMember = "gkkName";
        }

        private void loadAddress(string gkk, string dist)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT address FROM gkkdetails WHERE gkkName = '" + gkk + "' AND district = '" + dist + "'";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            barangay.DataSource = dt;
            barangay.DisplayMember = "address";
        }


        private void loadComboBox()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string emp = "SELECT employeeID, CONCAT(firstName, ' ', middleName, ' ', lastName) as name FROM employee where username != 'gmmadz'";
            MySqlCommand mycommand = new MySqlCommand(emp, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            surveyor.DataSource = dt;
            surveyor.DisplayMember = "name";
            surveyor.ValueMember = "employeeID";
        }

        private void SurveyProfiling_Load(object sender, EventArgs e)
        {
            numOfDependents.Text = dependentsListbox.Items.Count.ToString();
            loadComboBox();
        }

        private void metroLabel37_Click(object sender, EventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }
        //************************************************************************************* DEPENDENTS SECTION
        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if(dependentFirstName.Text == "" || dependentLastName.Text == "" || dependentGender.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please enter complete detailes of dependents", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string dependent = "" + dependentFirstName.Text + "/" + dependentMiddleName.Text + "/" + dependentLastName.Text + "/" + dependentGender.SelectedItem.ToString() + "/" + dependentRelation.Text + "/" + depBday.Value.Date.ToString("yyyy-MM-dd") + "/"+ dependentAge.Text + "/" + dependentGrade.SelectedItem.ToString() + "/" + dependentSchool.Text + "/" + dependentOSY.Text;
                    dependentsListbox.Items.Add(dependent);
                    dependentFirstName.Text = "";
                    dependentMiddleName.Text = "";
                    dependentLastName.Text = "";
                    dependentGender.Text = "";
                    dependentRelation.Text = "";
                    dependentGrade.Text = "";
                    dependentOSY.Text = "";
                    dependentSchool.Text = "";
                    dependentAge.Text = "";
                    numOfDependents.Text = dependentsListbox.Items.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            dependentsListbox.Items.Remove(dependentsListbox.SelectedItem);
            numOfDependents.Text = dependentsListbox.Items.Count.ToString();

        }
        //************************************************************************************* DEPENDENTS SECTION

        private void dependentAge_Click(object sender, EventArgs e)
        {
             
        }

        private void metroPanel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string getGKKID()
        {
            DataRowView drv1 = (DataRowView)gkk.SelectedItem;
            string gk= drv1["gkkName"].ToString();
            DataRowView drv2 = (DataRowView)barangay.SelectedItem;
            string add = drv2["address"].ToString();
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadGKKID = "SELECT gkkID from gkkdetails WHERE district = '"+district.SelectedItem.ToString()+"' AND gkkName = '"+gk+"' AND address = '"+add+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(loadGKKID, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt.Rows[0][0] + "";
               
            }
        }

        //************************************************************************************* INSERT HOUSEHOLD METHOD
        private void insertHousehold()
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertHousehold = connectMe.CreateCommand();
            DataRowView drv = (DataRowView)surveyor.SelectedItem;
            string surveyorName = drv["name"].ToString();
            insertHousehold.CommandText = "INSERT INTO household(gkkID, familyMonthlyIncome, houseOccupancy, houseStructure, residenceLocation, isFloodProne, preparation, isMemberGovOrg, position, ifCanHelp, surveyor, dateOfSurvey) " +
                                            "VALUES(@gkkID, @income, @occupancy, @structure, @location, @floodprone, @preparation, @member, @position, @ifCanHelp, @surveyor, @dateOfSurvey)";
            insertHousehold.Parameters.AddWithValue("@gkkID", getGKKID());
            insertHousehold.Parameters.AddWithValue("@income", detailsIncome.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@occupancy", detailsResidenceType.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@structure", detailsMaterials.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@location", detailsLocation.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@floodprone", (detailsProneToFlood.SelectedIndex == 0) ? "yes" : "no");
            insertHousehold.Parameters.AddWithValue("@preparation", detailsIfYesProne.Text);
            insertHousehold.Parameters.AddWithValue("@member", (detailsMember.SelectedIndex == 0) ? "yes" : "no");
            insertHousehold.Parameters.AddWithValue("@position", detailsIfYesMember.Text);
            insertHousehold.Parameters.AddWithValue("@ifCanHelp", (detailsIsAbleToHelp.SelectedIndex == 0) ? "yes" : "no");
            insertHousehold.Parameters.AddWithValue("@surveyor", surveyorName);
            insertHousehold.Parameters.AddWithValue("@dateOfSurvey", dateOfSurvey.Value.Date.ToString("yyyy-MM-dd"));
            insertHousehold.ExecuteNonQuery();
            houseHoldID = insertHousehold.LastInsertedId;
            connectMe.Close();

        }
      
        //************************************************************************************* INSERT DEPENDENT METHOD
        private void insertDependent()
        {
            foreach (var item in dependentsListbox.Items)
                {
                   MySqlConnection connectMe = new MySqlConnection(connString);
                   connectMe.Open();
                   MySqlCommand insertDependent = connectMe.CreateCommand();
                   insertDependent.CommandText = "INSERT INTO respondent(employeeID, householdID, relatedTo, firstName, middleName, lastName, gender, role, birthDate, ageDependent, grade, school, osy, hierarchy) " +
                                                                            " VALUES (@employeeID, @houseID, @rel, @fn, @mn, @ln, @gen, @role, @bday, @ageDep, @grade, @school, @osy, @hierarchy)";
                   string[] dep = item.ToString().Split('/');
                   insertDependent.Parameters.AddWithValue("@employeeID", employeeID);
                   insertDependent.Parameters.AddWithValue("@houseID", houseHoldID);
                   insertDependent.Parameters.AddWithValue("@rel", respondentID);
                   insertDependent.Parameters.AddWithValue("@fn", dep[0]);
                   insertDependent.Parameters.AddWithValue("@mn", dep[1]);
                   insertDependent.Parameters.AddWithValue("@ln", dep[2]);
                   insertDependent.Parameters.AddWithValue("@gen", dep[3]);
                   insertDependent.Parameters.AddWithValue("@role", dep[4]);
                   insertDependent.Parameters.AddWithValue("@bday", dep[5]);
                   insertDependent.Parameters.AddWithValue("@ageDep", dep[6]);
                   insertDependent.Parameters.AddWithValue("@grade", dep[7]);
                   insertDependent.Parameters.AddWithValue("@school", dep[8]);
                   insertDependent.Parameters.AddWithValue("@osy", dep[9]);
                   insertDependent.Parameters.AddWithValue("@hierarchy", 3);
                   insertDependent.ExecuteNonQuery();
                   connectMe.Close();
                }

            
        }



        // FOR HIERARCHY GUIDELINES
        // 1 FOR HEAD (HUSBAND) OR (WIFE IF SINGLE)
        // 2 FOR SUB-HEAD (WIFE)
        // 3 FOR DEPENDENTS

        //************************************************************************************* INSERT HUSBAND METHOD
        private void insertHusband(string Hierarchy)
        {

         
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertHusband = connectMe.CreateCommand();
                insertHusband.CommandText = "INSERT INTO respondent(householdID, relatedTo, hierarchy, firstName, middleName, lastName, gender, role, nickName, birthPlace, birthDate, tribe, employmentType, company, companyAddress, position, business, businessType, contactNo, marriageType, civilStatus, ageDependent) " +
                                                                                " VALUES (@householdID, @relatedTo, @hierarchy, @fn, @mn, @ln, @gender, @role, @nickName, @birthPlace, @birthDate, @tribe, @empType, @company, @companyAddress, @pos, @business, @businessType, @contactNo, @marriageType, @civilStatus, @age)";
                insertHusband.Parameters.AddWithValue("@householdID", houseHoldID);
                insertHusband.Parameters.AddWithValue("@relatedTo", 0);
                insertHusband.Parameters.AddWithValue("@hierarchy", Hierarchy);
                insertHusband.Parameters.AddWithValue("@fn", hFirstName.Text);
                insertHusband.Parameters.AddWithValue("@mn", hMiddleName.Text);
                insertHusband.Parameters.AddWithValue("@ln", hLastName.Text);
                insertHusband.Parameters.AddWithValue("@gender", "Male");
                insertHusband.Parameters.AddWithValue("@role", "Husband");
                insertHusband.Parameters.AddWithValue("@nickName", hNickName.Text);
                insertHusband.Parameters.AddWithValue("@birthPlace", hBirthPlace.Text);
                insertHusband.Parameters.AddWithValue("@birthDate", hBirthDate.Value.Date.ToString("yyyy-MM-dd"));
                insertHusband.Parameters.AddWithValue("@tribe", hTribe.Text);
                insertHusband.Parameters.AddWithValue("@empType", (hEmpStatus.SelectedItem == null)?" ": hEmpStatus.SelectedItem.ToString());
                insertHusband.Parameters.AddWithValue("@company", hEmpCompany.Text);
                insertHusband.Parameters.AddWithValue("@companyAddress", hEmpCompAddress.Text);
                insertHusband.Parameters.AddWithValue("@pos", hEmpPosition.Text);
                insertHusband.Parameters.AddWithValue("@business", hBusiness.Text);
                insertHusband.Parameters.AddWithValue("@businessType", hBusinessType.Text);
                insertHusband.Parameters.AddWithValue("@contactNo", hContactNum.Text);
                insertHusband.Parameters.AddWithValue("@marriageType", marriedType.SelectedItem.ToString());
                insertHusband.Parameters.AddWithValue("@civilStatus", civilStatus.SelectedItem.ToString());
                insertHusband.Parameters.AddWithValue("@age", DateTime.Now.Year - hBirthDate.Value.Year);
                insertHusband.ExecuteNonQuery();
                respondentID = insertHusband.LastInsertedId;
                connectMe.Close();
          
        }

        //************************************************************************************* 




        //************************************************************************************* INSERT WIFE METHOD
        private void insertWife(string Hierarchy)
        {

         
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertWife = connectMe.CreateCommand();
                insertWife.CommandText = "INSERT INTO respondent(householdID, relatedTo, hierarchy, firstName, middleName, lastName, gender, role, nickName, birthPlace, birthDate, tribe, employmentType, company, companyAddress, position, business, businessType, contactNo, marriageType, civilStatus, ageDependent) " +
                                                                                " VALUES (@householdID, @relatedTo, @hierarchy, @fn, @mn, @ln, @gender, @role, @nickName, @birthPlace, @birthDate, @tribe, @empType, @company, @companyAddress, @pos, @business, @businessType, @contactNo, @marriageType, @civilStatus, @age)";
                insertWife.Parameters.AddWithValue("@householdID", houseHoldID);
                insertWife.Parameters.AddWithValue("@relatedTo", (hLastName.Text=="" && hFirstName.Text =="")?0:respondentID); // update this
                insertWife.Parameters.AddWithValue("@hierarchy", Hierarchy);
                insertWife.Parameters.AddWithValue("@fn", wFirstName.Text);
                insertWife.Parameters.AddWithValue("@mn", wMiddleName.Text);
                insertWife.Parameters.AddWithValue("@ln", wLastName.Text);
                insertWife.Parameters.AddWithValue("@gender", "Female");
                insertWife.Parameters.AddWithValue("@role", "Wife");
                insertWife.Parameters.AddWithValue("@nickName", wNickName.Text);
                insertWife.Parameters.AddWithValue("@birthPlace", wBirthPlace.Text);
                insertWife.Parameters.AddWithValue("@birthDate", wBirthDate.Value.Date.ToString("yyyy-MM-dd"));
                insertWife.Parameters.AddWithValue("@tribe", wTribe.Text);
                insertWife.Parameters.AddWithValue("@empType", (wEmpStatus.SelectedItem == null)? " ": wEmpStatus.SelectedItem.ToString());
                insertWife.Parameters.AddWithValue("@company", wEmpComp.Text);
                insertWife.Parameters.AddWithValue("@companyAddress", wEmpCompAddress.Text);
                insertWife.Parameters.AddWithValue("@pos", wEmpPosition.Text);
                insertWife.Parameters.AddWithValue("@business", wBusiness.Text);
                insertWife.Parameters.AddWithValue("@businessType", wBusinessType.Text);
                insertWife.Parameters.AddWithValue("@contactNo", wContactNum.Text);
                insertWife.Parameters.AddWithValue("@marriageType", marriedType.SelectedItem.ToString());
                insertWife.Parameters.AddWithValue("@civilStatus", civilStatus.SelectedItem.ToString());
                insertWife.Parameters.AddWithValue("@age", DateTime.Now.Year - wBirthDate.Value.Year);
                insertWife.ExecuteNonQuery();
                
               if (Hierarchy == "1")
               {
                   respondentID = insertWife.LastInsertedId;
               }
                connectMe.Close();
         
        }
        //************************************************************************************* 

        private void clearAll()
        {
            hFirstName.Text = "";
            hMiddleName.Text = "";
            hLastName.Text = "";
            hNickName.Text = "";
            hContactNum.Text = "";
            wContactNum.Text = "";
            wFirstName.Text = "";
            wMiddleName.Text = "";
            wLastName.Text = "";
            wNickName.Text = "";
            numOfDependents.Text = "0";
            dependentFirstName.Text = "";
            dependentMiddleName.Text = "";
            dependentLastName.Text = "";
            dependentGender.Text = "";
            dependentRelation.Text = "";
            dependentGrade.Text = "";
            dependentOSY.Text = "";
            dependentSchool.Text = "";
            dependentAge.Text = "";
            dependentsListbox.Items.Clear();
        }
        //************************************************************************************* SAVE BUTTON
        private void metroTile1_Click(object sender, EventArgs e)
        {

            if(district.SelectedIndex == -1 || gkk.SelectedIndex == -1 || barangay.SelectedIndex == -1 || marriedType.SelectedIndex== -1 || civilStatus.SelectedIndex == -1 || detailsIncome.SelectedIndex == -1 || detailsResidenceType.SelectedIndex == -1 || detailsMaterials.SelectedIndex == -1 || detailsLocation.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Please fill up the required (*) details!", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
            else if ((hFirstName.Text == "" && hLastName.Text == "") && (wFirstName.Text == "" && wLastName.Text == ""))
            {
                MetroMessageBox.Show(this, "There should be at least one (1) Family Head.", "No Family Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
            else if (hFirstName.Text == "" && hLastName.Text == "" )
            {
                try
                {
                    insertHousehold();
                    insertWife("1");
                    insertDependent();
                    MetroMessageBox.Show(this, "You have successfully added the respondent details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Please try again. Exception: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
                }
           }
            else if (wFirstName.Text == "" && wLastName.Text == "" )
          {
              
                try
                {
                    insertHousehold();
                    insertHusband("1");
                    insertDependent();
                    MetroMessageBox.Show(this, "You have successfully added the respondent details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Please try again. Exception: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
                }
            }
            else
            {
                try
                {
                    insertHousehold();
                    insertHusband("1");
                    insertWife("2");
                    insertDependent();
                    MetroMessageBox.Show(this, "You have successfully added the respondent details.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Please try again. Exception: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
                }
                    
                
            }
          
          respondentID = 0;
        }
        //************************************************************************************* SAVE BUTTON







        //************************************************************************************* COMBO BOX
        private void metroComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void detailsMember_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ProfileGridView view = new ProfileGridView();
            this.Hide();
            view.Show();
        }

        private void hContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }
        }

        private void metroPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void district_SelectedValueChanged(object sender, EventArgs e)
        {
            loadGKK(district.SelectedItem.ToString());
        }

        private void gkk_DisplayMemberChanged(object sender, EventArgs e)
        {
         //   loadAddress(gkk.SelectedItem.ToString(), district.SelectedItem.ToString());
        }

        string gkkName;
        string brgy;
        private void gkk_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gkk.SelectedItem;
                gkkName = drv["gkkName"].ToString();
                loadAddress(gkkName, district.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please try again." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }

        }

        private void barangay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)barangay.SelectedItem;
                brgy = drv["address"].ToString();
                gkkID = "(SELECT gkkID FROM gkkdetails WHERE district = '" + district.SelectedItem.ToString() + "' AND gkkName = '" + gkkName + "' AND address = '" + brgy + "')";
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void gkk_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dependentAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }
        }

        private void wContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }
        }

        private void hContactNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && char.IsLetter(key))
            {
                e.KeyChar = '\0';
            }
        }

        private void metroPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            dependentAge.Text = ((DateTime.Now.Year - depBday.Value.Year) < 1 ? 1 : (DateTime.Now.Year - depBday.Value.Year)).ToString();
        }

        //************************************************************************************* COMBO BOX
    }
}
