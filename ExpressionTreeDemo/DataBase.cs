using ExpressionTreeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTreeDemo
{
    public class DataBase
    {
        public static List<Employee> GetEmployees() =>
            new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "Zhangsan",
                    Age = 18,
                    Gender = Gender.Male,
                    Salary = 5900,
                    IsMarried = false
                },
                new Employee
                {
                    Id = 2,
                    Name = "Tom",
                    Age = 19,
                    Gender = Gender.Female,
                    Salary = 31000,
                    IsMarried = false
                },
                new Employee
                {
                    Id = 3,
                    Name = "Courtney",
                    Age = 20,
                    Gender = Gender.Female,
                    Salary = 4000,
                    IsMarried = false
                },
                new Employee
                {
                    Id = 4,
                    Name = "James",
                    Age = 21,
                    Gender = Gender.Male,
                    Salary = 6700,
                    IsMarried = false
                },
                new Employee
                {
                    Id = 5,
                    Name = "Harry",
                    Age = 22,
                    Gender = Gender.Male,
                    Salary = 3000,
                    IsMarried = false
                },
                new Employee
                {
                    Id = 6,
                    Name = "Lisi",
                    Age = 23,
                    Gender = Gender.Female,
                    Salary = 12500,
                    IsMarried = true
                },
                new Employee
                {
                    Id = 7,
                    Name = "Wangwu",
                    Age = 24,
                    Gender = Gender.Male,
                    Salary = 5900,
                    IsMarried = false
                },
                new Employee
                {
                    Id = 8,
                    Name = "Zhaoliu",
                    Age = 25,
                    Gender = Gender.Male,
                    Salary = 20000,
                    IsMarried = true
                },

            };


    }
}
