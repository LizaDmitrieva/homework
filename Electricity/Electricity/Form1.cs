using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Electricity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("info.txt"))
            {
                string[] s = sr.ReadLine().Split(' ');

                comboBox1.SelectedIndex = comboBox1.FindString(s[0]);

                textBox1.Text = s[1];
                textBox2.Text = s[2];
                textBox3.Text = s[3];
                textBox4.Text = s[4];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double oldDay = double.Parse(textBox1.Text);
            double oldNight = double.Parse(textBox2.Text);
            double rateDay = double.Parse(textBox3.Text);
            double rateNight = double.Parse(textBox4.Text); 
            double newDay = double.Parse(textBox5.Text);
            double newNight = double.Parse(textBox6.Text);
            double sum;

            if (newDay < oldDay)
            {
                MessageBox.Show("Текущий дневной тариф должен быть больше предыдущего!");
            }
            else if (newNight < oldNight) 
            {
                MessageBox.Show("Текущий ночной тариф должен быть больше предыдущего!");
            }
            else
            {
                sum = ((newDay - oldDay) * rateDay) + ((newNight - oldNight) * rateNight);

                label9.Text = sum.ToString() + " руб.";
                label9.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("info.txt"))
            {
                sw.Write(comboBox1.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox3.Text + " " + textBox4.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
