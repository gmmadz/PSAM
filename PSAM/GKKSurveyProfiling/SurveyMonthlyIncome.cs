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
    public partial class SurveyMonthlyIncome : MetroForm
    {
        public SurveyMonthlyIncome()
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
        private void countHousehold()
        {
            DataRowView drv = (DataRowView)gkk.SelectedItem;
            string gkkID = drv["gkkID"].ToString();
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT count(household.householdID) FROM household WHERE gkkID = '" + gkkID + "' AND year(household.dateOfSurvey) = " + Int32.Parse(surveyYear.SelectedValue.ToString()) + "";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                total.Text = dt.Rows[0][0] + "";
            }
        }
        private void SurveyMonthlyIncome_Load(object sender, EventArgs e)
        {


            loadYear();
            loadGKK();
        }

       

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            try
            {
                countHousehold();
                int year = Int32.Parse(surveyYear.SelectedValue.ToString());
                this.secondTableAdapter.Fill(this.ProfilingSubsystem.second, total.Text, Int32.Parse(gkk.SelectedValue.ToString()), year);
                this.firstTableAdapter.Fill(this.ProfilingSubsystem.first, total.Text, Int32.Parse(gkk.SelectedValue.ToString()), year);
                this.thirdTableAdapter.Fill(this.ProfilingSubsystem.third, total.Text, Int32.Parse(gkk.SelectedValue.ToString()), year);
                this.fourthTableAdapter.Fill(this.ProfilingSubsystem.fourth, total.Text, Int32.Parse(gkk.SelectedValue.ToString()), year);
                this.fifthTableAdapter.Fill(this.ProfilingSubsystem.fifth, total.Text, Int32.Parse(gkk.SelectedValue.ToString()), year);
                this.DataTable1TableAdapter.Fill(this.ProfilingSubsystem.DataTable1, Int32.Parse(gkk.SelectedValue.ToString()));
                this.totalHouseholdTableAdapter.Fill(this.ProfilingSubsystem.totalHousehold, Int32.Parse(gkk.SelectedValue.ToString()), year);
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

        private void gkk_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
        }
    }
}
