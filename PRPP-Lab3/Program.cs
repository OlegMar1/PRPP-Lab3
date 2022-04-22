using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPP_Lab3
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length <= 1)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Form1(args));
            }
        }
    }
}
