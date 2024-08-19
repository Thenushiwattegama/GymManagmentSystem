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
    public partial class TRAINNER : Form
    {
        public TRAINNER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Trainner values(@id,@name,@age)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox1.Text));
            





            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");


            con.Open();


            SqlCommand cnn = new SqlCommand("insert into Trainner values(@id,@name,@age)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox1.Text));
            





            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TRAINNER_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from Trainner", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=Gym;Integrated Security=True;Encrypt=False");


            con.Open();

            SqlCommand cnn = new SqlCommand("delete Trainner where id=@id", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
