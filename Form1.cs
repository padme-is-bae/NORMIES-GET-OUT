using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        string plkey = "a"; //temp key
        public static Form fr1;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Patient")
            {
                label2.Text = "Patient ID:";
                textBox2.Visible = false;
                label3.Visible = false;
            }

            else
            {
                label2.Text = "Username:";
                textBox2.Visible = true;
                label3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Patient")
            {
                if (textBox1.Text != plkey)
                {
                    Form2 lo = new Form2();
                    lo.Show();
                    this.Hide();
                }
            }

            else if (comboBox1.Text == "Dentist")
            {
                fr1 = this;
                Form4 lw = new Form4();
                lw.Show();
                this.Visible = false;
            }
        }
    }
}