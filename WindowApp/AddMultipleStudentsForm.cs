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
    public partial class AddMultipleStudentsForm : Form
    {
        
        List<Students> stlist = new List<Students>();
        public AddMultipleStudentsForm()
        {
            InitializeComponent();
        }
        int A = 4;
        private void AddMultipleStudentsForm_Load(object sender, EventArgs e)
        {
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentToList();
            AddNewStudent();  
        }

        private void AddStudentToList()
        {
            Students st = new Students();
            st.Fname = fname.Text;
            st.Lname = lname.Text;
            stlist.Add(st);
        }
        private void AddNewStudent()
        {
            dataGridView1.Rows.Add(fname.Text, lname.Text);
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            fname.Text = "";
            lname.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.AddMulStudents(stlist);
        }
    }
}
