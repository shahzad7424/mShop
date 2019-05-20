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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        String c_Value;
        String c3_Value;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9M7SHOQ;Initial Catalog=shippingrecords;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            in_contain.Show();
            inv_record.Hide();
            cust_contain.Hide();
            pay_contain.Hide();
           
            panel6.Hide();
            if (textBox2.Text=="")
            {
                MessageBox.Show("First You Need To Add Customer Details.");
                in_contain.Hide();
                inv_record.Hide();
                cust_contain.Hide();
                pay_contain.Hide();
              
                panel6.Show();

            }



            if (textBox1.Text != "")
            {
                textBox28.Text = textBox1.Text.ToString();
            }
          
             

            
            clear_rec();
            auto_inv_no();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inv_record.Show();
            in_contain.Hide();
            cust_contain.Hide();
            pay_contain.Hide();
           
            panel6.Hide();


            con.Open();
            SqlCommand cmd = new SqlCommand("Select Invoice_No,Customer_Name from Customer_Invoice Order by Invoice_No DESC ", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
          


        }
        public void auto_inv_no()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select max(Invoice_No)+1 from Customer_Invoice",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "101";
                    }
                }

            }
            else
            {
                textBox1.Text = "101";
            }
            con.Close();

        }
        public void pre_inv_no()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select max(Invoice_No) from Customer_Invoice", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox28.Text = dr[0].ToString();
                    if (textBox28.Text == "")
                    {
                        textBox28.Text = "0";
                    }
                }

            }
            else
            {
                textBox28.Text = "0";
            }
            con.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if  (textBox3.Text != "")
                {
                    if (textBox4.Text != "")
                    {
                        if (textBox5.Text != "")
                        {
                            if (textBox27.Text != "")
                            {
                                if (textBox26.Text != "")
                                {
                                    if (textBox8.Text != "")
                                    {
                                        if (textBox9.Text != "")
                                        {
                                            if (textBox39.Text != "")
                                            {
                                                if (textBox38.Text != "")
                                                {
                                                    if (textBox10.Text != "")
                                                    {
                                                        if (textBox40.Text != "")
                                                        {
                                                               if (textBox11.Text != "")
                                                                {
                                                                    if (textBox12.Text != "")
                                                                    {
                                                                        if (textBox13.Text != "")
                                                                        {
                                                                            if (textBox14.Text != "")
                                                                            {
                                                                                if (textBox15.Text != "")
                                                                                {
                                                                                    if (textBox16.Text != "")
                                                                                    {
                                                                                        if (textBox18.Text != "")
                                                                                        {
                                                                                            if (textBox19.Text != "")
                                                                                            {
                                                                                                con.Open();
                                                                                                SqlCommand cmd = new SqlCommand("insert into Customer_Invoice (Invoice_No,Customer_Name,Mobile_No, [From] ,[1_Place],[2_place],[3_Place],Sender,Receiver,Shipper_Name,Port,Driver_No,Driver_CNIC,Vehical_No,Container_1,Container_2,Quantity,Size,Shipping_Line,Freight,Terminal_Loading,Damurage,Extras,Total,Detail,Tax,Grand_Total) values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox27.Text + "','" + textBox26.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox39.Text + "','" + textBox38.Text + "','" + textBox10.Text + "','" + textBox40.Text + "','" + textBox41.Text + "','" + textBox11.Text + "','" + c_Value.ToString() + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "')", con);
                                                                                                cmd.ExecuteNonQuery();
                                                                                                con.Close();
                                                                                                auto_inv_no();
                                                                                                MessageBox.Show("Information Is Saved.");
                                                                                                clear_rec();
                                                                                                con.Open();
                                                                                                SqlCommand cmd1 = new SqlCommand("select max(Invoice_No)+1 from Customer_Invoice", con);
                                                                                                textBox29.Text = Convert.ToString(cmd1.ExecuteScalar());
                                                                                                con.Close();
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                require18.Visible = true;
                                                                                            }

                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            require17.Visible = true;
                                                                                        }

                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        require16.Visible = true;
                                                                                    }

                                                                                }
                                                                                else
                                                                                {
                                                                                    require15.Visible = true;
                                                                                }

                                                                            }
                                                                            else
                                                                            {
                                                                                require14.Visible = true;
                                                                            }

                                                                        }
                                                                        else
                                                                        {
                                                                            require13.Visible = true;
                                                                        }

                                                                    }
                                                                    else
                                                                    {
                                                                        require12.Visible = true;
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    require10.Visible = true;
                                                                }
                                                          
                                                        }
                                                        else
                                                        {
                                                            label78.Visible = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        require9.Visible = true;
                                                    }
                                                }
                                                else
                                                {
                                                    label70.Visible = true;
                                                }

                                            }
                                            else
                                            {
                                                label72.Visible = true;
                                            }


                                        }
                                        else
                                        {
                                            require8.Visible = true;
                                        }

                                    }
                                    else
                                    {
                                        require7.Visible = true;
                                    }
                                }
                                else
                                {
                                    label36.Visible = true;
                                }
                            }
                            else
                            {
                                label37.Visible = true;
                            }
                        }
                        else
                        {
                            require4.Visible = true;
                        }

                    }
                    else
                    {
                        require3.Visible = true;
                    }

                }
                

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            in_contain.Hide();
            inv_record.Hide();
            cust_contain.Show();
            pay_contain.Hide();
          
            panel6.Hide();

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct Customer_Name from Customer", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
          
        
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        public void clear_rec()
        {
            auto_inv_no();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            textBox8.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox9.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.Text = "----Select One----------";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            button21.Visible = false;
            button8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clear_rec();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                String c_first = "20 Std";
                c_Value = c_first;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                String c_second = "40 Std";
                c_Value = c_second;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                String c_third = "40 HC";
                c_Value = c_third;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Payment pay = new Payment();
            pay.get_name_pay = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            pay.Show();
           
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select Invoice_No,Customer_Name from Customer_Invoice where Invoice_No = '" + dataGridView4.CurrentRow.Cells[0].Value.ToString() + "'", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    txtinvoice.Text = (dr["Invoice_No"].ToString());
            //    txtcust.Text = (dr["Customer_Name"].ToString());
            //}
            //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            in_contain.Hide();
            inv_record.Hide();
            cust_contain.Hide();
            pay_contain.Show();
          
            panel6.Hide();

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Customer_Name from Customer order by Customer_ID DESC", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //int freight = Convert.ToInt16(textBox13.Text);
            //int ter_load = Convert.ToInt16(textBox14.Text);
            //int damurage = Convert.ToInt16(textBox15.Text);
            //int extra = Convert.ToInt16(textBox16.Text);
            //textBox17.Text = Convert.ToString(freight + ter_load + damurage + extra);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            InvoiceReport ir = new InvoiceReport();
           
            ir.get_invoice = textBox1.Text;
            ir.get_name = textBox2.Text;
            ir.get_mobile = textBox3.Text;
            ir.get_to = textBox4.Text;
            ir.get_from1 = textBox5.Text;
            ir.get_from2 = textBox6.Text;
            ir.get_from3 = textBox7.Text;
            ir.get_sender = textBox27.Text;
            ir.get_receiver = textBox26.Text;
            ir.get_shipper = textBox8.Text;
            ir.get_port = textBox9.Text;
            ir.get_driver_no = textBox39.Text;
            ir.get_driver_cnic = textBox38.Text;
            ir.get_container1 = textBox40.Text;
            ir.get_container2 = textBox41.Text;
            ir.get_vehical = textBox10.Text;
            ir.get_quantity = textBox11.Text;
            ir.get_size = comboBox1.Text;
            ir.get_ship_line = textBox12.Text;
            ir.get_frieght = textBox13.Text;
            ir.get_ter_load = textBox14.Text;
            ir.get_damurage = textBox15.Text;
            ir.get_extra = textBox16.Text;
            ir.get_total = textBox17.Text;
            ir.get_detail = textBox18.Text;
            ir.get_tax = textBox19.Text;
            ir.get_g_total = textBox20.Text;
            ir.Show();




        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shippingrecordsDataSet.Customer_Invoice' table. You can move, or remove it, as needed.
            this.customer_InvoiceTableAdapter.Fill(this.shippingrecordsDataSet.Customer_Invoice);
            auto_inv_no();
            con.Open();
            SqlCommand cmd = new SqlCommand("select max(Invoice_No)+1 from Customer_Invoice", con);
            textBox29.Text = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            cust_detail();


        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "" && textBox13.Text != "" && textBox14.Text !="" && textBox11.Text != "")
            {
                decimal quantity = Convert.ToInt64(textBox11.Text);
                decimal freight = Convert.ToInt64(textBox13.Text);
                decimal ter_load = Convert.ToInt64(textBox14.Text);
                textBox17.Text = Convert.ToString( freight * quantity + ter_load);
            }
            if (textBox13.Text != "" && textBox14.Text == "")
            {
                textBox14.Text = "";
            }

            if (textBox14.Text != "")
            {
                require14.Visible = false;
            }
            if (textBox14.Text == "")
            {
                require14.Visible = true;
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text!= "" && textBox11.Text != "")
            {
                decimal quantity = Convert.ToInt64(textBox11.Text);
                decimal freight = Convert.ToInt64(textBox13.Text);
                textBox17.Text = Convert.ToString(quantity * freight);
            }
            if (textBox13.Text == "") 
            {
                textBox13.Text = "";
            }

            if (textBox13.Text != "")
            {
                require13.Visible = false;
            }
            if (textBox13.Text == "")
            {
                require13.Visible = true;
            }

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox11.Text != "") {
                decimal quantity = Convert.ToInt64(textBox11.Text);
                decimal freight = Convert.ToInt64(textBox13.Text);
                decimal ter_load = Convert.ToInt64(textBox14.Text);
                decimal damurage = Convert.ToInt64(textBox15.Text);
                textBox17.Text = Convert.ToString( freight*quantity + ter_load + damurage);
            }
            if (textBox13.Text != "" && textBox14.Text != "" && textBox15.Text == "")
            {
                textBox15.Text = "";
            }

            if (textBox15.Text != "")
            {
                require15.Visible = false;
            }
            if (textBox15.Text == "")
            {
                require15.Visible = true;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "" && textBox11.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "")
            {
                decimal quantity = Convert.ToInt64(textBox11.Text);
                decimal freight = Convert.ToInt64(textBox13.Text);
                decimal ter_load = Convert.ToInt64(textBox14.Text);
                decimal damurage = Convert.ToInt64(textBox15.Text);
                decimal extra = Convert.ToInt64(textBox16.Text);
                textBox17.Text = Convert.ToString( freight * quantity+ ter_load + damurage + extra);
            }
            if (textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text == "")
            {
                textBox16.Text = "";
            }

            if (textBox16.Text != "")
            {
                require16.Visible = false;
            }
            if (textBox16.Text == "")
            {
                require16.Visible = true;
            }
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text!="")
            {
                int tax = Convert.ToInt32(textBox19.Text);
                decimal total = Convert.ToInt64(textBox17.Text);
                textBox20.Text = Convert.ToString(total / 100 * tax + total);
            }
            if (textBox19.Text == "")
            {
                textBox19.Text = "";
            }

            if (textBox19.Text != "")
            {
                require18.Visible = false;
            }
            if (textBox19.Text == "")
            {
                require18.Visible = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void in_contain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          

          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                require3.Visible = false;
                textBox4.BackColor = Color.White;
            }
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red;
                require3.Visible = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                require4.Visible = false;
            }
            if (textBox5.Text == "")
            {
                require4.Visible = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                require7.Visible = false;
            }
            if (textBox8.Text == "")
            {
                require7.Visible = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                require8.Visible = false;
            }
            if (textBox9.Text == "")
            {
                require8.Visible = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                require9.Visible = false;
            }
            if (textBox10.Text == "")
            {
                require9.Visible = true;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                require10.Visible = false;
            }
            if (textBox11.Text == "")
            {
                require10.Visible = true;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                require12.Visible = false;
            }
            if (textBox12.Text == "")
            {
                require12.Visible = true;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "")
            {
                require17.Visible = false;
            }
            if (textBox18.Text == "")
            {
                require17.Visible = true;
            }
        }

        

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            


            //UpdateTax utax = new UpdateTax();
            //utax.Show();
            //UpdateTax ut = new UpdateTax();
            //ut.inv_no = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            //ut.Cust_name = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            //ut.total_ = dataGridView3.CurrentRow.Cells[7].Value.ToString();

            //ut.G_total = dataGridView3.CurrentRow.Cells[9].Value.ToString();


            //con.Open();

            //SqlCommand cmd = new SqlCommand("Select * from Customer_Invoice where Invoice_No = '" + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "'", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{

            //}
            //{
            //    textBox1.Text = (dr["Invoice_No"].ToString());
            //    textBox2.Text = (dr["Customer_Name"].ToString());
            //    textBox3.Text = (dr["Mobile_No"].ToString());
            //    textBox4.Text = (dr["From"].ToString());
            //    textBox5.Text = (dr["1_Place"].ToString());
            //    textBox6.Text = (dr["2_place"].ToString());
            //    textBox7.Text = (dr["3_Place"].ToString());
            //    textBox8.Text = (dr["Shipper_Name"].ToString());
            //    textBox9.Text = (dr["Port"].ToString());
            //    textBox10.Text = (dr["Vehical_No"].ToString());
            //    textBox11.Text = (dr["Quantity"].ToString());
            //    comboBox1.Text  = (dr["Size"].ToString());
            //    textBox12.Text = (dr["Shipping_Line"].ToString());
            //    textBox13.Text = (dr["Freight"].ToString());
            //    textBox14.Text = (dr["Terminal_Loading"].ToString());
            //    textBox15.Text = (dr["Damurage"].ToString());
            //    textBox16.Text = (dr["Extras"].ToString());
            //    textBox17.Text = (dr["Total"].ToString());
            //    textBox18.Text = (dr["Detail"].ToString());
            //    textBox19.Text = (dr["Tax"].ToString());
            //    textBox20.Text = (dr["Grand_Total"].ToString());
            //}
            //con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    con.Open();
        //    SqlCommand cmd1 = new SqlCommand("Select Invoice_No,Quantity,Size,Shipping_Line from Customer_Invoice where Customer_Name ='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ", con);
        //    cmd1.ExecuteNonQuery();
        //    DataTable dt1 = new DataTable();
        //    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        //    da1.Fill(dt1);
        //    dataGridView3.DataSource = dt1;
        //    con.Close();
        //}

        private void button11_Click(object sender, EventArgs e)
        {
           
                con.Open();
                SqlCommand cmd = new SqlCommand("Üpdate Customer_Invoice SET Invoice_No ='"+textBox1.Text+"',Customer_Name ='"+textBox2.Text+"',Mobile_No = '"+textBox3.Text+ "',[From]= '"+textBox4.Text+ "',[1_Place]='"+textBox4.Text+ "',[2_place]='"+textBox5.Text+ "',[3_Place]='"+textBox6.Text + "',[4_Place]='" + textBox7.Text+ "',Shipper_Name='" + textBox8.Text+ "',Port='" + textBox9.Text+ "',Vehical_No='" + textBox10.Text+ "',Quantity='" + textBox11.Text + "',Size='" + comboBox1.Text+ "',Shipping_Line='"+textBox12.Text+ "',Freight='" + textBox13.Text + "',Terminal_Loading='" + textBox14.Text + "',Damurage='" + textBox15.Text + "',Extras='" + textBox16.Text + "',Total='" + textBox17.Text + "',Detail='" + textBox18.Text + "',Tax='" + textBox19.Text + "',Grand_Total='" + textBox20.Text + "' where Invoice_No='"+dataGridView3.CurrentRow.Cells[1].Value.ToString()+"' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Of selected Person.");
                auto_inv_no();
                clear_rec();
          
           
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select payments.Date,payments.Invoice_No,payments.Payment_Method,payments.Amount,payments.Check_No,payments.Check_Status  from payments INNER Join Customer on payments.Customer_Name = Customer.Customer_Name where Customer.Customer_Name = '" + dataGridView4.CurrentRow.Cells[0].Value.ToString()+"' ", con);

            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView5.DataSource = dt1;
            con.Close();
          
           
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            
                if (textBox21.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select  Invoice_No,Customer_Name from Customer_Invoice where Customer_Name = '" + textBox21.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;
                    con.Close();
                }
            
            if(textBox21.Text =="")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Invoice_No,Customer_Name from Customer_Invoice ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                con.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select Date,Invoice_No,Customer_Name,Port,Vehical_No,Quantity,Size,Shipping_Line,Tax,Grand_Total from Customer_Invoice where Date ( Date >= dateadd(day,datediff(day,'"+dateTimePicker1.Text+"',GETDATE()),0)  AND  Date < dateadd(day,datediff(day,0,GETDATE()),1))", con);
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView3.DataSource = dt;
            //con.Close();

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Customer_Name from Customer_Invoice where Customer_Name = '" + textBox22.Text + "' ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            if (textBox22.Text == "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Customer_Name from Customer_Invoice ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Customer_Invoice.Date , Customer_Invoice.Invoice_No, Customer_Invoice.Port, Customer_Invoice.Vehical_No, Customer_Invoice.Quantity, Customer_Invoice.Size, Customer_Invoice.Tax, Customer_Invoice.Grand_Total FROM Customer_Invoice INNER JOIN Customer ON Customer_Invoice.Customer_Name=Customer.Customer_Name where Customer.Customer_Name = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "' ", con);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand comm = new SqlCommand("SELECT Count(Customer_Invoice.Invoice_No) FROM Customer_Invoice INNER JOIN Customer ON Customer_Invoice.Customer_Name = Customer.Customer_Name where Customer.Customer_Name = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", con);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                txt_bill.Text = Convert.ToString(count.ToString()); //For example a Label
            }
            else
            {
                txt_bill.Text = "0";
            }
            SqlCommand comm1 = new SqlCommand("SELECT Sum(Customer_Invoice.Grand_Total) FROM Customer_Invoice INNER JOIN Customer ON Customer_Invoice.Customer_Name=Customer.Customer_Name where Customer.Customer_Name= '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", con);
            string amount = Convert.ToString(comm1.ExecuteScalar());
            txt_b_am.Text = Convert.ToString(amount.ToString());
            SqlCommand comm2 = new SqlCommand("SELECT Count(payments.Invoice_No) FROM payments INNER JOIN Customer ON payments.Customer_Name = Customer.Customer_Name where Customer.Customer_Name  = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", con);
            Int32 count1 = Convert.ToInt32(comm2.ExecuteScalar());
            if (count1 >= 0)
            {
                txt_pay.Text = Convert.ToString(count1.ToString()); //For example a Label
            }
            else
            {
                txt_pay.Text = "0";
            }
            SqlCommand comm3 = new SqlCommand("SELECT Sum(payments.Amount) FROM payments INNER JOIN Customer ON payments.Customer_Name=Customer.Customer_Name where Customer.Customer_Name= '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'  ", con);
            string p_amount = Convert.ToString(comm3.ExecuteScalar());
            txt_p_am.Text = Convert.ToString(p_amount.ToString());
          
          


            con.Close();
            comboBox2.SelectedIndex = 0;
            if (txt_b_am.Text !="" && txt_p_am.Text != "")
            {
                int first = Convert.ToInt32(txt_b_am.Text);
                int second = Convert.ToInt32(txt_p_am.Text);
                txt_remain.Text = Convert.ToString(first - second);
            }
            if (txt_b_am.Text != "" && txt_p_am.Text == "")
            {
                txt_remain.Text = txt_b_am.Text;
            }
            if (txt_b_am.Text == "" && txt_p_am.Text != "")
            {
                txt_remain.Text = txt_p_am.Text;
            }




        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Customer_Name from Customer where Customer_Name = '" + textBox23.Text + "' order by Customer_ID DESC  ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView4.DataSource = dt;
                con.Close();
            }
            if (textBox23.Text == "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Customer_Name from Customer order by Customer_ID DESC ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView4.DataSource = dt;
                con.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel4.Show();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customer_Invoice where Invoice_No = '" + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                get1.Text = (dr["Invoice_No"].ToString());
                get2.Text = (dr["Customer_Name"].ToString());
                get3.Text = (dr["Mobile_No"].ToString());
                get4.Text = (dr["From"].ToString());
                get5.Text = (dr["1_Place"].ToString());
                get6.Text = (dr["2_place"].ToString());
                get7.Text = (dr["3_Place"].ToString());
                get8.Text = (dr["Sender"].ToString());
                get9.Text = (dr["Receiver"].ToString());
                get10.Text = (dr["Shipper_Name"].ToString());
                get11.Text = (dr["Port"].ToString());
                get12.Text = (dr["Driver_No"].ToString());
                get13.Text = (dr["Driver_CNIC"].ToString());
                get14.Text = (dr["Vehical_No"].ToString());
                get15.Text = (dr["Container_1"].ToString());
                get16.Text = (dr["Container_2"].ToString());
                get17.Text = (dr["Quantity"].ToString());
                get18.Text = (dr["Size"].ToString());
                get19.Text = (dr["Shipping_Line"].ToString());
                get21.Text = (dr["Freight"].ToString());
                get22.Text = (dr["Terminal_Loading"].ToString());
                get23.Text = (dr["Damurage"].ToString());
                get24.Text = (dr["Extras"].ToString());
                get25.Text = (dr["Total"].ToString());
                get20.Text = (dr["Detail"].ToString());
                get26.Text = (dr["Tax"].ToString());
                get27.Text = (dr["Grand_Total"].ToString());
                get_28.Text = (dr["Date"].ToString());

            }
              con.Close();

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd1 = new SqlCommand("select Date,Invoice_No,Payment_Method,Amount from payments where Payment_Method='Check'  ", con);
            //cmd1.ExecuteNonQuery();
            //DataTable dt1 = new DataTable();
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            //da1.Fill(dt1);
            //dataGridView5.DataSource = dt1;
            //con.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("  select Distinct payments.Date,payments.Invoice_No,payments.Payment_Method,payments.Amount  from payments INNER Join Customer on payments.Customer_Name = Customer.Customer_Name where Customer.Customer_Name = '"+dataGridView4.CurrentRow.Cells[0].Value.ToString()+"' and payments.Payment_Method = 'Cash' ", con);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView5.DataSource = dt1;
            con.Close();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("  select payments.Date,payments.Invoice_No,payments.Payment_Method,payments.Amount,payments.Check_No,payments.Check_Status  from payments INNER Join Customer on payments.Customer_Name = Customer .Customer_Name where Customer .Customer_Name = '" + dataGridView4.CurrentRow.Cells[0].Value.ToString() + "' and payments.Payment_Method = 'Check' ", con);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView5.DataSource = dt1;
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            up_check_contain.Visible = false;
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.CurrentRow.Cells[2].Value.ToString() == "Check")
            {
                up_check_contain.Visible = true;
                label42.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
             


            }
        }

        private void ch_up_stats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ch_up_stats.SelectedIndex == 0)
            {
                String c_first = "Payed";
                c3_Value = c_first;
            }
            if (ch_up_stats.SelectedIndex == 1)
            {
                String c_second = "Unpayed";
                c3_Value = c_second;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE payments SET Check_Status = '" + c3_Value + "' WHERE Invoice_No = '" + dataGridView5.CurrentRow.Cells[1].Value.ToString() + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            up_check_contain.Visible = false;
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select payments.Date,payments.Invoice_No,payments.Payment_Method,payments.Amount,payments.Check_No,payments.Check_Status  from payments INNER Join Customer on payments.Customer_Name = Customer.Customer_Name where Customer.Customer_Name = '" + dataGridView4.CurrentRow.Cells[0].Value.ToString() + "' ", con);

            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView5.DataSource = dt1;
            con.Close();
        }

      

      

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT Customer_Invoice.Date , Customer_Invoice.Invoice_No, Customer_Invoice.Port, Customer_Invoice.Vehical_No, Customer_Invoice.Quantity, Customer_Invoice.Size, Customer_Invoice.Tax, Customer_Invoice.Grand_Total FROM Customer_Invoice INNER JOIN Customer ON Customer_Invoice.Customer_Name=Customer.Customer_Name where Customer.Customer_Name ='" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "' ", con);
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con.Close();

            }
            if (comboBox2.SelectedIndex == 1)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select  payments.Date,payments.Invoice_No,payments.Payment_Method,payments.Amount,payments.Check_No,payments.Check_Status  from payments INNER Join Customer on payments.Customer_Name = Customer.Customer_Name where Customer.Customer_Name = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "' ", con);

                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con.Close();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            BiltyReport br = new BiltyReport();
           
            br.get1_invoice = textBox1.Text;
            br.get_name = textBox2.Text;
            br.get_mobile = textBox3.Text;
            br.get_to = textBox4.Text;
            br.get_from1 = textBox5.Text;
            br.get_from2 = textBox6.Text;
            br.get_from3 = textBox7.Text;
            br.get_shipper = textBox8.Text;
            br.get_port = textBox9.Text;
            br.get_vehical = textBox10.Text;
            br.get_quantity = textBox11.Text;
            br.get_size = comboBox1.Text;
            br.get_ship_line = textBox12.Text;
            br.Show();
        }

      

      
      

        private void button20_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand comm1 = new SqlCommand("SELECT Max(Invoice_No)+1 FROM Customer_Invoice ", con);
            //Int32 invoice = Convert.ToInt32(comm1.ExecuteScalar());
            //textBox28.Text = Convert.ToString(invoice.ToString());
            //con.Close();

            int auto = Convert.ToInt32(textBox29.Text);
            int fetch = Convert.ToInt32(textBox28.Text);

            if (fetch <= auto)
            {
                textBox28.Text = Convert.ToString(fetch - 1);
                button8.Visible = false;
                button21.Visible = true;
                if (textBox28.Text == "101")
                {
                    button20.Visible = false;
                    MessageBox.Show("101 Is the First Invoice.");
                }
                button19.Visible = true;

            }
        
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //adapter = new SqlDataAdapter("SELECT Invoice_No FROM Customer_Invoice", con);
            //adapter.Fill(table);
            //textBox28.Text =Convert.ToString( pos );
            int auto = Convert.ToInt32(textBox29.Text);
            int fetch = Convert.ToInt32(textBox28.Text);
            int temp = auto - 1;
         
            if (fetch < auto)
            {
               textBox28.Text = Convert.ToString(fetch + 1);
                button20.Visible = true;

            }
            if (fetch == auto)
            {
                MessageBox.Show("Invoice No "+ temp + " is the Last Invoice. ");
                button19.Visible = false;
                auto_inv_no();
                clear_rec();
                button8.Visible = true;
                button21.Visible = false;
            }
           

            //double first = Convert.ToDouble(textBox1.Text);
            //double second = Convert.ToDouble(textBox28.Text);

            //if (second < first)
            //{
            //    textBox28.Text = Convert.ToString(second+1);
            //    button20.Visible = true;

            //}
            //if (textBox28.Text == textBox1.Text)
            //{
            //    button19.Visible = false;

            //}
            //con.Open();
            //SqlCommand comm1 = new SqlCommand("SELECT Max(Invoice_No)+1 FROM Customer_Invoice ", con);
            //Int32 invoice = Convert.ToInt32(comm1.ExecuteScalar());
            //textBox28.Text = Convert.ToString(invoice.ToString());
            //con.Close();

            //SqlCommand comm2 = new SqlCommand("SELECT COUNT(Customer_Name) FROM payments where Customer_Name = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", con);
            //Int32 count1 = Convert.ToInt32(comm2.ExecuteScalar());
            //if (count1 > 0)
            //{
            //    txt_pay.Text = Convert.ToString(count1.ToString()); //For example a Label
            //}
            //else
            //{
            //    txt_pay.Text = "0";
            //}

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customer_Invoice where Invoice_No = '" + textBox28.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = (dr["Invoice_No"].ToString());
                textBox2.Text = (dr["Customer_Name"].ToString());
                textBox3.Text = (dr["Mobile_No"].ToString());
                textBox4.Text = (dr["From"].ToString());
                textBox5.Text = (dr["1_Place"].ToString());
                textBox6.Text = (dr["2_place"].ToString());
                textBox7.Text = (dr["3_Place"].ToString());
                textBox27.Text = (dr["Sender"].ToString());
                textBox26.Text = (dr["Receiver"].ToString());
                textBox8.Text = (dr["Shipper_Name"].ToString());
                textBox9.Text = (dr["Port"].ToString());
                textBox39.Text = (dr["Driver_No"].ToString());
                textBox38.Text = (dr["Driver_CNIC"].ToString());
                textBox10.Text = (dr["Vehical_No"].ToString());
                textBox40.Text = (dr["Container_1"].ToString());
                textBox41.Text = (dr["Container_2"].ToString());
                textBox11.Text = (dr["Quantity"].ToString());
                comboBox1.Text = (dr["Size"].ToString());
                textBox12.Text = (dr["Shipping_Line"].ToString());
                textBox13.Text = (dr["Freight"].ToString());
                textBox14.Text = (dr["Terminal_Loading"].ToString());
                textBox15.Text = (dr["Damurage"].ToString());
                textBox16.Text = (dr["Extras"].ToString());
                textBox17.Text = (dr["Total"].ToString());
                textBox18.Text = (dr["Detail"].ToString());
                textBox19.Text = (dr["Tax"].ToString());
                textBox20.Text = (dr["Grand_Total"].ToString());

            }



            con.Close();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double auto = Convert.ToDouble(textBox29.Text);
            double fetch = Convert.ToDouble(textBox28.Text);
            if (fetch < auto)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Customer_Invoice set Customer_Name = '"+textBox2.Text+"', Mobile_No='"+textBox3.Text+ "', [From]='" + textBox4.Text + "', [1_Place]='" + textBox5.Text + "', [2_place]='" + textBox6.Text + "', [3_Place]='" + textBox7.Text + "',Sender='" + textBox27.Text + "',Receiver='" + textBox26.Text + "', Shipper_Name='" + textBox8.Text + "',Port='" + textBox9.Text + "',Driver_No='" + textBox39.Text + "',Driver_CNIC='" + textBox38.Text + "',Vehical_No='" + textBox10.Text + "',Container_1='" + textBox40.Text + "',Container_2='" + textBox41.Text + "',Quantity='" + textBox11.Text + "', Size='" + c_Value + "', Shipping_Line='" + textBox12.Text + "', Freight='" + textBox13.Text + "',Terminal_Loading='" + textBox14.Text + "',Damurage='" + textBox15.Text + "',Extras='" + textBox16.Text + "',Total='" + textBox17.Text + "',Detail='" + textBox18.Text + "',Tax='" + textBox19.Text + "',Grand_Total='" + textBox20.Text + "' where Invoice_No = '" + textBox1.Text+"' ",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Incoice No "+textBox1.Text+" Is Updated");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel11.Hide();
            auto_cust_id();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel11.Show();
            panel7.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            in_contain.Hide();
            inv_record.Hide();
            cust_contain.Hide();
            pay_contain.Hide();
            
            panel6.Show();
            cust_detail();
         }
        public void cust_detail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Customer_ID,Customer_Name from Customer Order by Customer_ID DESC", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView9.DataSource = dt;
            con.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
                if (textBox30.Text != "")
                {
                    if (textBox31.Text != "")
                    {
                        if (textBox36.Text != "")
                        {
                          con.Open();
                          SqlCommand cmd = new SqlCommand("Insert into Customer (Customer_ID,Customer_Name,Mobile_No,STN,NTN,Email,Web,CNIC,Address) values('" + textBox37.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "','" + richTextBox1.Text + "')", con);
                          cmd.ExecuteNonQuery();
                          con.Close();
                          clear_rec_detail();
                          panel7.Hide();
                          cust_detail();
                        }else
                                        {
                                            require36.Visible = true;
                                        }
                    } 
                    else
                    {
                        require31.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Fields are Empty");
                    require30.Visible = true;
                }
          

        }
        public void clear_rec_detail()
        {
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            richTextBox1.Text = "";
        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            clear_rec_detail();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if(textBox30.Text != "")
            {
                require30.Visible = false;
            }
            if (textBox30.Text == "")
            {
                require30.Visible = true;
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text != "")
            {
                require31.Visible = false;
            }
            if (textBox31.Text == "")
            {
                require31.Visible = true;
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text != "")
            {
                require36.Visible = false;
            }
            if (textBox36.Text == "")
            {
                require36.Visible = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
        public void auto_cust_id()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select max(Customer_ID)+1 from Customer", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox37.Text = dr[0].ToString();
                    if (textBox37.Text == "")
                    {
                        textBox37.Text = "01";
                    }
                }

            }
            else
            {
                textBox37.Text = "01";
            }
            con.Close();

        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel11.Show();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where Customer_ID = '"+dataGridView9.CurrentRow.Cells[0].Value.ToString()+"' ",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cust_name.Text = (dr["Customer_Name"].ToString());
                cust_no.Text = (dr["Mobile_No"].ToString());
                cust_stn.Text = (dr["STN"].ToString());
                cust_ntn.Text = (dr["NTN"].ToString());
                cust_email.Text = (dr["Email"].ToString());
                cust_web.Text = (dr["Web"].ToString());
                cust_cnic.Text = (dr["CNIC"].ToString());
                cust_address.Text = (dr["Address"].ToString());
            }
            con.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            in_contain.Show();
            inv_record.Hide();
            cust_contain.Hide();
            pay_contain.Hide();
           
            panel6.Hide();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where Customer_ID = '" + dataGridView9.CurrentRow.Cells[0].Value.ToString() + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = (dr["Customer_Name"].ToString());
                textBox3.Text = (dr["Mobile_No"].ToString());
               
            }
            con.Close();
        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Statment st = new Statment();
                st.get_statment_of = "Bill Invoices";
                st.get_custname = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                st.Show();

            }
            if (comboBox2.SelectedIndex == 1)
            {
                Statment st = new Statment();
                st.get_statment_of = "Payment Invoices";
                st.get_custname = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                st.Show();

            }
        }
    }
}
