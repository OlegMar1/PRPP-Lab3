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
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (textBoxExp.Text.Length == 0) return;

            AnalaizerClass.AnalaizerClass analyzer = new AnalaizerClass.AnalaizerClass(textBoxExp.Text);
            try
            {
                string res = analyzer.Estimate();
                textBoxRes.Text = res;
            }
            catch (Exception exception)
            {
                errorMessage = analyzer.lastError == "" ? exception.Message : analyzer.lastError;
                textBoxRes.Text = errorMessage;
            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxExp.Text = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {

            String expr = textBoxExp.Text;
            if (expr.Length > 0)
            {
                if (expr.EndsWith("mod"))
                {
                    textBoxExp.Text = expr.Remove(expr.Length - 3);
                }
                else
                {
                    textBoxExp.Text = expr.Remove(expr.Length - 1);
                }
            }
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBoxExp.Text = textBoxExp.Text + tempNumber.ToString();
        }

        private void buttonMpluss_Click(object sender, EventArgs e)
        {
            double number;
            if (Double.TryParse(textBoxRes.Text, out number))
            {
                tempNumber = tempNumber + Convert.ToDouble(textBoxRes.Text);
            }
            else
            {
                textBoxRes.Text = "Cannot be converted to a number";
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            tempNumber = 0;
        }


        private void buttonUnar_Click(object sender, EventArgs e)
        {
            string expression = textBoxExp.Text;
            if (expression == "") return;
            if (expression.StartsWith("m1*(") &&
                expression.EndsWith(")"))
            {
                expression = expression.Remove(0, 4);
                expression = expression.Remove(expression.Length - 1);
                textBoxExp.Text = expression;
                return;
            }
            expression = "m1*(" + expression + ")";
            textBoxExp.Text = expression;
        }

    }
}

