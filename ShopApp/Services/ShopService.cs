using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    public class ShopService
    {
        private List<ShopItem> _items;
        private Customer _customer;

        public decimal price { get; private set; }

        public ShopService()
        {
            _items = new List<ShopItem>();
            _customer = new Customer();
        }


        public void Add(string name, string quantity, decimal price)
        {
            var item = new ShopItem()
            {
                Name = name,
                Quantity = quantity,
                Price = price
            };

            _items.Add(item);
        }

        public void Update(string name, string quantity)
        {
            var item = _items.First(i => i.Name == name);
            item.Quantity = quantity;
            item.Price = price;
        }

        public void Remove(string name)
        {
            var filteredItems = new List<ShopItem>();

            _items = _items.Where(i => i.Name != name).ToList();
        }

        public List<ShopItem> GetAll()
        {
            return _items;
        }



        public decimal GetBalance()
        {
            return _customer.Cash;
        }
    }
}
