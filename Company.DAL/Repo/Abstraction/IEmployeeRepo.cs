using Company.DAL.Entities;


namespace Company.DAL.Repo.Abstraction
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAll();
    }
}
