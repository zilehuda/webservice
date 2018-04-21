using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CommonClasses;
namespace WebService
{
    public  class DAL
    {
        
        public bool insertStudent(string fname,string lname)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["@fname"] = fname;
            dic["@lname"] = lname;
            DBHelper dbhelper = new DBHelper();
            string query = "INSERT INTO STUDENT VALUES (@fname,@lname)";
            bool res = dbhelper.ExecuteNonQuery(query,dic);
            return res;
        }

        public bool insertAssesment(string type, string date,string marks)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["@type"] = type;
            dic["@date"] = date;
            dic["@marks"] = marks;
            DBHelper dbhelper = new DBHelper();
            string query = "INSERT INTO Assesment VALUES (@type,@date,@marks)";
            return dbhelper.ExecuteNonQuery(query,dic);
        }
        public void insertMultipleMarks(List<Students> students,string assesid)
        {
            DBHelper dbhelper = new DBHelper();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (Students student in students)
            {
                dic["@studentid"] = student.Id;
                dic["@marks"] = student.Marks;
                dic["@assesid"] = assesid;
                string query = "INSERT INTO StudentAssesment VALUES (@studentid,@assesid,@marks)";
                bool res = dbhelper.ExecuteNonQuery(query, dic);
            }
        }
        public DataTable generateGrade()
        {
            string query = "select fname,sum(marks) as obtained from Student inner join StudentAssesment on Student.studentid = StudentAssesment.studentid group by fname";
            DBHelper dbhelper = new DBHelper();
            DataTable dt = dbhelper.ExecuteDataTable(query);
            return dt;
        
        }

        public void InsertMutipleStudents(List<Students> students)
        {
            DBHelper dbhelper = new DBHelper();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach(Students student in students)
            {
                dic["@fname"] = student.Fname;
                dic["@lname"] = student.Lname;
                string query = "INSERT INTO STUDENT VALUES (@fname,@lname)";
                bool res = dbhelper.ExecuteNonQuery(query,dic);
            }
        }

        public DataTable printGradeSheet()
        {
            string query = "select fname,sum(marks) as obtained,sum(totalmark) as total,(sum(marks)/sum(totalmark))*100 as percentage from student s,StudentAssesment sa,Assesment a where s.studentid = sa.studentid group by fname";
            DBHelper dbhelper = new DBHelper();
            DataTable dt = dbhelper.ExecuteDataTable(query);
            return dt;
            //select fname,sum(marks) as obtained,
//sum(totalmark) as "total marks",
//(sum(marks)/sum(totalmark))*100 as percentage
//from student s,StudentAssesment sa,Assesment a
//where s.studentid = sa.studentid and sa.assesid = a.assesid
//group by fname
        }

    }
}