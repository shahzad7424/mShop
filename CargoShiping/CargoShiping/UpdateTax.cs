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

namespace CargoShiping
{
    public partial class UpdateTax : Form
    {
        public UpdateTax()
        {
            InitializeComponent();
        }
      
        
        public string get_invoice;
        public string get_Cust;
        public string get_total;
        public string get_tax;
        public string get_g_total;
        


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9M7SHOQ;Initial Catalog=shippingrecords;Integrated Security=True");
        public string inv_no
        {
            get { return get_invoice; }
            set { get_invoice = value; }
        }
        public string Cust_name { get; set; }
        public string total_ { get; set; }
        
        public string G_total { get; set; }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateTax_Load(object sender, EventArgs e)
        {
            //TaxProperties tpss = new TaxProperties();
            //get_Cust = tpss.Cust_name;
            //txt_cust.Text = get_Cust.ToString();

            //txt_invoice.Text = "" + get_invoice;
            //txt_cust.Text = Cust_name.ToString();
            //txt_total.Text = total_.ToString();
            //textBox1.Text = tax.ToString();
            //txt_g_total.Text = G_total.ToString();

            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Customer_Invoice where Invoice_No = '" + get_invoice + "'", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    txt_invoice.Text = (dr["Invoice_No"].ToString());
            //    txt_cust.Text = (dr["Customer_Name"].ToString());
            //    txt_total.Text = (dr["Total"].ToString());
            //    textBox1.Text = (dr["Tax"].ToString());
            //    txt_g_total.Text = (dr["Grand_Total"].ToString());

            //}
            //con.Close();
        }
    }
}
