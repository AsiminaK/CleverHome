using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverHome
{
    public partial class Form1 : Form
    {

        bool rola = false;
        bool zesth = false;

        public Form1()
        {
            InitializeComponent();

            comboBox2.Items.Add("ΡΟΛΑ");
            comboBox2.Items.Add("ΘΕΡΜΑΝΣΗ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ΡΟΛΑ")
            {
                rola = true;  
                Form3 myForm = new Form3(rola,zesth);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else if (comboBox2.Text == "ΘΕΡΜΑΝΣΗ")
            {
                zesth = true;
                Form3 myForm = new Form3(rola, zesth);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 myForm = new Form4();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 myForm = new Form5();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 myForm = new Form6();
            myForm.ShowDialog();

        }
    }
}
