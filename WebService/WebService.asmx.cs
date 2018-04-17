using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
        public bool addAssesment(string type, string date)
        {
            return dal.insertStudent(type, date);
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
    }
}
