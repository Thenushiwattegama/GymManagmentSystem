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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagmentSystem
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3UBUIC9\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Contact values(@FullName,@Email,@Message)", con);

            cnn.Parameters.AddWithValue("@FullName", textBox1.Text);
            cnn.Parameters.AddWithValue("@Email", textBox2.Text);
            cnn.Parameters.AddWithValue("@Message", richTextBox1.Text);
            






            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
