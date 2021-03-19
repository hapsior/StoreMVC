using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMVC.Application.Interfaces
{
    public interface IItemService
    {
        List<int> GetAllItems();
    }
}
