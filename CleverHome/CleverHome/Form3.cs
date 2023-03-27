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
    public partial class Form3 : Form
    {
        string temperature = "";
        string check_button = "OFF";

        public Form3(bool r,bool z)
        {
            InitializeComponent();

            comboBox1.Items.Add("ΥΠΝΟΔΩΜΑΤΙΟ");
            comboBox1.Items.Add("ΠΑΙΔΙΚΟ ΔΩΜΑΤΙΟ");
            comboBox1.Items.Add("ΣΑΛΟΝΙ");
            comboBox1.Items.Add("ΚΟΥΖΙΝΑ");
            comboBox1.Items.Add("ΔΙΑΔΡΟΜΟΣ");

            if ( r == true)
            {
                label11.Text = " ΔΙΑΧΕΙΡΙΣΗ ΡΟΛΩΝ ";
                label2.Text = "Θέλετε να κατεβάσετε ή\nνα ανεβάσετε τα ρολά;";
                panel1.Visible = true;
            }
            else if (z == true)
            {
                label11.Text = " ΔΙΑΧΕΙΡΙΣΗ ΘΕΡΜΟΚΡΑΣΙΑΣ ";
                label2.Text = "Eλέγξτε τη θερμοκρασία\nτου σπιτιού σας!";
                panel2.Visible = true;
            }
        }

        private void label11_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.label11.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
            Color col = Color.White; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.label11.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void UpDown(Button b, Label l)
        {
            if (b.Text == "UP")
            {
                b.Text = "DOWN";
                b.BackColor = Color.IndianRed;
                MessageBox.Show("Μόλις κατεβάσατε το παντζούρι στο " + l.Text);
            }
            else
            {
                b.Text = "UP";
                b.BackColor = Color.Aquamarine;
                MessageBox.Show("Μόλις ανεβάσατε το παντζούρι του " + l.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpDown(button2, label6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpDown(button3, label7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpDown(button4, label8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpDown(button5, label9);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξατε το " + comboBox1.Text);
            label14.Visible = true;
            hScrollBar1.Visible = true;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            temperature = hScrollBar1.Value.ToString();
            label14.Text = temperature + "°C";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = check_button;

            if (button6.Text == "ON")
            {
                MessageBox.Show("Μόλις κλείσατε τη θέρμανση! Όταν ανοίξετε ξανά τη θέρμανση η θερμοκρασία θα είναι στους " + temperature + "°C");
                button6.Text = "OFF";
                check_button = "OFF";
                button6.BackColor = Color.IndianRed;
            }
            else if (button6.Text == "OFF")
            {
                MessageBox.Show("Μόλις ανοίξατε τη θέρμανση! Η θερμοκρασία είναι " + temperature + "°C");
                button6.Text = "ON";
                check_button = "ON";
                button6.BackColor = Color.Aquamarine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
