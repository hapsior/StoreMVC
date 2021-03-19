using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int? FlatNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderId { get; set; }
        public virtual ICollection<Order> Order{ get; set; }

    }
}
