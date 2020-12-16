using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int luku1 = int.Parse(textBox1.Text);
            int luku2 = int.Parse(textBox2.Text);

            MessageBox.Show((luku1 + luku2).ToString());
        }
    }
}
