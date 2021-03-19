using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DateTime Date { get; set; }
        public virtual Item Item { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
       
        
    }
}
