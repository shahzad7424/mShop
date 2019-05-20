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
    public partial class InvoiceReport : Form
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }
        public string get_invoice;
        public string get_name;
        public string get_mobile;
        public string get_to;
        public string get_from1;
        public string get_from2;
        public string get_from3;
        public string get_sender;
        public string get_receiver;
        public string get_shipper;
        public string get_port;
        public string get_driver_no;
        public string get_driver_cnic;
        public string get_container1;
        public string get_container2;
        public string get_vehical;
        public string get_quantity;
        public string get_size;
        public string get_ship_line;
        public string get_frieght;
        public string get_ter_load;
        public string get_damurage;
        public string get_extra;
        public string get_total;
        public string get_detail;
        public string get_tax;
        public string get_g_total;

        private void label1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ag = Graphics.FromImage(bmp);
            ag.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            this.Hide();
        }

        private void InvoiceReport_Load(object sender, EventArgs e)
        {
            textbox1.Text =  get_invoice;
            textbox2.Text = get_name;
            
            textbox4.Text = get_to;
            textbox5.Text = get_from1;
            textbox6.Text = get_from2;
           
            label12.Text = get_sender;
            label21.Text = get_receiver;
            textbox8.Text = get_shipper;
           
            label32.Text = get_driver_no;
            label34.Text = get_driver_cnic;
            label29.Text = get_container1;
            label25.Text = get_container2;
            textbox10.Text = get_vehical;
            textbox11.Text = get_quantity;
            textbox12.Text = get_size;
            textbox13.Text = get_ship_line;
            textBox14.Text = get_frieght;
            textBox15.Text = get_ter_load;
            textBox16.Text = get_damurage;
            textBox17.Text = get_extra;
            textBox18.Text = get_total;
            textbox19.Text = get_detail;
            textBox20.Text = get_tax;
            textBox21.Text = get_g_total;

            label2.Text = DateTime.Now.Date.ToShortDateString();

        }
        Bitmap bmp;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
