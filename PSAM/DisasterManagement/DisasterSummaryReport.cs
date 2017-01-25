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
    public partial class DisasterSummaryReport : MetroForm
    {
        public DisasterSummaryReport()
        {
            InitializeComponent();
        }

        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        private void loadDisaster()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string disaster = "SELECT disasterID, CONCAT(disasterType, ': ', DATE_FORMAT(disasterDate,'%b %d %Y')) as disasterName FROM disaster";
            MySqlCommand mycommand = new MySqlCommand(disaster, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            disasterCombo.DataSource = dt;
            disasterCombo.DisplayMember = "disasterName";
            disasterCombo.ValueMember = "disasterID";
        }
        private void DisasterSummaryReport_Load(object sender, EventArgs e)
        {
                       loadDisaster();
        }

        private void disaster_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void disasterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                this.MASTERLISTTableAdapter.Fill(this.DisasterDATASET.MASTERLIST, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.totalFamiliesAffectedTableAdapter.Fill(this.DisasterDATASET.totalFamiliesAffected, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countOwnedTableAdapter.Fill(this.DisasterDATASET.countOwned, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countRentingTableAdapter.Fill(this.DisasterDATASET.countRenting, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countLivingWithTableAdapter.Fill(this.DisasterDATASET.countLivingWith, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countUsedFreeTableAdapter.Fill(this.DisasterDATASET.countUsedFree, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.totalHousesDamagedTableAdapter.Fill(this.DisasterDATASET.totalHousesDamaged, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countTotallyDamagedTableAdapter.Fill(this.DisasterDATASET.countTotallyDamaged, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countPartiallyDamagedTableAdapter.Fill(this.DisasterDATASET.countPartiallyDamaged, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.totalCasualtiesTableAdapter.Fill(this.DisasterDATASET.totalCasualties, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countDeadTableAdapter.Fill(this.DisasterDATASET.countDead, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countInjuredTableAdapter.Fill(this.DisasterDATASET.countInjured, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.countMissingTableAdapter.Fill(this.DisasterDATASET.countMissing, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.totalEstimatedCostTableAdapter.Fill(this.DisasterDATASET.totalEstimatedCost, Int32.Parse(disasterCombo.SelectedValue.ToString()));
                this.reportViewer1.RefreshReport();
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "There has been an error. Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
    }
}
