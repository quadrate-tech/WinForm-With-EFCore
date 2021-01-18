﻿using System;
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
            empContext.Remove(emp);
            empContext.SaveChanges();
        }

        //Some Code Here

        public Employee Update(Employee employee)
        {
            var data = empContext.Update(employee);
            empContext.SaveChanges();
            return data.Entity;
        }
    }
}
