using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.IProcess
{
    public interface IInventoryUseCases
    {
        Task<IEnumerable<Inventory>> FilterByNameAsync(string name = "");
    }
}
