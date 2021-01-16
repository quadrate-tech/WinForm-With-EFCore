using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_With_EFCore.DAL
{
    internal class EmployeeProvider : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;
        public EmployeeProvider(EmployeeContext empContext)
        {
            employeeContext = empContext;
        }
        public Employee Get(int id)
        {
            return employeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
