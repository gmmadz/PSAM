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
    public partial class SurveyGenderDisaggregatedDataReport : MetroForm
    {
        public SurveyGenderDisaggregatedDataReport()
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

        

        private void SurveyGenderDisaggregatedDataReport_Load(object sender, EventArgs e)
        {
            loadGKK();
            loadYear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void gkk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gkk.SelectedItem;
                int id = Int32.Parse(drv["gkkID"].ToString());
                int year = Int32.Parse(surveyYear.SelectedValue.ToString());
                this.DataTable1TableAdapter.Fill(this.ProfilingSubsystem.DataTable1, id);
                this.MaleInfantsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleInfants, id, year);
                this.FemaleInfantsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleInfants, id, year);
                this.MaleToddlersTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleToddlers, id, year);
                this.FemaleToddlersTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleToddlers, id, year);
                this.MalePreschoolersTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MalePreschoolers, id, year);
                this.FemalePreschoolersTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemalePreschoolers, id, year);
                this.MaleGradeSchoolersTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleGradeSchoolers, id, year);
                this.FemaleGradeSchoolersTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleGradeSchoolers, id, year);
                this.MaleYouthTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleYouth, id, year);
                this.FemaleYouthTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleYouth, id, year);
                this.MaleYoungAdultsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleYoungAdults, id, year);
                this.FemaleYoungAdultsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleYoungAdults, id, year);
                this.MaleAdultsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleAdults, id, year);
                this.FemaleAdultsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleAdults, id, year);
                this.MaleSeniorsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.MaleSeniors, id, year);
                this.FemaleSeniorsTableAdapter.Fill(this.GenderDisaggregatedDataDATASET.FemaleSeniors, id, year);
                this.reportViewer1.RefreshReport();
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please Follow the Format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
