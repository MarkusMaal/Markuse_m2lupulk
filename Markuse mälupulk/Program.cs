using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form1 f1;
        public static RichCreator rc;
        public static bool done = false;
        public static string dest = "";
        public static bool simulation = false;
        public static string labeltext = "";
        public static double pbar = 0.0;
        public static string currentfile = "";
        public static string[] folders = null;
        public static int[] stats = null;
        public static bool ismas = true;
        public static string masroot = @"C:\mas";
        public static Color[] theme;
        public static List<double> sts = new List<double>();
        public static List<string> list = new List<string>();
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            if (!((IEnumerable<string>)args).Contains<string>("--safemode"))
            {
                Program.f1 = new Form1();
                Program.rc = new RichCreator();
                Application.Run((Form)Program.f1);
            }
            else
                Application.Run((Form)new SafeMode());
        }

    }
}
