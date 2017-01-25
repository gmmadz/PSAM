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

namespace PSAM
{
    public partial class HomeProfiling : MetroForm
    {
        public HomeProfiling()
        {
            InitializeComponent();
        }

        private void HomeProfiling_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SurveyProfiling add = new SurveyProfiling();
            add.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileGridEdit edit = new ProfileGridEdit();
            edit.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileGridView view = new ProfileGridView();
            view.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SurveyMatrixFormat matrix = new SurveyMatrixFormat();
            matrix.Show();

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SurveyStatisticalFormat graph = new SurveyStatisticalFormat();
            graph.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SurveyMasterlist masterlist = new SurveyMasterlist();
            masterlist.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SurveyGenderDisaggregatedDataReport gender = new SurveyGenderDisaggregatedDataReport();
            gender.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SurveyMonthlyIncome income = new SurveyMonthlyIncome();
            income.Show();
        }
    }
}
