using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.Items.Count;
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 1)
                {
                    listBox2.Items[i] = Convert.ToInt32(listBox1.Items[i]) * 2;
                }
            }
        }
    }
}
