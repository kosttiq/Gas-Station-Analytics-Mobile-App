using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Name = "АИ-92", Sells_Rub_Fact = "350.000", Sells_Rub_Plan = "300.000", Sells_Litres_Fact = "7.000", Sells_Litres_Plan = "6.000", Count_Fact="300" },
                new Item { Id = Guid.NewGuid().ToString(), Name = "АИ-95", Sells_Rub_Fact = "550.000", Sells_Rub_Plan = "660.000", Sells_Litres_Fact = "10.000", Sells_Litres_Plan = "12.000", Count_Fact="500" },
                new Item { Id = Guid.NewGuid().ToString(), Name = "АИ-98", Sells_Rub_Fact = "290.000", Sells_Rub_Plan = "300.000", Sells_Litres_Fact = "5.090", Sells_Litres_Plan = "5.260", Count_Fact="255" },
                new Item { Id = Guid.NewGuid().ToString(), Name = "Дизель", Sells_Rub_Fact = "150.000", Sells_Rub_Plan = "135.000", Sells_Litres_Fact = "2.500", Sells_Litres_Plan = "2.250", Count_Fact="400" },

            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}