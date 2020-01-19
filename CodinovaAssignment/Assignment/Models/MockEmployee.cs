using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class MockEmployee : IEmployee
    {
        private List<Employee> _employeelist;
        public MockEmployee()
        {
            _employeelist = new List<Employee>()
            {
                new Employee(){Id=1, Name="Marry"},
                new Employee(){Id=2, Name="Abhishek"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeelist.FirstOrDefault(e => e.Id == Id);
        }
    }
}
