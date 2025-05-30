using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JqueryTutorial.Models;
using System.Web.Script.Serialization;

namespace JqueryTutorial
{
    public partial class WE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string jsonString = "[{\"firstName\":\"Jane\",\"lastName\":\"Smith\",\"age\":30,\"gender\":\"Female\",\"salary\":60000},{\"firstName\":\"John\",\"lastName\":\"Doe\",\"age\":30,\"gender\":\"Male\",\"salary\":50000}]";

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<Employee> employee = (List<Employee>)javaScriptSerializer.Deserialize(jsonString, typeof(List<Employee>));

            foreach (Employee emp in employee) { 
                Response.Write("First Name: " + emp.firstName + "<br/>");
                Response.Write("Last Name: " + emp.lastName + "<br/>");
                Response.Write("Age: " + emp.age + "<br/>");
                Response.Write("Gender: " + emp.gender + "<br/>");
                Response.Write("Salary: " + emp.salary + "<br/><br/>");
            }
        }
    }
}