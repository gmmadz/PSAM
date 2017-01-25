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
    public partial class SurveyStatisticalFormat : MetroForm
    {
        public SurveyStatisticalFormat()
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
        private void SurveyStatisticalFormat_Load(object sender, EventArgs e)
        {
            loadGKK();
            loadYear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.Fill(this.ProfilingSubsystem.DataTable1, Int32.Parse(gkk.SelectedValue.ToString()));
                this.materialsUsedTableAdapter.Fill(this.ProfilingSubsystem.materialsUsed, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                this.residenceLocationTableAdapter.Fill(this.ProfilingSubsystem.residenceLocation, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                this.isFloodProneTableAdapter.Fill(this.ProfilingSubsystem.isFloodProne, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                this.isMemTableAdapter.Fill(this.ProfilingSubsystem.isMem, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                this.householdHouseOccupancyTableAdapter.Fill(this.ProfilingSubsystem.householdHouseOccupancy, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                this.householdMonthlyIncomeChartTableAdapter.Fill(this.ProfilingSubsystem.householdMonthlyIncomeChart, Int32.Parse(gkk.SelectedValue.ToString()), Int32.Parse(surveyYear.SelectedValue.ToString()));
                this.reportViewer1.RefreshReport();
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please try again. Exception: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
    }
}
