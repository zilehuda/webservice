using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CommonClasses;
namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        DAL dal = new DAL();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public bool addStudent(string fname, string lname)
        {
            return dal.insertStudent(fname, lname);
        }

        [WebMethod]
        public void addMultipleStudents(List<Students> students)
        {
            dal.InsertMutipleStudents(students);
        }

       

        [WebMethod]
        public bool addAssesment(string type, string date,string marks)
        {
            return dal.insertAssesment(type, date,marks);
        }
        [WebMethod]
        public bool addmarks(string studentid,string assesid,string marks)
        {
            return dal.insertMarks(studentid, assesid, marks);
        }

        [WebMethod]
        public string getGrade(string studentid)
        {
            return dal.generateGrade(studentid);
        }

        [WebMethod]
        public DataTable getSheet()
        {
            
            DBHelper dbhelper = new DBHelper();
            DataTable dt = dbhelper.ExecuteDataTable("Select * from dbo.Student");
            return dt;

        }

    }
}
