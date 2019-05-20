using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slider.Width = button2.Width;
            slider.Left = button2.Left;
           
            button2.ForeColor = Color.FromArgb(163, 35, 74);
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

   

       

        private void button2_Click(object sender, EventArgs e)
        {
      
            slider.Width = button2.Width;
            slider.Left = button2.Left;
            button2.ForeColor = Color.FromArgb(163, 35, 74);
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            slider.Width = button3.Width;
            slider.Left = button3.Left;
            button3.ForeColor = Color.FromArgb(163, 35, 74);
            button2.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            slider.Width = button4.Width;
            slider.Left = button4.Left;
            button4.ForeColor = Color.FromArgb(163, 35, 74);
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            slider.Width = button5.Width;
            slider.Left = button5.Left;
            button5.ForeColor = Color.FromArgb(163, 35, 74);
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            slider.Width = button6.Width;
            slider.Left = button6.Left;
            button6.ForeColor = Color.FromArgb(163, 35, 74);
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
        }
 

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            if ( FormWindowState.Normal == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                circularPictureBox1.Visible = false;
                pictureBox4.Visible = true;
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (FormWindowState.Normal == 0)
            {
                this.WindowState = FormWindowState.Normal;
                circularPictureBox1.Visible = true;
                pictureBox4.Visible = false;
            }
        }

    }
}
