using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
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

            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();

            if (frm.Logged == true)
            {
                Application.Run(new Frm_Menu());
            }
        }
    }
}
