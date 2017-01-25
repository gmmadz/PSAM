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
    public partial class ProfileGridView : MetroForm
    {
        public ProfileGridView()
        {
            InitializeComponent();
        }


        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING

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
            string loadDataCivil = "SELECT civilStatus, marriageType FROM respondent WHERE respondentID = '"+rID+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(loadDataCivil, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("It does not exist.", "Not Exists");
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
            string id = "(SELECT householdID FROM respondent WHERE respondentID = '"+rID+"' AND hierarchy = 1)";
            MySqlConnection myconn = new MySqlConnection(connString);
            string loadHousehold = "SELECT g.gkkName, g.address, g.district, h.familyMonthlyIncome, h.houseOccupancy, h.houseStructure, h.residenceLocation, h.isFloodProne, h.preparation, h.isMemberGovOrg, h.position, h.ifCanHelp, h.surveyor, h.dateOfSurvey FROM household h, gkkdetails g WHERE householdID = "+id+" AND h.gkkID = g.gkkID";
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
                surveyor.Text = dt.Rows[0][12] + "";;
                dateOfSurvey.Text = dt.Rows[0][13] + ""; ;
                 
                   

            }
        }
        
        //************************************************************************************* loadHusband
        private void loadHusband(string id){

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
                hFirstName.Text = dt.Rows[0][0]+ "";
                hMiddleName.Text = dt.Rows[0][1] + "";
                hLastName.Text = dt.Rows[0][2] + "";
                hNickName.Text = dt.Rows[0][3] + "";
                hBirthDate.Text = dt.Rows[0][4] + "";
                hBirthPlace.Text = dt.Rows[0][5] + "";
                hTribe.Text = dt.Rows[0][6] + "";
                hEmpStatus.Text = dt.Rows[0][7] + "";
                hPosition.Text = dt.Rows[0][8] + "";
                hCompany.Text = dt.Rows[0][9] + "";
                hCompAddress.Text = dt.Rows[0][10] + "";
                hBusiness.Text = dt.Rows[0][11] + "";
                hBusinessType.Text = dt.Rows[0][12] + "";
                hContactNumber.Text = dt.Rows[0][13] + "";

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
                wPosition.Text = dt.Rows[0][8] + "";
                wCompany.Text = dt.Rows[0][9] + "";
                wCompAddress.Text = dt.Rows[0][10] + "";
                wBusiness.Text = dt.Rows[0][11] + "";
                wBusinessType.Text = dt.Rows[0][12] + "";
                wContactNumber.Text = dt.Rows[0][13] + "";

            }


        }
        //************************************************************************************* loadDependents
        private void loadDependents(string id)
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt1 = new DataTable();
            string Display = "SELECT FIRSTNAME, MIDDLENAME, LASTNAME, GENDER, ROLE, ageDependent AS AGE, GRADE, SCHOOL, OSY FROM respondent WHERE relatedTo = '"+id+"' AND hierarchy = 3";
            MySqlCommand mycommand = new MySqlCommand(Display, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dependentsGridView.DataSource = dt1;


        }
        //*************************************************************************************
        private void ProfileGridView_Load(object sender, EventArgs e)
        {
            loadComboBox();
            modePanel.Visible = false;
            pageDivTile.BackColor = MetroFramework.MetroColors.Silver;

        }
        //*************************************************************************************

        private void familyHead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   
    
        //************************************************************************************* VIEW PROFILE BUTTON
        private void viewProfile_Click(object sender, EventArgs e)
        {
            try
            {

                clearAll();
                loadHousehold(familyHead.SelectedValue.ToString());
                loadDependents(familyHead.SelectedValue.ToString());
                loadHusband(familyHead.SelectedValue.ToString());
                loadWife(familyHead.SelectedValue.ToString());
                loadCivilStatus(familyHead.SelectedValue.ToString());
              
             
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        //************************************************************************************* SAVE PROFILE BUTTON
 
      

        private void clearAll()
        {
                hFirstName.Text =  "";
                hMiddleName.Text = "";
                hLastName.Text = "";
                hNickName.Text = "";
                hBirthDate.Text = "";
                hBirthPlace.Text = "";
                hTribe.Text = "";
                hEmpStatus.Text = "";
                hPosition.Text = "";
                hCompany.Text = "";
                hCompAddress.Text = "";
                hBusiness.Text = "";
                hBusinessType.Text = "";
                hContactNumber.Text = "";
                wFirstName.Text = "";
                wMiddleName.Text = "";
                wLastName.Text = "";
                wNickName.Text = "";
                wBirthDate.Text = "";
                wBirthPlace.Text = "";
                wTribe.Text = "";
                wEmpStatus.Text = "";
                wPosition.Text = "";
                wCompany.Text = "";
                wCompAddress.Text = "";
                wBusiness.Text = "";
                wBusinessType.Text = "";
                wContactNumber.Text = "";
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
                dependentsGridView.ClearSelection();
                
        }









        //END END END END END END END END END END ENDEND END END END ENDEND END END END ENDEND END END END ENDEND END END END END
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
























        private void modePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pageDiv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pageDivTile_Click(object sender, EventArgs e)
        {
        }

        private void detailsProneToFlood_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
     

    }
}
