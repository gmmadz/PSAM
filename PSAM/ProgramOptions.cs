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
    public partial class ProgramOptions : MetroForm
    {
        public ProgramOptions()
        {
            InitializeComponent();
        }

        private void ProgramOptions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgramManagement manage = new ProgramManagement();
            manage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgramSummary summary = new ProgramSummary();
            summary.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ProgramProposal propose = new ProgramProposal();
            propose.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ProgramManagement manage = new ProgramManagement();
            manage.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ProgramSummary summary = new ProgramSummary();
            summary.Show();
        }
    }
}
