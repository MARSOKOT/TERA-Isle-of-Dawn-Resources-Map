using Resources_map_Isle_of_Dawn.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resources_map_Isle_of_Dawn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)(numericUpDown1.Value) / 100;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                if (numericUpDown2.Text != "" && numericUpDown2.Text != "")
                {
                    this.Width = Convert.ToInt16((557 * numericUpDown2.Value) / 97);
                    this.Height = Convert.ToInt16((814 * numericUpDown2.Value) / 97 + 19);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.res_Isle_of_Dawn;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Goblu_Isle_of_Dawn;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Pilka_Isle_of_Dawn;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Cobal_Isle_of_Dawn;
        }
    }
}
