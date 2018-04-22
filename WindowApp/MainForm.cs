using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
namespace WindowApp
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingleStudentForm ssf = new SingleStudentForm();
            ssf.Location = this.Location;
            ssf.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAssesmentForm ssf = new AddAssesmentForm();
            ssf.Location = this.Location;
            ssf.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradeForm ssf = new GradeForm();
            ssf.Location = this.Location;
            ssf.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMultipleStudentsForm form = new AddMultipleStudentsForm();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GenerateSheetForm form = new GenerateSheetForm();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddAssesMarksForm form = new AddAssesMarksForm();
            this.Hide();
            form.Show();
        }
    }
}
