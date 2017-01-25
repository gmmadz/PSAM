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
    public partial class ProfilingDashboard : MetroForm
    {
        public ProfilingDashboard()
        {
            InitializeComponent();
        }

        private void ProfilingDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SurveyProfiling addProfile = new SurveyProfiling();
            addProfile.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ProfileGridEdit editProfile = new ProfileGridEdit();
            editProfile.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ProfileGridView viewProfile = new ProfileGridView();
            viewProfile.Show();
        }
    }
}
