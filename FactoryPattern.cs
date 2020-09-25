using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   
   public enum EmployeeType
   {
        Manager = 0,
        Director = 1
   }
   public interface Employee
   {
        
        String Name { get; set; }
        int Id { get; set; }
        double Salary(int baseSalary);
    }

    public class Manager : Employee
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public double Salary(int baseSalary)
        {
            return baseSalary * 25;
        }
        public Manager(int id)
        {
            Name = "Manager Name";
            Id = id;
        }
    }

    public class Director : Employee
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public double Salary(int baseSalary)
        {
            return baseSalary * 10;
        }
        public Director(int id)
        {
            Name = "Director Name";
            Id = id;
        }
    }

    public class EmployeeFactory
    {
        public Employee GetEmployee(EmployeeType type, int empId)
        {
            switch(type)
            {
                case EmployeeType.Manager: return (new Manager(empId));
                   
                case EmployeeType.Director: return (new Director(empId));
                   
            }
            return null;
        }
    }

    class Management
    {
        static int IDCount = 0;
        public static void Main(string[] args)
        {
            EmployeeFactory employeeFactory = new EmployeeFactory();
            Employee manager = employeeFactory.GetEmployee(EmployeeType.Manager,IDCount++);
            Console.WriteLine("Manager Salary " + manager.Salary(25));
            Console.WriteLine("Manager ID " + manager.Id );
            Console.WriteLine("Manager Name " + manager.Name);
            Employee director = employeeFactory.GetEmployee(EmployeeType.Director, IDCount++);
            Console.WriteLine("Director Salary " + director.Salary(25));
            Console.WriteLine("Director ID " + director.Id);
            Console.WriteLine("Director Name " + director.Name);
            Console.ReadKey();
        }
    }

  
}
