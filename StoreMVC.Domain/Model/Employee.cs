using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Domain.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }


    }
}
