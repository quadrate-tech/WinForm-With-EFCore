﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WinForm_With_EFCore.DAL
{
    [Table("Employee")]
    internal class Employee
    {
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("home_phone")]
        public string HomePhone { get; set; }
        [Column("mobile")]
        public string Mobile { get; set; }
    }
}
