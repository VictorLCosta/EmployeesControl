using System.Globalization;

namespace EmployeesControl.Entities
{
    class Employees
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public double Salary { get; private set; }

        public Employees()
        {
        }

        public Employees(int id, string name, string email, double salary)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, {Name}, {Email}, R$ {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
