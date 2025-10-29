using System;
using System.Data;
using System.Xml;

namespace StudentManagementSystem
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string filePath = Server.MapPath("~/App_Data/students.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}
