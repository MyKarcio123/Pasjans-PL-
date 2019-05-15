using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasjans1
{
    static class Program
    {
        /// <summary>
        public static Form1 wdus;
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            wdus = new Form1();
            Application.Run(wdus);
        }
    }
}
