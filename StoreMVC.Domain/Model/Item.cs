﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemTypeId { get; set; }
        public virtual ItemType Type { get; set; }
    }
}
