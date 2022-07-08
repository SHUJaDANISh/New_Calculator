using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        double temp = 0;
        string opcode = "";
        bool isOpCode = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(isOpCode))
            {
                textBox1.Clear();
            }
            isOpCode = false;
            Button n = (Button)sender;
            if (n.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + n.Text;
            }
            else
            textBox1.Text = textBox1.Text + n.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            
            //if (temp == resultValue)
         //   {

               // lCurrentOp.Text = resultValue + " " + opcode;

         //   }
            //if (resultValue != 0)
            //{
            //    equal.PerformClick();
            //    opcode = n.Text;

            //    lCurrentOp.Text = resultValue + " " + opcode;
            //    isOpCode = true;


            //}
          //  else
            {
                opcode = n.Text;
                resultValue = double.Parse(textBox1.Text);
                lCurrentOp.Text = resultValue + " " + opcode;
                isOpCode = true;
            }
        }

        private void Clearelmnt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            resultValue = 0;


        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lCurrentOp.Text = "";
            resultValue = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (opcode) {

                case "+":
                    textBox1.Text = (resultValue + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / double.Parse(textBox1.Text)).ToString();
                    break; 
                case "%":
                    textBox1.Text = (resultValue % double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = double.Parse(textBox1.Text);
            lCurrentOp.Text = "";

            temp = resultValue;
           

            
        }
    }
}
