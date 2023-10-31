using Platform_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace platform_game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GTCAF1U\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");

        private void X_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Reg where Username=@Username and Password = @Password", conn);
            cmd.Parameters.AddWithValue("@Username", userName_log.Text);
            
            cmd.Parameters.AddWithValue("@Password", passWord_log.Text);
            if (userName_log.Text == "")
            {
                MessageBox.Show("Enter Username");

            }
            else if (passWord_log.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                //MessageBox.Show("Log in completed");
                userName_log.Clear();
                passWord_log.Clear();
                

            }
            else
            {
                MessageBox.Show("incorrect username or password");
                return;
            }
            //conn.Close();
            
            conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
    
}
