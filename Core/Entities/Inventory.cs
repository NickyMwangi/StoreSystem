using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventory   : BaseEntity
    {
        public string Name { get; set; }  =  string.Empty;
        public decimal Quantity { get; set; } = decimal.Zero;
        public decimal UnitPrice { get; set; } = decimal.Zero;
        public decimal TotalPrice { get; set; } = decimal.Zero;

    }
}
