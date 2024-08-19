using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagmentSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registation registation = new Registation();
            registation.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GYM gym = new GYM();
            gym.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TRAINNER trainner = new TRAINNER();
            trainner.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rates rates = new Rates();
            rates.Show();
        }
    }
}
