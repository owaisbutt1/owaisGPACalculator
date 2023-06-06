using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIPHAHGPACALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float totalGrades = 0;
            uint crHour = 0;
            uint[] marks = new uint[6] ;
            float[] grade = new float[6]; 
            if (uint.TryParse(textBox1.Text, out marks[0]) && uint.TryParse(textBox2.Text, out marks[1]) && uint.TryParse(textBox3.Text, out marks[2]) && uint.TryParse(textBox4.Text, out marks[3]) && uint.TryParse(textBox5.Text, out marks[4]) && uint.TryParse(textBox6.Text, out marks[5])) { 
                if ((marks[0] >= 0 && marks[0] <= 100) && (marks[1] >= 0 && marks[1] <= 100) && (marks[2] >= 0 && marks[2] <= 100) && (marks[3] >= 0 && marks[3] <= 100) && (marks[4] >= 0 && marks[4] <= 100) && (marks[5] >= 0 && marks[5] <= 100))
                {
                   for (int i=1; i<7; i++)
                   {
                        string checkName = "checkBox" + i;
                        string comboName = "comboBox" + i;
                        
                        ComboBox comboBox = (ComboBox)Controls.Find(comboName, true).FirstOrDefault();
                        CheckBox checkBox = (CheckBox)Controls.Find(checkName, true).FirstOrDefault();
                       
                            if (!checkBox.Checked)
                            {
                                if (comboBox.SelectedItem != null)
                                {
                                    if(marks[i-1]<=100 && marks[i - 1] >= 90)
                                    {
                                        grade[i - 1] = 4.0f;
                                    }
                                   else if (marks[i - 1] <= 89 && marks[i - 1] >= 80)
                                    {
                                        grade[i - 1] = 4.0f;
                                    }
                                    else if (marks[i - 1] <= 79 && marks[i - 1] >= 70)
                                    {
                                        grade[i - 1] = 3.0f;
                                    }
                                    else if (marks[i - 1] <= 69 && marks[i - 1] >= 60)
                                    {
                                        grade[i - 1] = 2.0f;
                                    }
                                    else if (marks[i - 1] <= 59 && marks[i - 1] >= 50)
                                    {
                                        grade[i - 1] = 1.0f;
                                    }
                                    else if (marks[i - 1] <= 50)
                                    {
                                        grade[i - 1] = 0.0f;
                                    }
                                    crHour += uint.Parse(comboBox.Text);
                                    totalGrades += grade[i - 1] * uint.Parse(comboBox.Text);
                                }
                                else
                                {
                                    label4.Text = "0.0";
                                    MessageBox.Show("You need to Select Credit Hours");
                                    break;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        
                        

                   }
                    totalGrades /= crHour;
                    if (float.IsNaN(totalGrades))
                    {
                        label4.Text = "0.0";
                    }
                    else
                    {
                        label4.Text = totalGrades.ToString("0.####");
                    }
                }
                else
                {
                    label4.Text = "0.0";
                    MessageBox.Show("Please Enter Number From 0 - 100 Only!");
                   
                }
                
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                label4.Text = "0.0";
                MessageBox.Show("Fields Shouldn't be Left Empty!");
            }
            else
            {
                label4.Text = "0.0";
                MessageBox.Show("Enter Positive Integers Only!");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox1.Text = "0"; }
            else { textBox1.Text = ""; }
            if (checkBox1.Checked)
            {
                comboBox1.SelectedIndex = -1; 
                comboBox1.Text = ""; 
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { textBox2.Text = "0"; }
            else { textBox2.Text = ""; }
            if (checkBox2.Checked)
            {
                comboBox2.SelectedIndex = -1;
                comboBox2.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { textBox3.Text = "0"; }
            else { textBox3.Text = ""; }
            if (checkBox3.Checked)
            {
                comboBox3.SelectedIndex = -1;
                comboBox3.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { textBox4.Text = "0"; }
            else { textBox4.Text = ""; }
            if (checkBox4.Checked)
            {
                comboBox4.SelectedIndex = -1;
                comboBox4.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) { textBox5.Text = "0"; }
            else { textBox5.Text = ""; }
            if (checkBox5.Checked)
            {
                comboBox5.SelectedIndex = -1;
                comboBox5.Text = "";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) { textBox6.Text = "0"; }
            else { textBox6.Text = ""; }
            if (checkBox6.Checked)
            {
                comboBox6.SelectedIndex = -1;
                comboBox6.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           foreach(Control c in groupBox1.Controls)
            {
                if (c is TextBox )
                {
                    c.Text = " ";
                  
                }
                
            }
            foreach (Control c in groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.SelectedItem = null;
                }
            }
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Checked = false;
                }
            }
        }
    }
}
