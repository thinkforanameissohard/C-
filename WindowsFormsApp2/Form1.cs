using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        static float my_sum(String s)
        {
            char[] sp = { ' ' };
            String[] num = new string[3];
            num = s.Split(sp);
            float sum = 0;
            for (int i = 0; i < 4; ++i)
            {
                sum += Convert.ToSingle(num[i]);
            }
            return sum / 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[] grade = new float[3];
            label4.Text = my_sum(textBox1.Text.ToString()).ToString();
            label5.Text = my_sum(textBox2.Text.ToString()).ToString();
            label6.Text = my_sum(textBox3.Text.ToString()).ToString();
        }

    }
}
