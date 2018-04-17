using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebService
{
    public  class DAL
    {
        
        public bool insertStudent(string fname,string lname)
        {
            DBHelper dbhelper = new DBHelper();
            string query = "INSERT INTO STUDENT VALUES ('" + fname + "','" + lname + "')";
            bool res = dbhelper.ExecuteNonQuery(query);
            return res;
        }

        public bool insertAssesment(string type, string date)
        {
            DBHelper dbhelper = new DBHelper();
            string query = "INSERT INTO Assesment VALUES ('" + type + "','" + date + "')";
            return dbhelper.ExecuteNonQuery(query);
        }

        public bool insertMarks(string studentid, string assesid,string marks)
        {
            DBHelper dbhelper = new DBHelper();
            string query = "INSERT INTO StudentAssesment VALUES ('" + studentid + "','" + assesid + "','"+marks+"')";
            return dbhelper.ExecuteNonQuery(query);
        }
        public string generateGrade(string studentid)
        {
            DBHelper dbhelper = new DBHelper();
            string query = "Select sum(marks) from dbo.StudentAssesment where studentid ='"+studentid+"'";
            string count = dbhelper.ExecuteScalar(query);
            double total = Convert.ToDouble(count);
            string grade = "";
            if (total>=70)
            {
                grade = "B";
            }
            return grade;
        }
        public void insertMultipleMarks()
        {

        }


        public void printGradeSheet()
        {

        }

    }
}