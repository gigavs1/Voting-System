using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace logIn
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\Desktop\PROJECT (VOTING)\Database1.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from logIn where username = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
            OleDbDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {

                count++;

            }
            {
                if (count == 1)
                {

                    MessageBox.Show("Log In Successful");

                   message from = new message();

                    from.Show();

                    this.Hide();

                }

                else
                {

                    MessageBox.Show("ERORR");

                }



                conn.Close();
            }
        }
    }
}
