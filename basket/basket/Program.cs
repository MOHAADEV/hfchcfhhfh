using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basket
{
    static class Program
    {
       
        public static pippop pip;
        public static Form1 form1;
        public static showmenu menu;
        public static Bill bil;
        public static bil b;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pip = new pippop();
            form1 = new Form1();    
            menu = new showmenu();
            bil = new Bill();
            b = new bil();
            Application.Run(form1);
        }
    }
}
