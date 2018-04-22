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
    public partial class SingleStudentForm : Form
    {
        DAL dal = new DAL();
        public SingleStudentForm()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var fname = this.fname.Text;
            var lname = this.lname.Text;
            if(dal.AddStudent(fname, lname))
            {
                MessageBox.Show("INSERTED SUCCESSFULLY", "MESSAGE");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Location = this.Location;
            mf.Show();
        }
    }
}
