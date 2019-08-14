using COMP123_S2019_FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * STUDENT NAME: TANAY KAPOOR
 * STUDENT ID:301044399
 * DESCRIPTION: THIS THE PROGRAM CLASS
 */
namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        public static HeroGenerator heroGenerator;
        public static AboutForm aboutForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();
            aboutForm = new AboutForm();

            Application.Run(heroGenerator);
        }
    }
}
