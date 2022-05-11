using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagement.ConsoleApp.Services
{

    public class WarehouseService
    {
        private List<WarehouseItem> _items;

        public WarehouseService()
        {
            _items = new List<WarehouseItem>();
        }

        public void Add(string name, string quantity)
        {
            var item = new WarehouseItem()
            {
                Name = name,
                Quantity = quantity
            };

            _items.Add(item);
        }

        public void Update(string name, string quantity)
        {
            var item = _items.First(i => i.Name == name);
            item.Quantity = quantity;
        }

        public void Remove(string name)
        {
            var filteredItems = new List<WarehouseItem>();

            _items = _items.Where(i => i.Name != name).ToList();
        }

        public List<WarehouseItem> GetAll()
        {
            return _items;
        }
    }
}
