using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TregCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, v;
            x = Convert.ToDouble(textBox1.Text);
            v = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0: v = Math.Sin(x);break;
                case 1: v = Math.Cos(x); break;
                case 2: v = Math.Tan(x); break;
                case 3: v = Math.Cos(x)/Math.Tan(x); break;
            }
            textBox2.Text = v.ToString();
        }
    }
}
