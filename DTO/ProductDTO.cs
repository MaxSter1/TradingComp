using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CategoryId { get; set; }
        public bool IsLocked { get; set; }
        public decimal EntryPrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
