using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Time xex = new Time();

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = xex.ToString();
            timer1.Enabled = false;
            if (timer1.Enabled)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            xex.AddSecond((int)numericUpDown1.Value);
            xex.AddMinute((int)numericUpDown2.Value);
            xex.AddHour((int)numericUpDown3.Value);
            label1.Text = xex.ToString();
            numericUpDown3.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (xex.Second == 0 && xex.Minute == 0 && xex.Hour == 0)
            {
                timer1.Stop();
            }
            else
            {
                xex.AddSecond(-1);
            }
            label1.Text = xex.ToString();
            if (timer1.Enabled)
            {
                pictureBox1.BackColor = Color.Green;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                pictureBox1.BackColor = Color.Orange;
            }
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            timer1.Enabled = false;
            timer1.Dispose();
            xex = new Time();
            label1.Text = xex.ToString();
        }
    }
}
