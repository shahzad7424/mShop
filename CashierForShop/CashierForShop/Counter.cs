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
    public partial class Counter : Form
    {
        public Counter()
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
            SqlCommand cmd = new SqlCommand("Select Item,Quantity,Price from NewItem order by ID DESC", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }
        private void Counter_Load(object sender, EventArgs e)
        {
            getdata();
            serachdata("");
        }
        public void serachdata(string value)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Item,Quantity,Price from NewItem where Item Like '%" + textBox1.Text+"%'",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
             
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 174, 219);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serachdata(textBox1.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = "1";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (label4.Text !="" && textBox2.Text!="")
            {
                
                int qty =Convert.ToInt32 (textBox2.Text);
                int price = Convert.ToInt32(label4.Text);
                label4.Text = Convert.ToString (price*qty );
            }
            else if(textBox2.Text == "" && label4.Text!="")
            {
                label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = "1";
                int qty = Convert.ToInt32(textBox2.Text);
                int price = Convert.ToInt32(label4.Text);
                label4.Text = Convert.ToString(price * qty);
            }
        }
    }
}
