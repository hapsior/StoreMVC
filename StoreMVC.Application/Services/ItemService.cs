using StoreMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Application.Services
{
    public class ItemService : IItemService
    {
        public List<int>List{ get; set; }
        public List<int> GetAllItems()
        {
            return List;
        }
    }
}
