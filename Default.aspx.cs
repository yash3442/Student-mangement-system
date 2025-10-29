using System;
using System.Data;
using System.Xml;

namespace StudentManagementSystem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("~/App_Data/students.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlElement student = doc.CreateElement("Student");

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = txtName.Text;
            student.AppendChild(name);

            XmlElement enroll = doc.CreateElement("Enrollment");
            enroll.InnerText = txtEnroll.Text;
            student.AppendChild(enroll);

            XmlElement dept = doc.CreateElement("Department");
            dept.InnerText = txtDept.Text;
            student.AppendChild(dept);

            doc.DocumentElement.AppendChild(student);
            doc.Save(filePath);

            txtName.Text = txtEnroll.Text = txtDept.Text = "";
        }
    }
}
