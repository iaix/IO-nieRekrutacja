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

        public void DeleteItem(char id)
        {

            if (!char.IsDigit(id)) Console.WriteLine("Błędne ID");
            else
            {
                int intId = (int)(id - '0');
                if (itemService.CheckExistingOfId(intId))
                {
                    var deleted = itemService.GetById(intId);
                    itemService.Remove(deleted);
                    Console.WriteLine($"Item o ID {intId} usunięty");
                }
                else Console.WriteLine("Rekord o podanym ID nie istnieje");
            }

        }

        public void UpdateItem(char id)
        {
            if (!char.IsDigit(id)) Console.WriteLine("Błędne ID");
            else
            {
                int intId = (int)(id - '0');
                if (itemService.CheckExistingOfId(intId))
                {
                    var updated = itemService.GetById(intId);
                    updated.Value = GenerateValue.RandomString(8);
                    itemService.Update(updated);
                    Console.WriteLine($"Item o ID {intId} zmieniony");
                }
                else Console.WriteLine("Rekord o podanym ID nie istnieje");
            }

        }

    }
}
