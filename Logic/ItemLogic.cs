using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ItemLogic : IItemLogic
    {
        private readonly ItemService itemService = new ItemService(new ItemRepository( new DataClassesDataContext()));
        

        public void AddNewItem()
        {
            
            itemService.Create(GenerateValue.RandomString(8));
            
        }

        public bool CheckExistingOfId(int? id)
        {
            if (id!=null) return true;

            return false;
        }

        public void DeleteLastItem()
        {
           // itemService.Remove();
        }

        public void UpdateLastItem()
        {
            GenerateValue.RandomString(8);

            throw new NotImplementedException();
        }

    }
}
