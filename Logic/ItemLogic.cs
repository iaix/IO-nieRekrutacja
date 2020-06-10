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
            Console.WriteLine("Rekord dodany");
        }

        public void DeleteItem(string id)
        {
            int i = 0;
            bool result = int.TryParse(id, out i);

            if (result)
            {
                int intId = int.Parse(id);
                if (itemService.CheckExistingOfId(intId))
                {
                    var deleted = itemService.GetById(intId);
                    itemService.Remove(deleted);
                    Console.WriteLine($"Item o ID {intId} usunięty");
                }
                else Console.WriteLine("Rekord o podanym ID nie istnieje");
            }
            else Console.WriteLine("Błędne ID");
        }

        public void UpdateItem(string id)
        {
            int i = 0;
            bool result = int.TryParse(id, out i);

            if (result)
            {
                int intId = int.Parse(id);
                if (itemService.CheckExistingOfId(intId))
                {
                    var updated = itemService.GetById(intId);
                    updated.Value = GenerateValue.RandomString(8);
                    itemService.Update(updated);
                    Console.WriteLine($"Item o ID {intId} zmieniony");
                }
                else Console.WriteLine("Rekord o podanym ID nie istnieje");
            }
            else  Console.WriteLine("Błędne ID");

        }

    }
}
