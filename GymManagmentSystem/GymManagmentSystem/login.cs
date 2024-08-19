using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GymManagmentSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");
            con.Open();
            string userid = txtUser.Text;
            string password = txtPass.Text;
            SqlCommand cmd = new SqlCommand("select userName,password from login where UserName='" + txtUser.Text + "'and Password='" + txtPass.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Home");
                Main main = new Main();
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login sucess Welcome to Home");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
