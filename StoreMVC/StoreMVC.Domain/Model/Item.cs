using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
