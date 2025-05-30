using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace JqueryTutorial.Models
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int age { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
    }
}