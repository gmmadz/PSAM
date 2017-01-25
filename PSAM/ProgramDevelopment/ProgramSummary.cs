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
    public partial class ProgramSummary : MetroForm
    {
        public ProgramSummary()
        {
            InitializeComponent();
        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        private void ProgramSummary_Load(object sender, EventArgs e)
        {
            
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string program = "SELECT program.programID, CONCAT(program.programTitle,' / ',  disaster.disasterType, ' / ',disaster.disasterDate) AS program, program.programTitle FROM program, disaster WHERE program.disasterID = disaster.disasterID AND program.status = 'Approved'";
            MySqlCommand mycommand = new MySqlCommand(program, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            approvedPrograms.DataSource = dt;
            approvedPrograms.DisplayMember = "program";
            approvedPrograms.ValueMember = "programID";
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            //this.noexpensesTableAdapter.Fill(this.ProgramReports.noexpenses, Int32.Parse(approvedPrograms.SelectedValue.ToString()));
            this.listofbudgetTableAdapter.Fill(this.ProgramReports.listofbudget, Int32.Parse(approvedPrograms.SelectedValue.ToString()));
            this.programOverviewTableAdapter.Fill(this.ProgramReports.programOverview, Int32.Parse(approvedPrograms.SelectedValue.ToString()));
           // this.budgetTableAdapter.Fill(this.ProgramReports.budget, Int32.Parse(approvedPrograms.SelectedValue.ToString()));
            this.expensesTableAdapter.Fill(this.ProgramReports.expenses, Int32.Parse(approvedPrograms.SelectedValue.ToString()));
            this.programDetailsTableAdapter.Fill(this.ProgramReports.programDetails, Int32.Parse(approvedPrograms.SelectedValue.ToString()));
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
        }
    }
}
