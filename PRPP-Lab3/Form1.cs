using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PRPP_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double tempNumber = 0;//пам'ять калькулятора
        private string errorMessage = "";

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1(string[] args)
        {
            InitializeComponent();

            AllocConsole();
            string expression = "";
            string[] argum = Environment.GetCommandLineArgs();
            for (int i = 1; i < argum.Length; i++)
            {
                expression += argum[i] + " ";
            }
            Console.WriteLine(expression);

            AnalaizerClass.AnalaizerClass analyzer = new AnalaizerClass.AnalaizerClass(expression);
            try
            {
                string res = analyzer.Estimate();
                Console.WriteLine(res);
            }
            catch (Exception exception)
            {
                string errorMessage = analyzer.lastError == "" ? exception.Message : analyzer.lastError;
                Console.WriteLine(errorMessage);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                textBoxExp.Text += ((Button)sender).Text;

            }
        }


    }
}
