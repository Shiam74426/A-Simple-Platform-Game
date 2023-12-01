using Platform_Game;
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

namespace platform_game
{
    public partial class Login : Form
    {
        functionCall aForm = new functionCall();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GTCAF1U\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        private void X_Click(object sender, EventArgs e)
        {
            StartingPage form = new StartingPage();
            form.Show();
            this.Hide();

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            String userName, passWord;
            userName = userName_log.Text;
            passWord = passWord_log.Text;
            SqlConnection sqlConnection = aForm.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("select * from Reg where Username=@Username and Password = @Password",aForm.GetSqlConnection());
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
                userName = userName_log.Text;
                passWord = passWord_log.Text;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("incorrect username or password");
                userName_log.Clear();
                userName_log.Focus();
                passWord_log.Clear();
                //return;
            }


            //conn.Close();

        }

    
    }
}
