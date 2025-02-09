using Company.DAL.Entities;


namespace Company.BLL.Servicse.Abstraction
{
    public interface IEmployeeServices
    {
        List<Employee> GetAll();
    }
}
