using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Form
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

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.Name = textBox1.Text;
            stud.Rost = (int)numericUpDown1.Value;

            stud.SetEat((double)numericUpDown2.Value);
            MessageBox.Show(string.Format("Студент: {0}\nрост: {1}\nвес: {2}", stud.Name, stud.Rost, stud.Ves));
        }
    }
}
