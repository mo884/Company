using Company.DAL.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Entities
{
    public class Branch
    {
        public Branch()
        {
            
        }
        public Branch(string name, string country, string governate, string city, string area, string address1, string address2, string address3)
        {
            Name=name;
            Address = new Address(country, governate, city, area, address1, address2, address3);

        }
        public  long Id { get; set; }
        public string Name { get; private set; }
        public Address Address { get; set; } = new();
        //Navigation Property
        public virtual List<Employee>? Employees { get; private set; } = [];
    }
}
