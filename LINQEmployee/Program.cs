using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEmployee
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {City} ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee { Id=1,Name="Pratik",Salary=2700,City="Nashik"},
                new Employee { Id=2,Name="Kunal",Salary=25000,City="Pune"},
                new Employee { Id=3,Name="Amish",Salary=20000,City="Mumbai"},
                new Employee { Id=4,Name="Joy",Salary=35000,City="Pune"},
                new Employee { Id=5,Name="Pradnesh",Salary=25000,City="Pune"},
                new Employee { Id=6,Name="Karan",Salary=43000,City="Mumbai"},
                new Employee { Id=7,Name="Rohit",Salary=22000,City="Nashik"},
            };

            var result1 = from e in emp
                          select e;
            


            var result2 = from e in emp
                          orderby e.Name
                          select e;
            var res2 = emp.OrderBy(e => e.Name).ToList();//Lambda Expression





            var result3 = from e in emp
                          where e.Salary > 25000
                          select e;
            var res3 = emp.Where(e => e.Salary > 25000).ToList();//Lambda Expression





            var result4 = from e in emp
                          where e.City.Contains("Pune")
                          select e;
            var res4 = emp.Where(e=>e.City.Contains("Pune")).ToList();//Lambda Expression





            var result5 = from e in emp
                          orderby e.Salary descending 
                          select e;
            var res5 = emp.OrderByDescending(e => e.Salary).ToList();//Lambda Expression




            var result6 = from e in emp
                          where e.Name.StartsWith("P")
                          select e;
            var res6 = emp.Where(e => e.Name.StartsWith("P")).ToList();//Lambda Expression




            var result7 = from e in emp
                          where e.Salary>25000 && e.City=="Mumbai"
                          select e;
            var res7 = emp.Where(e => e.Salary > 25000 && e.City.Contains("Mumbai"));//Lambda Expression






            foreach (Employee data in res7)
            {
                Console.WriteLine(data);
            }

        }
    }
}