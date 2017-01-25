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
    public partial class SurveyProfiling : MetroForm
    {
        public SurveyProfiling()
        {
            InitializeComponent();
        }

        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        long houseHoldID = 1;
        long respondentID = 1;  //DEFAULT FOR TRIAL ONLY BITCH
        long employeeID = 1;
        private void SurveyProfiling_Load(object sender, EventArgs e)
        {

            


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
                string dependent = "" + dependentFirstName.Text + "-" + dependentMiddleName.Text + "-" + dependentLastName.Text + "-" + dependentGender.SelectedItem.ToString() + "-" + dependentRelation.Text + "-" + dependentAge.Text + "-" + dependentSchool.Text + "-" + dependentGrade.Text + "-" + dependentSchool.Text + "-" + dependentOSY.Text;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            dependentsListbox.Items.Remove(dependentsListbox.SelectedItem);

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




        //************************************************************************************* INSERT HOUSEHOLD METHOD
        private void insertHousehold()
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertHousehold = connectMe.CreateCommand();

            insertHousehold.CommandText = "INSERT INTO household(familyMonthlyIncome, houseOccupancy, houseStructure, residenceLocation, isFloodProne, preparation, isMemberGovOrg, position, ifCanHelp) " +
                                            "VALUES(@income, @occupancy, @structure, @location, @floodprone, @preparation, @member, @position, @ifCanHelp)";
            insertHousehold.Parameters.AddWithValue("@income", detailsIncome.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@occupancy", detailsResidenceType.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@structure", detailsMaterials.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@location", detailsLocation.SelectedItem.ToString());
            insertHousehold.Parameters.AddWithValue("@floodprone", (detailsProneToFlood.SelectedIndex == 0) ? "yes" : "no");
            insertHousehold.Parameters.AddWithValue("@preparation", detailsIfYesProne.Text);
            insertHousehold.Parameters.AddWithValue("@member", (detailsMember.SelectedIndex == 0) ? "yes" : "no");
            insertHousehold.Parameters.AddWithValue("@position", detailsIfYesMember.Text);
            insertHousehold.Parameters.AddWithValue("@ifCanHelp", (detailsIsAbleToHelp.SelectedIndex == 0) ? "yes" : "no");
            insertHousehold.ExecuteNonQuery();
            houseHoldID = insertHousehold.LastInsertedId;
            connectMe.Close();

        }
        //************************************************************************************* INSERT ADDRESS METHOD
        private void insertAddress()
        {
            MySqlConnection connectMe = new MySqlConnection(connString);
            connectMe.Open();
            MySqlCommand insertAddress = connectMe.CreateCommand();
            insertAddress.CommandText = "INSERT INTO address(householdID, location, district, gkk, chapel, barangay, contactNumber) VALUES (@householdID, @loc, @dist, @gkk, @chap, @brgy, @contact)";
            insertAddress.Parameters.AddWithValue("@householdID", houseHoldID);
            insertAddress.Parameters.AddWithValue("@loc", location.Text);
            insertAddress.Parameters.AddWithValue("@dist", district.SelectedItem.ToString());
            insertAddress.Parameters.AddWithValue("@gkk", gkk.SelectedItem.ToString());
            insertAddress.Parameters.AddWithValue("@chap", chapel.SelectedItem.ToString());
            insertAddress.Parameters.AddWithValue("@brgy", barangay.Text);
            insertAddress.Parameters.AddWithValue("@contact", contactnum.Text);
            insertAddress.ExecuteNonQuery();
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
                   insertDependent.CommandText = "INSERT INTO respondent(employeeID, householdID, relatedTo, firstName, middleName, lastName, gender, isDependent, role, ageDependent, grade, school, osy, hierarchy) " +
                                                                            " VALUES (@employeeID, @houseID, @rel, @fn, @mn, @ln, @gen, @isDep, @role, @ageDep, @grade, @school, @osy, @hierarchy)";
                   string[] dep = item.ToString().Split('-');
                   insertDependent.Parameters.AddWithValue("@employeeID", employeeID);
                   insertDependent.Parameters.AddWithValue("@houseID", houseHoldID);
                   insertDependent.Parameters.AddWithValue("@rel", respondentID);
                   insertDependent.Parameters.AddWithValue("@fn", dep[0]);
                   insertDependent.Parameters.AddWithValue("@mn", dep[1]);
                   insertDependent.Parameters.AddWithValue("@ln", dep[2]);
                   insertDependent.Parameters.AddWithValue("@gen", dep[3]);
                   insertDependent.Parameters.AddWithValue("@isDep", "true");
                   insertDependent.Parameters.AddWithValue("@role", dep[4]);
                   insertDependent.Parameters.AddWithValue("@ageDep", dep[5]);
                   insertDependent.Parameters.AddWithValue("@grade", dep[6]);
                   insertDependent.Parameters.AddWithValue("@school", dep[7]);
                   insertDependent.Parameters.AddWithValue("@osy", dep[8]);
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
        private void insertHusband(int Hierarchy)
        {

            try
            {
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertHusband = connectMe.CreateCommand();
                insertHusband.CommandText = "INSERT INTO respondent(householdID, relatedTo, hierarchy, firstName, middleName, lastName, gender, isDependent, role, nickName, birthPlace, birthDate, tribe, employmentType, company, companyAddress, position, business, businessType, contactNo, marriageType, civilStatus, employeeID) " +
                                                                                " VALUES (@householdID, @relatedTo, @hierarchy, @fn, @mn, @ln, @gender, @isDependent, @role, @nickName, @birthPlace, @birthDate, @tribe, @empType, @company, @companyAddress, @pos, @business, @businessType, @contactNo, @marriageType, @civilStatus, @empID)";
                insertHusband.Parameters.AddWithValue("@householdID", houseHoldID);
                insertHusband.Parameters.AddWithValue("@relatedTo", 0);
                insertHusband.Parameters.AddWithValue("@hierarchy", Hierarchy);
                insertHusband.Parameters.AddWithValue("@fn", hFirstName.Text);
                insertHusband.Parameters.AddWithValue("@mn", hMiddleName.Text);
                insertHusband.Parameters.AddWithValue("@ln", hLastName.Text);
                insertHusband.Parameters.AddWithValue("@gender", "Male");
                insertHusband.Parameters.AddWithValue("@isDependent", "false");
                insertHusband.Parameters.AddWithValue("@role", "Family Head");
                insertHusband.Parameters.AddWithValue("@nickName", hNickName.Text);
                insertHusband.Parameters.AddWithValue("@birthPlace", hBirthPlace.Text);
                insertHusband.Parameters.AddWithValue("@birthDate", hBirthDate.Value.Date.ToString("yyyy-MM-dd"));
                insertHusband.Parameters.AddWithValue("@tribe", hTribe.Text);
                insertHusband.Parameters.AddWithValue("@empType", hEmpStatus.SelectedItem.ToString());
                insertHusband.Parameters.AddWithValue("@company", hEmpCompany.Text);
                insertHusband.Parameters.AddWithValue("@companyAddress", hEmpCompAddress.Text);
                insertHusband.Parameters.AddWithValue("@pos", hEmpPosition.Text);
                insertHusband.Parameters.AddWithValue("@business", hBusiness.Text);
                insertHusband.Parameters.AddWithValue("@businessType", hBusinessType.Text);
                insertHusband.Parameters.AddWithValue("@contactNo", hContactNum.Text);
                insertHusband.Parameters.AddWithValue("@marriageType", marriedType.SelectedItem.ToString());
                insertHusband.Parameters.AddWithValue("@civilStatus", civilStatus.SelectedItem.ToString());
                insertHusband.Parameters.AddWithValue("@empID", employeeID);
                insertHusband.ExecuteNonQuery();
                connectMe.Close();
           }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //************************************************************************************* 




        //************************************************************************************* INSERT WIFE METHOD
        private void insertWife(int Hierarchy)
        {

          try
            {
                MySqlConnection connectMe = new MySqlConnection(connString);
                connectMe.Open();
                MySqlCommand insertWife = connectMe.CreateCommand();
                insertWife.CommandText = "INSERT INTO respondent(householdID, relatedTo, hierarchy, firstName, middleName, lastName, gender, isDependent, role, nickName, birthPlace, birthDate, tribe, employmentType, company, companyAddress, position, business, businessType, contactNo, marriageType, civilStatus, employeeID) " +
                                                                                " VALUES (@householdID, @relatedTo, @hierarchy, @fn, @mn, @ln, @gender, @isDependent, @role, @nickName, @birthPlace, @birthDate, @tribe, @empType, @company, @companyAddress, @pos, @business, @businessType, @contactNo, @marriageType, @civilStatus, @empID)";
                insertWife.Parameters.AddWithValue("@householdID", houseHoldID);
                insertWife.Parameters.AddWithValue("@relatedTo", 0); // update this
                insertWife.Parameters.AddWithValue("@hierarchy", Hierarchy);
                insertWife.Parameters.AddWithValue("@fn", wFirstName.Text);
                insertWife.Parameters.AddWithValue("@mn", wMiddleName.Text);
                insertWife.Parameters.AddWithValue("@ln", wLastName.Text);
                insertWife.Parameters.AddWithValue("@gender", "Female");
                insertWife.Parameters.AddWithValue("@isDependent", "false");
                insertWife.Parameters.AddWithValue("@role", "Wife");
                insertWife.Parameters.AddWithValue("@nickName", wNickName.Text);
                insertWife.Parameters.AddWithValue("@birthPlace", wBirthPlace.Text);
                insertWife.Parameters.AddWithValue("@birthDate", wBirthDate.Value.Date.ToString("yyyy-MM-dd"));
                insertWife.Parameters.AddWithValue("@tribe", wTribe.Text);
                insertWife.Parameters.AddWithValue("@empType", wEmpStatus.SelectedItem.ToString());
                insertWife.Parameters.AddWithValue("@company", wEmpComp.Text);
                insertWife.Parameters.AddWithValue("@companyAddress", wEmpCompAddress.Text);
                insertWife.Parameters.AddWithValue("@pos", wEmpPosition.Text);
                insertWife.Parameters.AddWithValue("@business", wBusiness.Text);
                insertWife.Parameters.AddWithValue("@businessType", wBusinessType.Text);
                insertWife.Parameters.AddWithValue("@contactNo", wContactNum.Text);
                insertWife.Parameters.AddWithValue("@marriageType", marriedType.SelectedItem.ToString());
                insertWife.Parameters.AddWithValue("@civilStatus", civilStatus.SelectedItem.ToString());
                insertWife.Parameters.AddWithValue("@empID", employeeID);
                insertWife.ExecuteNonQuery();
                connectMe.Close();
           }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        //************************************************************************************* 


        //************************************************************************************* SAVE BUTTON
        private void metroTile1_Click(object sender, EventArgs e)
        {
            insertHousehold();
            insertAddress();
            insertHusband(1);
            insertWife(2);
            insertDependent();
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
            this.Hide();
            ProfileGridView view = new ProfileGridView();
            view.Show();
        }

        //************************************************************************************* COMBO BOX
    }
}
