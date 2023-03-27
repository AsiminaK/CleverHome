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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            fill_combobox(comboBox1);
            fill_combobox(comboBox2);
            fill_combobox(comboBox3);
            fill_combobox(comboBox4);
            fill_combobox(comboBox5);
            fill_combobox(comboBox6);
            fill_combobox(comboBox7);
            fill_combobox(comboBox8);

            timePicker(dateTimePicker2);
            timePicker(dateTimePicker3);
            timePicker(dateTimePicker4);
            timePicker(dateTimePicker5);
            timePicker(dateTimePicker6);
            timePicker(dateTimePicker7);
            timePicker(dateTimePicker8);
            timePicker(dateTimePicker9);

        }

        private void timePicker(DateTimePicker date_time_picker)
        {
            date_time_picker.Format = DateTimePickerFormat.Time;
            date_time_picker.ShowUpDown = true;

            DateTime myDate = date_time_picker.Value.Date +
                    date_time_picker.Value.TimeOfDay;

            date_time_picker.Value = myDate.Date;
        }

        private void visibility(ComboBox cb, Label lb1, Label lb2, DateTimePicker dt)
        {
            cb.Visible = true;
            lb1.Visible = true;
            lb2.Visible = true;
            dt.Visible = true;
        }

        private void fill_combobox(ComboBox cb)
        {
            cb.Items.Add("ΑΥΤΟΚΙΝΗΤΟ");
            cb.Items.Add("ΛΕΩΦΟΡΕΙΟ");
            cb.Items.Add("ΤΡΕΝΟ");
            cb.Items.Add("ΜΕΤΡΟ");
            cb.Items.Add("ΠΟΔΙΑ");
            cb.Items.Add("ΣΥΝΔΥΑΣΜΟΣ ΜΕΣΩΝ");
        }

        private void showTheWAY(ComboBox cb)
        {
            if (cb.Text == "ΑΥΤΟΚΙΝΗΤΟ")
            {
                panel2.Visible = true;
            }
            else if (cb.Text == "ΛΕΩΦΟΡΕΙΟ")
            {
                panel3.Visible = true;
            }
            else if (cb.Text == "ΤΡΕΝΟ")
            {
                panel4.Visible = true;
            }
            else if (cb.Text == "ΜΕΤΡΟ")
            {
                panel5.Visible = true;
            }
            else if (cb.Text == "ΠΟΔΙΑ")
            {
                panel1.Visible = true;
            }
            else
            {
                panel6.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Sienna, ButtonBorderStyle.Solid);
            Color col = Color.Sienna; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void location(PictureBox pb)
        {
            if (pb.Visible == false)
            {
                pb.Visible = true;
            }
            else
            {
                pb.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox1, label3, label4, dateTimePicker2);
            location(pictureBox4);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox2, label3, label4, dateTimePicker3);
            location(pictureBox5);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox3, label3, label4, dateTimePicker4);
            location(pictureBox6);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox4, label3, label4, dateTimePicker5);
            location(pictureBox7);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox5, label3, label4, dateTimePicker6);
            location(pictureBox8);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox6, label3, label4, dateTimePicker7);
            location(pictureBox9);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            visibility(comboBox7, label3, label4, dateTimePicker8);
            location(pictureBox10);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            visibility(comboBox8, label3, label4, dateTimePicker9);
            location(pictureBox11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showTheWAY(comboBox8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Sienna, ButtonBorderStyle.Solid);
            Color col = Color.Sienna; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Sienna, ButtonBorderStyle.Solid);
            Color col = Color.Sienna; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, Color.Sienna, ButtonBorderStyle.Solid);
            Color col = Color.Sienna; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.Sienna, ButtonBorderStyle.Solid);
            Color col = Color.Sienna; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.Sienna, ButtonBorderStyle.Solid);
            Color col = Color.Sienna; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
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
