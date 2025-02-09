using Company.DAL.ComplexType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DAL.Entities
{
    public class Employee
    {
        public Employee()
        {
                
        }
        public Employee(long id, string fullName, decimal salary, decimal salaryAfterBounse, string country, string governate, string city, string area, string address1, string address2, string address3)
        {
            Id=id;
            FullName=fullName;
            Salary=salary;
            SalaryAfterBounse=salaryAfterBounse;
            Address = new Address(country, governate, city, area, address1, address2, address3);
     
        }
        [Key]
        public long Id { get; set; }
        public string FullName { get; private set; }
        public decimal Salary { get; private set; }
        public Address Address { get; set; }
        public decimal SalaryAfterBounse { get; private set; }
        [ForeignKey("Branch")]
        public  long? BranchId  { get; private set; }
        public virtual Branch? Branch { get; private set; } = new();


    }
}
