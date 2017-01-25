using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new ProfileGridEdit());
            //Application.Run(new SurveyProfiling());
          // Application.Run(new ProfileGridView());
           // Application.Run(new CasualtiesAndDamages());
            //Application.Run(new SurveyGenderDisaggregatedDataReport());
            //Application.Run(new CasualtiesAndDamagesEdit());
            //Application.Run(new SurveyGender());
           //Application.Run(new DisasterSummaryReport());
            Application.Run(new Login());
            //Application.Run(new AffectedAreas());
           // Application.Run(new SurveyMonthlyIncome());
           //Application.Run(new ProgramManagement());
        }
    }
}
