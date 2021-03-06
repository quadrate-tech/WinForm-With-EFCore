﻿using Microsoft.EntityFrameworkCore;

namespace WinForm_With_EFCore.DAL
{
    internal class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-02RK9HN\QUADRATESQL;Initial Catalog=EmployeeDB;Integrated Security=True");
        }
    }
}
