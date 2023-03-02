using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            int c = 0;
            switch (comboBox1.SelectedIndex)
            { 
            case 0: c = (a + b);break;
            case 1: c = (a - b); break;
            case 2: c = (a * b); break;
            case 3: c = (a / b); break;
            }
            textBox3.Text = Convert.ToString(c);
        }
    }
}
