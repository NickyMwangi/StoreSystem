using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.IProcess;
using UseCases.IRepository;

namespace UseCases.Process
{
    public class InventoryUseCases  : IInventoryUseCases
    {
        private readonly IInventoryRepository _inventoryRepository;
        public InventoryUseCases(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>>  FilterByNameAsync(string name="")
        {
            return await _inventoryRepository.FilterInventoryByNameAsync(name);
        }
    }
}
