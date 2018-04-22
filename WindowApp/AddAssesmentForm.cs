using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowApp
{
    public partial class AddAssesmentForm : Form
    {
        DAL dal = new DAL();
        public AddAssesmentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void assdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void assdate_Enter_1(object sender, EventArgs e)
        {
            if (assdate.Text == "02-01-2014")
            {
                assdate.Text = "";
            }

        }

        private void assdate_Leave(object sender, EventArgs e)
        {
            

        }

        private void btn_insert(object sender, EventArgs e)
        {

            if (dal.AddAssesment(asstype.Text,assdate.Text,totalmarks.Text))
            {
                MessageBox.Show("INSERTED SUCCESSFULLY", "MESSAGE");
            }
        }
    }
}
