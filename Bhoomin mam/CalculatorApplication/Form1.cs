using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void CALCULATOR_Load(object sender, EventArgs e)
        {

        }


        private void b1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "+";
            }
            else
            {
                richTextBox1.Text += "+";
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "-";
            }
            else
            {
                richTextBox1.Text += "-";
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "*";
            }
            else
            {
                richTextBox1.Text += "*";
            }
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "%";
            }
            else
            {
                richTextBox1.Text += "%";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "/";
            }
            else
            {
                richTextBox1.Text += "/";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            string expression = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(expression))
            {
                richTextBox1.Text = "0";
            }
            else
            {
                try
                {
                    var result = new DataTable().Compute(expression, null);

                    if (result != null)
                    {
                        richTextBox1.Text = result.ToString();
                    }
                    else
                    {
                        richTextBox1.Text = "0";
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Expression!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox1.Text = "0";
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }
    }
}


