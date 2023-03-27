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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            comboBox1.Items.Add("ΑΘΛΗΤΙΚΑ");
            comboBox1.Items.Add("ΕΠΙΣΗΜΑ");
            comboBox1.Items.Add("ΧΟΡΟΥ");
            comboBox1.Items.Add("ΒΡΟΧΗΣ");
            comboBox1.Items.Add("ΟΛΑ");

           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.skroutz.gr/s/23375001/%CE%A0%CE%BF%CF%85%CE%AD%CE%BD%CF%84-%CE%9C%CF%80%CE%B1%CE%BB%CE%AD%CF%84%CE%BF%CF%85-Bloch-ES0160L-Balance-European-%CE%A1%CE%BF%CE%B6.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δείτε το πλάνο ημέρας για την ημερομηνία που επιλέξατε!");
            panel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel1.Visible == false) 
            {
                panel1.Visible = true;

                button1.Text = " ΤΟ ΠΛΑΝΟ \nΗΜΕΡΑΣ ΜΟΥ";
                label2.Text = "ΟΡΓΑΝΩΣΑ ΚΑΙ ΤΗΝ ΠΑΠΟΥΤΣΟΘΗΚΗ ΣΑΣ!";
            }
            else
            {
                panel1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;

                button1.Text = "ΟΛΑ ΤΑ \nΠΑΠΟΥΤΣΙΑ ΣΑΣ";
                label2.Text = "Έφτιαξα το πλάνο ημέρας σας\n όπως σας υποσχέθηκα!\nΔίπλα από κάθε δραστηριότητα βλ" +
    "έπετε\nτα παπούτσια που θα χρειαστείτε!";

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "ΑΘΛΗΤΙΚΑ")
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (comboBox1.Text == "ΕΠΙΣΗΜΑ")
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (comboBox1.Text == "ΧΟΡΟΥ")
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            else if (comboBox1.Text == "ΒΡΟΧΗΣ")
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
