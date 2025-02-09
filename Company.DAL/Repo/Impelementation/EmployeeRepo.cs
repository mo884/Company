using Company.BLL.ModelVM_.Employee;
using Company.DAL.Database;
using Company.DAL.Entities;
using Company.DAL.Repo.Abstraction;
using Microsoft.EntityFrameworkCore;


namespace Company.DAL.Repo.Impelementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private ApplicationDbContext Db;
        public EmployeeRepo()
        {
            Db = new();
        }
        public List<Employee> GetAll()
        {
          using  var transaction = Db.Database.BeginTransaction();


            try
            {
                //Split Query
                var employees = Db.Employees
                                           .Where(a => a.Id>0)


                                           .ToList();
                transaction.CreateSavepoint("T 1");


                var employee = Db.Employees.FirstOrDefault();
                //Collection
                //One
                Db.Entry(employee).Reference(b => b.Branch).Load();
                //var employees = (from emp in Db.Employees
                //                join branch in Db.Branchs
                //                on emp.BranchId equals branch.Id
                //                select new EmployeeWithBrancesVM() { FullName = emp.FullName, BranchName =branch.Name }).ToList();

                transaction.Commit();

                return employees;


            }
            catch (Exception)
            {

                //transaction.Rollback();
                transaction.RollbackToSavepoint("T 1");
                transaction.Commit();

                throw;

            }

        }
    }
}
