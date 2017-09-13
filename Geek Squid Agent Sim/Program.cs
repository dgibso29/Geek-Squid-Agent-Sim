using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekSquidAgentSim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static MainDB mainDB = new MainDB();
        public static GeekSquidAgentSim mainWindow;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new GeekSquidAgentSim();
            Application.Run(mainWindow);
        }
    }
}
