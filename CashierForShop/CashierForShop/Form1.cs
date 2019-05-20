using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierForShop
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = btn_Counter.Height;
            sidepanel.Top = btn_Counter.Top;
            forminpanel(new Counter());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (metroPanel1.Width == 263)
            {
                metroPanel1.Width = 76;
            }
            else
            {
                metroPanel1.Width = 263;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("T");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void forminpanel(Object formCo)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = formCo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();    
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_Counter.Height;
            sidepanel.Top = btn_Counter.Top;
            forminpanel(new Counter());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            forminpanel(new Bills());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            forminpanel(new NewStock());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button6.Height;
            sidepanel.Top = button6.Top;
            forminpanel(new Tags());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            forminpanel(new InAndOut());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            forminpanel(new UpdateStock());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button7.Height;
            sidepanel.Top = button7.Top;
            forminpanel(new Reports());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button8.Height;
            sidepanel.Top = button8.Top;
            forminpanel(new Business());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button9.Height;
            sidepanel.Top = button9.Top;
            forminpanel(new Setting());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button10.Height;
            sidepanel.Top = button10.Top;
            forminpanel(new About());
        }
    }
}
