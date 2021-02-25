using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabota
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();

            userNameField.Text = "Enter your email address";
            userNameField.ForeColor = Color.Gray;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
           if (userNameField.Text == "Enter your email address")
            userNameField.Text = "";
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text ="Enter your email address";
                userNameField.ForeColor = Color.Gray;
            }
        }
    }
}
