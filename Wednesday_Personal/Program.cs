using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Personal
{

   
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Akhi", Salary = 5000, Experience = 2 });
            empList.Add(new Employee() { ID = 102, Name = "Bindu", Salary = 9000, Experience = 15 });
            empList.Add(new Employee() { ID = 103, Name = "Hira", Salary = 8000, Experience = 5 });
            empList.Add(new Employee() { ID = 104, Name = "Dayal", Salary = 10000, Experience = 20 });

            Employee.PromoteEmployee(empList);
            Console.ReadLine();

        }

    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " promoted");
                    
                }
            }
        }

    }


}
