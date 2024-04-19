using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTreeDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double Salary { get; set; }
        public bool IsMarried { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

}
