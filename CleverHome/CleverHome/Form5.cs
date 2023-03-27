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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            label7.Text = DateTime.Now.ToString();

            timePicker(dateTimePicker2);
            timePicker(dateTimePicker3);
            timePicker(dateTimePicker4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            Color col = Color.Black; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            button3.Visible = true;
        }

        private void timePicker(DateTimePicker date_time_picker)
        {
            date_time_picker.Format = DateTimePickerFormat.Time;
            date_time_picker.ShowUpDown = true;

            DateTime myDate = date_time_picker.Value.Date +
                    date_time_picker.Value.TimeOfDay;

            date_time_picker.Value = myDate.Date;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το αυτόματο τάισμα έχει ενεργοποιηθεί!");
        }
    }
}
