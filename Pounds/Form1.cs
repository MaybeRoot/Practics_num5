using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double funt, kg, k = 0;
                switch (listBox1.SelectedIndex)
                {
                    case 0: k = 0.4059; break;
                    case 1: k = 0.453592; break;
                    case 2: k = 0.056001; break;
                    case 3: case 4: case 5: case 7: k = 0.5; break;
                    case 6: k = 0.31762; break;
                }
                funt = Convert.ToDouble(textBox1.Text);
                kg = k * funt;
                label4.Text = textBox1.Text + " фунт(а/ов) - это " + String.Format("{0:0.00}", Convert.ToString(kg)) + " кг";

            }
            else { MessageBox.Show("Не заданы значения"); }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0) e.Handled = true;
        }
    }
}
