using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace büyük_küçük_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (a > b)
                label3.Text=Convert.ToString(a + " sayısı " + b + " sayısından büyüktür ");
            else if (b > a)
                label3.Text=Convert.ToString(b + " sayısı " + a + " sayısından büyüktür ");
            else
                MessageBox.Show("sayılar eşittir");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
