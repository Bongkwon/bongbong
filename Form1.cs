using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            MessageBox.Show("Test");

            label1.Text = "Test";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            label1.Text = "test";

            label1.Text = "체크박스";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
=======
            MessageBox.Show("Test");
>>>>>>> 1eb10e8a8b6f2010bd460b965e99df6859509b6a
        }
    }
}
