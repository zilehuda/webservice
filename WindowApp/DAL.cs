using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using System.Data;

namespace WindowApp
{
    class DAL
    {
        GradeService.WebServiceSoapClient client =
            new GradeService.WebServiceSoapClient();

        public bool AddStudent(string fname, string lname)
        {
            return client.addStudent(fname, lname);
        }

        public bool AddAssesment(string type,string date,string totalmarks)
        {
            return client.addAssesment(type, date, totalmarks);
        }

        public void AddMulStudents(List<Students>st)
        {
            Students[] student = new Students[st.Count];

            for (int i = 0; i < st.Count; i++)
            {
                student[i] = st[i];
            }
            client.addMultipleStudents(student);
        }

        public void AddMarks(List<Students> st,string assesid)
        {
            Students[] student = new Students[st.Count];

            for (int i = 0; i < st.Count; i++)
            {
                student[i] = st[i];
            }
            client.addmarks(student, assesid);
        }

        public DataTable getGrades()
        {
            ServiceReference1.WebServiceSoapClient ss =
                new ServiceReference1.WebServiceSoapClient();
            return ss.getGrade();
        }

        public DataTable getsheet()
        {
            ServiceReference1.WebServiceSoapClient ss =
                new ServiceReference1.WebServiceSoapClient();
            return ss.getSheet();
        }

    }
}
