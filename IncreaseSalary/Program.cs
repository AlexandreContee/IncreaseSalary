using System.Globalization;

namespace IncreaseSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int identifier = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(identifier, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees.Find(x => x.Id == id);

            if (selectedEmployee != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                selectedEmployee.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}