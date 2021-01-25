using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_With_EFCore.DAL
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        public Employee Create(Employee emp)
        {
            using EmployeeContext empContext = new EmployeeContext();
            var data = empContext.Add(emp);
            empContext.SaveChanges();
            return data.Entity;
        }

        public void Delete(Employee emp)
        {
            using EmployeeContext empContext = new EmployeeContext();
            empContext.Remove(emp);
            empContext.SaveChanges();
        }

        //Some Code Here

        public Employee Update(Employee emp)
        {
            using EmployeeContext empContext = new EmployeeContext();
            var data = empContext.Update(emp);
            empContext.SaveChanges();
            return data.Entity;
        }

        public List<Employee> View()
        {
            using EmployeeContext empContext = new EmployeeContext();
            return empContext.Employees.ToList();
        }
    }
}
