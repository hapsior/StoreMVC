using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Domain.Model
{
    public class ItemType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Item> Item { get; set; }

    }
}
