using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_With_EFCore.DAL
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext empContext;
        public EmployeeRepo(EmployeeContext employeeContext) => empContext = employeeContext;

        public Employee Create(Employee emp)
        {
            var data = empContext.Add(emp);
            empContext.SaveChanges();
            return data.Entity;
        }

        public void Delete(Employee emp)
        {
            using EmployeeContext empCont = new EmployeeContext();
            empCont.Remove(emp);
            empCont.SaveChanges();
        }

        //Some Code Here

        public Employee Update(Employee emp)
        {
            var data = empContext.Update(emp);
            empContext.SaveChanges();
            return data.Entity;
        }
    }
}
