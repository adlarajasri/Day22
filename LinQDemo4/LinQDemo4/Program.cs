using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeesList = new List<Employee>();

            EmployeesList.Add(new Employee("Raji", "Hyderabad"));

            EmployeesList.Add(new Employee("Pavan", "Kochi"));

            EmployeesList.Add(new Employee("Moksha", "Mumbai"));

            EmployeesList.Add(new Employee("Chubby", "Indore"));

            EmployeesList.Add(new Employee("CH", "Aluva"));

            EmployeesList.Add(new Employee("Ramesh", "Kerala"));

            EmployeesList.Add(new Employee("Sujatha", "Miryalaguda"));

            var Query = from Employee emp in EmployeesList

                        orderby emp.City

                        group emp by emp.City;

            foreach (var e in Query)

            {

                Console.WriteLine("Employee with " + e.Key + " City: ");

                foreach (var nm in e)

                {

                    Console.WriteLine(" " + nm.Name);

                }

            }

        }
    }
}

