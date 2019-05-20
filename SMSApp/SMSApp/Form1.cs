using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                Stream s = wc.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=gKed7s6jQdieK9lSU3sXdQ==&to={0}&content={1}", textBox1.Text,textBox2.Text));
                StreamReader sr = new StreamReader(s);
                string result = sr.ReadToEnd();
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
