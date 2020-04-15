using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using EmployeesControl.Entities;

namespace EmployeesControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path)) 
            {
                while (!sr.EndOfStream) 
                {
                    string[] fields = sr.ReadLine().Split(',');
                    int id  = int.Parse(fields[0]);
                    string name = fields[1];
                    string email = fields[2];
                    double salary = double.Parse(fields[3], CultureInfo.InvariantCulture);

                    employees.Add(new Employees(id, name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine());

            var emails = employees.Where(p => p.Salary > 2000.00).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than 2000.00");
            foreach (string email in emails) 
            {
                Console.WriteLine(email);
            }

            var sum_sal = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum_sal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
