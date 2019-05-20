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
    public partial class Statment : Form
    {
        public Statment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9M7SHOQ;Initial Catalog=shippingrecords;Integrated Security=True");

        public string get_custname;
        public string get_statment_of;
        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statment_Load(object sender, EventArgs e)
        {
            txt6.Text = DateTime.Now.Date.ToShortDateString();
            txt2.Text = get_custname;
            txt8.Text = get_statment_of;
            if (txt8.Text == "Bill Invoices")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Customer where Customer_Name = '"+txt2.Text+"'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt1.Text = (dr["Customer_ID"].ToString());
                    txt3.Text = (dr["Mobile_No"].ToString());
                    txt4.Text = (dr["CNIC"].ToString());
                }
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT Customer_Invoice.Date, Customer_Invoice.Invoice_No AS Invoice , Customer_Invoice.Quantity, Customer_Invoice.Size, Customer_Invoice.Tax, Customer_Invoice.Grand_Total AS GrandTotal FROM Customer_Invoice INNER JOIN Customer ON Customer_Invoice.Customer_Name=Customer.Customer_Name where Customer.Customer_Name = '" + txt2.Text + "' ", con);
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con.Close();
            }
            if (txt8.Text == "Payment Invoices")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Customer where Customer_Name = '" + txt2.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt1.Text = (dr["Customer_ID"].ToString());
                    txt3.Text = (dr["Mobile_No"].ToString());
                    txt4.Text = (dr["CNIC"].ToString());
                }
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select  payments.Date,payments.Invoice_No AS Invoice,payments.Payment_Method AS PaymentMethod,payments.Amount,payments.Check_No AS CheckNo,payments.Check_Status AS CheckStatus  from payments INNER Join Customer on payments.Customer_Name = Customer.Customer_Name where Customer.Customer_Name = '" + txt2.Text + "' ", con);
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con.Close();
            }
        }
    }
}
