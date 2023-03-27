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
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            Color col = Color.Black; ButtonBorderStyle
            bbs = ButtonBorderStyle.Solid;
            int thickness = 4;
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Mina/Desktop/CleverHomeVIDEOS/plano.mp4";
            }
            else if (radioButton2.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Mina/Desktop/CleverHomeVIDEOS/papoutsia.mp4";
            }
            else if (radioButton3.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Mina/Desktop/CleverHomeVIDEOS/taistra.mp4";
            }
            else if (radioButton4.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Mina/Desktop/CleverHomeVIDEOS/rola.mp4";
            }
            else if (radioButton5.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Mina/Desktop/CleverHomeVIDEOS/zesth.mp4";
            }

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
