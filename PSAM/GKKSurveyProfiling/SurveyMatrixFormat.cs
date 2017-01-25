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
    public partial class SurveyMatrixFormat : MetroForm
    {
        public SurveyMatrixFormat()
        {
            InitializeComponent();
        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        private void loadGKK()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT gkkID, CONCAT(district, ' - ',gkkName, ' - ', address) AS 'gkkName' FROM gkkdetails ORDER BY gkkID ASC";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            gkk.DataSource = dt;
            gkk.DisplayMember = "gkkName";
            gkk.ValueMember = "gkkID";
        }

        private void loadYear()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT year(dateOfSurvey) AS yearSurvey FROM household ORDER BY dateOfSurvey DESC";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            surveyYear.DataSource = dt;
            surveyYear.DisplayMember = "yearSurvey";
            surveyYear.ValueMember = "yearSurvey";
        }

        private void SurveyMatrixFormat_Load(object sender, EventArgs e)
        {
                      
           loadGKK();
           loadYear();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.SelectedIndex == 0) // viewAll
                {
                    this.MatrixTableAdapter.Fill(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                }
                else if (comboBox1.SelectedIndex == 1) // houseStructure
                {
                    this.MatrixTableAdapter.FillByHS(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), houseStructure.SelectedItem.ToString());
                }
                else if (comboBox1.SelectedIndex == 2) // houseOccupancy
                {
                    this.MatrixTableAdapter.FillBy(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), houseOccupancy.SelectedItem.ToString());
                }
                else if (comboBox1.SelectedIndex == 3) // residenceLocation
                {
                    this.MatrixTableAdapter.FillByRL(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), residenceLocation.SelectedItem.ToString());
                }
                else if (comboBox1.SelectedIndex == 4) // monthlyIncome
                {
                    this.MatrixTableAdapter.monthlyIncome(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), monthlyIncome.SelectedItem.ToString());
                }
                else if (comboBox1.SelectedIndex == 5) //ismember
                {
                    this.MatrixTableAdapter.isMemberGovOrg(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), isMemberGovOrg.SelectedItem.ToString());
                }
                else if (comboBox1.SelectedIndex == 6)//if Can Help
                {
                    this.MatrixTableAdapter.ifCanHelp(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), ifCanHelpCombo.SelectedItem.ToString());
                }
                else if (comboBox1.SelectedIndex == 7)//flood prone
                {
                    this.MatrixTableAdapter.isFloodProne(this.ProfilingSubsystem.Matrix, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()), floodProne.SelectedItem.ToString());
                }
                this.DataTable1TableAdapter.Fill(this.ProfilingSubsystem.DataTable1, Int32.Parse(gkk.SelectedValue.ToString()));
                this.reportViewer1.RefreshReport();
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "An error occured. Please try again. Exception: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gkk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void surveyYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // viewAll
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = false;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1) // houseStructure
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = true;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2) // houseOccupancy
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = false;
                houseOccupancy.Visible = true;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3) // residenceLocation
            {
                residenceLocation.Visible = true;
                houseStructure.Visible = false;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4) //monthlyIncome
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = false;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = true;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 5) //isMemberGovOrg
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = false;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = true;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 6) // ifCanHelp
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = false;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = true;
                floodProne.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 7) //floodProne
            {
                residenceLocation.Visible = false;
                houseStructure.Visible = false;
                houseOccupancy.Visible = false;
                monthlyIncome.Visible = false;
                isMemberGovOrg.Visible = false;
                ifCanHelpCombo.Visible = false;
                floodProne.Visible = true;
            }
        }
    }
}
