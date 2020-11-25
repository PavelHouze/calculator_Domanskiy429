using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domanskiy_karpeshina429
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b, c, d, m, h;
        
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "") {
                MessageBox.Show("Нет значений", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Во втором окне нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Во первом окне нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                calculate();
            }
        }
        private void calculate()
        {


            switch (count)
            {
                case 1:
                    if (textBox1.Text.Contains("%"))
                    {
                        b =  a + h;
                        if (b == 69)
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "Nice";
                        }
                        else
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "";
                        }
                    }
                    else
                    {
                        b = a + float.Parse(textBox1.Text);
                        if (b == 69)
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "Nice";
                        }
                        else
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "";
                        }
                    }
                    break;
                case 2:
                    if (textBox1.Text.Contains("%"))
                    {
                        b = a - h;
                        if (b == 69)
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "Nice";
                        }
                        else
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "";
                        }
                    }
                    else
                    {
                        b = a - float.Parse(textBox1.Text);

                        if (b == 69)
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "Nice";
                        }
                        else
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "";

                        }
                    }
                    break;
                case 3:
                    if (textBox1.Text.Contains("%"))
                    {
                        b = a / h;
                        if (b == 69)
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "Nice";
                        }
                        else
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "";
                        }
                    }
                    else
                    {

             
                    b = a * float.Parse(textBox1.Text);
                    if (b == 69)
                    {
                        textBox1.Text = b.ToString();
                        textBox2.Text = "Nice";
                    }
                    else
                    {
                        textBox1.Text = b.ToString();
                        textBox2.Text = "";
                    }
            }
                    break;
                    case 4:
                 if (textBox1.Text.Contains("%"))
            {
                        b = a * h;
                        if (b == 69)
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "Nice";
                        }
                        else
                        {
                            textBox1.Text = b.ToString();
                            textBox2.Text = "";
                        }
                    }
            else
            {
                b = a / float.Parse(textBox1.Text);
                if (b == 69)
                {
                    textBox1.Text = b.ToString();
                    textBox2.Text = "Nice";
                }
                else
                {
                    textBox1.Text = b.ToString();
                    textBox2.Text = "";
                }
            }

                    break;
  

                    default:
                        break;
            }
        } 

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox2.Text.Contains("+"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("*"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("/"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                textBox2.Text = a.ToString() + "*";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("+"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (textBox2.Text.Contains("*"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("/"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                textBox2.Text = a.ToString() + "/";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Contains("-"))
            {

                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (textBox2.Text.Contains("+"))
            {
               
                    MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                
            }
            else if (textBox2.Text.Contains("*"))
            {
               
                    MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (textBox2.Text.Contains("/"))
            {
               
                    MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                textBox2.Text = a.ToString() + "-";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("+"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("*"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Contains("/"))
            {
                MessageBox.Show("Знак уже есть", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                textBox2.Text = a.ToString() + "+";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";


        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else{
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                m = float.Parse(textBox1.Text);
                textBox1.Clear();
                a = (float)Math.Sqrt(m);
                textBox1.Text = a.ToString();
            }
        }

       

        private void button20_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m = float.Parse(textBox1.Text);
                h = (float.Parse(textBox1.Text) * a) / 100;
                textBox1.Clear();
                textBox1.Text = m.ToString() + "%";

            }
        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нет числа", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c = float.Parse(textBox1.Text);
                d = c * -1;
                textBox1.Clear();
                textBox1.Text = d.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (textBox1.Text == "")
            {
                
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
               
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            
        }

       
        
    }
}
