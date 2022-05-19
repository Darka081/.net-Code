using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Customer
    {
        public List<ShopItem> Items { get; set; }
        public decimal Cash { get; set; }
        public Customer(decimal cash = 20)
        {
            Cash = cash;
        }
    }
}
