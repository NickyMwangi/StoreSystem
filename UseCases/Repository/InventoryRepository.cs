using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.IRepository;

namespace UseCases.Repository
{
    public class InventoryRepository: IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory() { Id = Guid.NewGuid(), Name="Nice & Lovely Lotion", Quantity=10,UnitPrice=630,TotalPrice=6300 } ,
                new Inventory() { Id = Guid.NewGuid(), Name="OnePlus 11", Quantity=10,UnitPrice=89000,TotalPrice=890000 } ,
                new Inventory() { Id = Guid.NewGuid(), Name="Bread", Quantity=10,UnitPrice=63,TotalPrice=630 } ,
                new Inventory() { Id = Guid.NewGuid(), Name="Bike wheel", Quantity=10,UnitPrice=1500,TotalPrice=15000 } ,
            };
        }

        public async Task<IEnumerable<Inventory>> FilterInventoryByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_inventories);
            return _inventories.Where(n => n.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
