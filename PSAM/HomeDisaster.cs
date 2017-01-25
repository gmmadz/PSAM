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
    public partial class HomeDisaster : MetroForm
    {
        public HomeDisaster()
        {
            InitializeComponent();
        }

        private void HomeDisaster_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DisasterManagement disaster = new DisasterManagement();
            this.Hide();
            disaster.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            CasualtiesAndDamages add = new CasualtiesAndDamages();
            this.Hide();
            add.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            CasualtiesAndDamagesEdit edit = new CasualtiesAndDamagesEdit();
            this.Hide();
            edit.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            CasualtiesAndDamagesView view = new CasualtiesAndDamagesView();
            this.Hide();
            view.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            DisasterSummaryReport summary = new DisasterSummaryReport();
            this.Hide();
            summary.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            DisasterVictimsMasterlist victims = new DisasterVictimsMasterlist();
            this.Hide();
            victims.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            AffectedAreas areas = new AffectedAreas();
            this.Hide();
            areas.Show();
        }
    }
}
