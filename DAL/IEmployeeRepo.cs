using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_With_EFCore.DAL
{
    internal interface IEmployeeRepo
    {
        Employee Create(Employee emp);

        Employee Update(Employee employee);

        void Delete(Employee employee);

        List<Employee> View();
    }
}
