using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9M7SHOQ;Initial Catalog=DemoTest;Integrated Security=True");


        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            ReportView rv = new ReportView();
            rv.Show();
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width,this.Size.Height,g);
            Graphics ag = Graphics.FromImage(bmp);
            ag.CopyFromScreen(this.Location.X, this.Location.Y,0,0,this.Size);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ShowDialog();
        }
    }
}
