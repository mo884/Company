
using Company.BLL.Servicse.Abstraction;
using Company.BLL.Servicse.Impelementation;

namespace Company.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeServices employeeServices = new EmployeeServices();
            var result =  employeeServices.GetAll();
            foreach (var employee in result)
            {
                Console.WriteLine(employee.Branch.Name);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
