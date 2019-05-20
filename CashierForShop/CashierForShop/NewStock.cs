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

namespace CashierForShop
{
    public partial class NewStock : Form
    {
        public NewStock()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahzad\source\repos\CashierForShop\CashierForShop\Database.mdf;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from NewItem order by ID DESC", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            con.Close();


        }



        private void NewStock_Load(object sender, EventArgs e)
        {
          

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Category from Category ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Category", typeof(string));
            dt.Load(dr);

            comboBox1.ValueMember = "Category";
            comboBox1.DisplayMember = "Category";
            comboBox1.DataSource = dt;

            con.Close();
            comboBox1.Text = "------Select Category---------";

            getdata();




        }

      

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into NewItem (Item,Quantity,Price,Category) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Item is Added to the Stock.");
            getdata();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "------Select Category---------";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Category (Category) values('" + textBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Category Added in the List. ");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Category from Category ", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Category", typeof(string));
            dt.Load(dr);

            comboBox1.ValueMember = "Category";
            comboBox1.DisplayMember = "Category";
            comboBox1.DataSource = dt;

            con.Close();
            comboBox1.Text = "------Select Category---------";
        }
    }
}
