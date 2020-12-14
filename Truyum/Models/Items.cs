using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Truyum.Models
{
    public class Items
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string FreeDelivery { get; set; }
        [DataType(DataType.Date)]
        public string Date { get; set; }
        public string Active { get; set; }
    }
}
