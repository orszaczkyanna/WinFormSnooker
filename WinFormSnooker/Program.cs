using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSnooker
{
    static class Program
    {

        public static Adatbazis adatbazis = new Adatbazis();

        public static MainForm mainForm = null;
        public static FormHozzaad formHozzaad = null;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            formHozzaad = new FormHozzaad();
            Application.Run(mainForm);
        }
    }
}
