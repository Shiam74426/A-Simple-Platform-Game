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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace platform_game
{
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();

        }
        SqlConnection conn= new SqlConnection("Data Source=DESKTOP-GTCAF1U\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (userName_reg.Text.Trim()=="" )
            {
                MessageBox.Show("Enter your username");
                return;
            }
            if (passWord_reg.Text.Trim() == "")
            {
                MessageBox.Show("Enter your password");
                return;
            }
            if (email.Text.Trim() == "")
            {
                MessageBox.Show("Enter your email");
                return;
            }
            
            try
            {
                conn.Open();
                var insertQuery = "insert into Reg values(@Username,@Password,@Email,@Mobile)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Username", userName_reg.Text);
                cmd.Parameters.AddWithValue("@Password", passWord_reg.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Mobile", mobileNumber.Text);
                
                cmd.ExecuteNonQuery();
                conn.Close();
                userName_reg.Clear();
                passWord_reg.Clear();
                email.Clear();
                mobileNumber.Clear();
                
                MessageBox.Show("Registration completed");
            }
            catch
            {

                MessageBox.Show("error");

            }


        }

        
    }
}
