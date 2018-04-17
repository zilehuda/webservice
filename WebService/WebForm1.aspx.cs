﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBHelper dbhelper = new DBHelper();
            //dbhelper.ExecuteScalar();
            DataTable dt = dbhelper.ExecuteDataTable("Select * from dbo.Student");
            DAL dal = new DAL();
            //dal.insertStudent("zilehuda", "tariq");
            dal.insertAssesment("mids", "01-02-2012");
            string count = dbhelper.ExecuteScalar("Select count(*) from dbo.Student");
            lblText.Text = count;

        }
    }
}