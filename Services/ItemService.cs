using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public interface IItemService : IRepository<Item> 
    {
        void Create(string itemValue);
    }

    public class ItemService : IItemService
    {
        private readonly ItemRepository itemRepository;


        public ItemService(ItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        public void Add(Item item)
        {
            itemRepository.Add(item);
        }

        public void Create(string itemValue)
        {
            var item = new Item { Id=GetLastId()+1, Value = itemValue };
            this.Add(item);
        }

        public void Remove(Item item)
        {
            itemRepository.Remove(GetById(item.Id));
        }
        
        public void Update(Item item)
        {
            itemRepository.Update(item);
        }

        public int GetLastId()
        {
            return itemRepository.GetLastId();
        }

        public Item GetById(int id)
        {
            return itemRepository.GetById(id);
}

        public bool CheckExistingOfId(int? id)
        {
            return itemRepository.CheckExistingOfId(id);

        }
    }
}
