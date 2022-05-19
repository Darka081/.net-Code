using System.Collections.Generic;
using System.Linq;
using ShopApp.Models;

namespace ShopApp.Services
{
    public class ShopsService
    {

        private List<Shop> _shops = new List<Shop>()
        {
            new Shop()
            {
                Category = "Vegetables",
                ExpiryDate = System.DateTime.Today,
                Name = "Tomatoes"
            },
             new Shop()
            {
                Category = "Vegetables",
                ExpiryDate = System.DateTime.Today,
                Name = "Cucumbers"
            },
              new Shop()
            {
                Category = "Fruits",
                ExpiryDate = System.DateTime.Today,
                Name = "Banana"
            }, new Shop()
            {
                Category = "Fruits",
                ExpiryDate = System.DateTime.Today,
                Name = "Oranges"
            }
        };

        public List<Shop> GetAll()
        {
            return _shops;
        }

        public void Add(Shop shop)
        {
            _shops.Add(shop);
        }

        public void Delete(string name)
        {
            _shops = _shops.Where(t => t.Name != name).ToList();
        }
    }
}
