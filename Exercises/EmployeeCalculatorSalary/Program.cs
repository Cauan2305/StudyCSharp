using EmployeeCalculatorSalary.Entities;
namespace EmployeeCalculatorSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Employees :");
            int totalNumberEmployee = int.Parse(Console.ReadLine());
            List<Employee> employees=new List<Employee>();

            for (int i=1 ; i <= totalNumberEmployee ; i++)
            {
                Console.WriteLine($"Employee #{i} Data");
                Console.Write("Outsourced (y/n)?");
                char isOutSourced =char.Parse(Console.ReadLine()??"n");
                
                Console.Write("Name:");
                string? Name=Console.ReadLine();

                Console.Write("Hours:");
                int Hours=int.Parse(Console.ReadLine());

                Console.Write("Value per Hour:");
                double ValuePerHour=double.Parse(Console.ReadLine());
                
                
                if (isOutSourced.ToString().ToLower() == "y")
                {
                    OutSourcedEmployee employeeOutsourced=new OutSourcedEmployee();
                    Console.Write("Additional Charge :");
                    employeeOutsourced.additionalCharge=double.Parse(Console.ReadLine());
                    employeeOutsourced.Name=Name;
                    employeeOutsourced.Hours=Hours;
                    employeeOutsourced.ValuePerHour=ValuePerHour;
                    employees.Add(employeeOutsourced);

                }
                else
                {
                    Employee employee=new Employee(Name,Hours,ValuePerHour);
                    employees.Add(employee);
                }

                

            }
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            

        }
    }
}