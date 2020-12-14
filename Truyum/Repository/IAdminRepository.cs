using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Truyum.Models;

namespace Truyum.Repository
{
    interface IAdminRepository
    {
        public List<Items> GetAllItems();
        public void AddItem(Items item);
        public void UpdateItem(Items item);
        public Items GetItemById(int? id);

        public void DeleteItem(int id);
    }


}

