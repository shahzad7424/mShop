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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9M7SHOQ;Initial Catalog=shippingrecords;Integrated Security=True");
        string c_value;
        string c1_value;


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into payments(Invoice_No,Customer_Name,Payment_Method,Amount) values('" + txt1.Text + "','" + textBox1.Text + "','" + c_value + "','" + textBox2.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into payments(Invoice_No,Customer_Name,Payment_Method,Amount,Check_No,Check_Status) values('" + txt1.Text + "','" + textBox1.Text + "','" + c_value + "','" + textBox2.Text + "','" + textBox3.Text + "','" + c1_value + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }



                auto_inv_no();
            this.Close();
        }
        public void auto_inv_no()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select max(Invoice_No)+1 from payments", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txt1.Text = dr[0].ToString();
                    if (txt1.Text == "")
                    {
                        txt1.Text = "101";
                    }
                }

            }
            else
            {
                txt1.Text = "101";
            }
            con.Close();

        }
        public string get_name_pay;

        private void Payment_Load(object sender, EventArgs e)
        {
            textBox1.Text = get_name_pay;
            auto_inv_no();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                String c_first = "Cash";
                c_value = c_first;
                label6.Visible = false;
                label7.Visible = false;
                textBox3.Visible = false;
                comboBox2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                String c_second = "Check";
                c_value = c_second;
                label6.Visible = true;
                label7.Visible = true;
                textBox3.Visible = true;
                comboBox2.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                String c_first = "Payed";
                c1_value = c_first;
            
            }
            if (comboBox1.SelectedIndex == 1)
            {
                String c_second = "Unpayed";
                c1_value = c_second;
               
            }
        }
    }
}
