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
    public partial class AdministrativeOptions : MetroForm
    {
        public AdministrativeOptions()
        {
            InitializeComponent();
        }

        private void AdministrativeOptions_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UserManagement user = new UserManagement();
            user.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            LocationSettings loc = new LocationSettings();
            loc.Show();
        }
    }
}
