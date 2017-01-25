using MetroFramework;
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
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        public Home(string strTextBox)
        {
          InitializeComponent(); 
          user.Text=strTextBox;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            if (user.Text == "PSAM Head" || user.Text == "Survey Team")
            {
                HomeProfiling survey = new HomeProfiling();
                survey.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (user.Text == "PSAM Head")
            {
                HomeDisaster disaster = new HomeDisaster();
                disaster.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (user.Text == "PSAM Head" || user.Text == "Parish Priest")
            {
                ProgramOptions options = new ProgramOptions();
                options.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (user.Text == "PSAM Head" || user.Text == "Survey Team")
            {
                HomeProfiling survey = new HomeProfiling();
                survey.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            
            if (user.Text == "PSAM Head")
            {
                HomeDisaster disaster = new HomeDisaster();
                disaster.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
           

            if (user.Text == "PSAM Head" || user.Text == "Parish Priest")
            {
                ProgramOptions options = new ProgramOptions();
                options.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            if(user.Text == "PSAM Head")
            {
                AdministrativeOptions admin = new AdministrativeOptions();
                admin.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (user.Text == "PSAM Head")
            {
                AdministrativeOptions admin = new AdministrativeOptions();
                admin.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "You are not allowed to access this module.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
