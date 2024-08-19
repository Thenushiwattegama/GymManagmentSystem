using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagmentSystem
{
    public partial class Registation : Form
    {
        public Registation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3UBUIC9\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Registation values(@FirstName,@LastName,@Email,@Password)", con);

            cnn.Parameters.AddWithValue("@FirstName", textBox1.Text);
            cnn.Parameters.AddWithValue("@LastName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Email", textBox3.Text);
            cnn.Parameters.AddWithValue("@Password", textBox4.Text);






            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added Successfully", "Registation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
