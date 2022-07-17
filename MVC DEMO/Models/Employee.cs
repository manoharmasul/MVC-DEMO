using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DEMO.Models
{
    public class Employee
    {
        //auto implimented property
        public int Id { get; set; }
        public string Name { get; set; }

        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
