using Company.BLL.Servicse.Abstraction;
using Company.DAL.Entities;
using Company.DAL.Repo.Abstraction;
using Company.DAL.Repo.Impelementation;

namespace Company.BLL.Servicse.Impelementation
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeServices()
        {
            _employeeRepo = new EmployeeRepo();
        }
        public List<Employee> GetAll()
        {
            var result = _employeeRepo.GetAll();
            return result;
        }
    }
}
