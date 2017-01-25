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
    public partial class DisasterVictims : MetroForm
    {
        public DisasterVictims()
        {
            InitializeComponent();
        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        private void loadDisasterCombo()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT disasterID, CONCAT(disasterType, ': ', disasterDate) as disasterName FROM disaster ORDER BY disasterDate DESC";
            MySqlCommand mycommand = new MySqlCommand(query, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            disastersCombo.DataSource = dt;
            disastersCombo.DisplayMember = "disasterName";
            disastersCombo.ValueMember = "disasterID";
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
        private void DisasterVictims_Load(object sender, EventArgs e)
        {
            loadDisasterCombo();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT concat(respondent.lastName,', ', respondent.firstName) AS 'NAME', casualty.casualtyType AS 'REMARKS', disaster.disasterType AS 'DISASTER' FROM casualty, respondent, disaster, affectedareas, household WHERE casualty.respondentID = respondent.respondentID AND disaster.disasterID = casualty.disasterID AND disaster.disasterID = '" + disastersCombo.SelectedValue.ToString() + "' AND affectedareas.houseHoldID = household.householdID GROUP BY respondent.respondentID";
                if (validateQuery(query))
                {
                    this.MASTERLISTTableAdapter.Fill(this.DisasterDATASET.MASTERLIST, Int32.Parse(disastersCombo.SelectedValue.ToString()));
                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                    this.reportViewer1.ZoomPercent = 100;
                }
                else
                {
                    MessageBox.Show("There are no victims on the selected Disaster");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "There has been an error. Please Try again. Exception: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
    }
}
