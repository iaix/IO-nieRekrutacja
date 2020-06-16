using Repositories;
using Services;
using System;
using Xunit;
using System.Linq;

namespace Tests
{
    public class ItemServiceTests
    {
        [Fact]
        public void AddItem()
        {
            var itemService = new ItemService(new ItemRepository(new DataClassesDataContext()));
            var testItem = new Item { Value = "Wartoœæ Testowa" };

            itemService.Add(testItem);
            var retrievedTestItem = itemService.GetById(itemService.GetLastId());

            Assert.Equal(testItem.Value, retrievedTestItem.Value);
        }

        [Fact]
        public void UpdateItem()
        {
            //Arrange
            var itemService = new ItemService(new ItemRepository(new DataClassesDataContext()));


            //Act

            //Assert
        }

    }
}
