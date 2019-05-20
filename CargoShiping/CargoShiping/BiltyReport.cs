using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShiping
{
    public partial class BiltyReport : Form
    {
        public BiltyReport()
        {
            InitializeComponent();
        }
        public string get1_invoice;
        public string get_name;
        public string get_mobile;
        public string get_to;
        public string get_from1;
        public string get_from2;
        public string get_from3;
        public string get_shipper;
        public string get_port;
        public string get_vehical;
        public string get_quantity;
        public string get_size;
        public string get_ship_line;

        private void label1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ag = Graphics.FromImage(bmp);
            ag.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            this.Hide();
        }

        private void BiltyReport_Load(object sender, EventArgs e)
        {
            textbox1.Text = get1_invoice;
            textbox2.Text = get_name;
            textbox3.Text = get_mobile;
            textbox4.Text = get_to;
            textbox5.Text = get_from1;
            textbox6.Text = get_from2;
            textbox7.Text = get_from3;
            textbox8.Text = get_shipper;
            textbox9.Text = get_port;
            textbox10.Text = get_vehical;
            textbox11.Text = get_quantity;
            textbox12.Text = get_size;
            textbox13.Text = get_ship_line;

           

            label2.Text = DateTime.Now.Date.ToShortDateString();
         
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
