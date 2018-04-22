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
    public partial class AddAssesMarksForm : Form
    {
        List<Students> stlist = new List<Students>();
        public AddAssesMarksForm()
        {
            InitializeComponent();
        }

        private void AddAssesMarksForm_Load(object sender, EventArgs e)
        {

        }

        private void newstd_btn_Click(object sender, EventArgs e)
        {
            AddStudentToList();
            AddNewStudent();  
        }
        string _assid = "";
        private void AddStudentToList()
        {
            Students st = new Students();
            st.Id = studentid.Text;
            st.Marks = markid.Text;
            _assid = assid.Text;
            stlist.Add(st);
        }
        private void AddNewStudent()
        {
            dataGridView1.Rows.Add(studentid.Text, markid.Text);
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            studentid.Text = "";
            assid.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.AddMarks(stlist, "3");
        }
    }
}
