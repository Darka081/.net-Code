using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    public class ApplicationService
    {
        private ShopService _shopService;

        public ApplicationService()
        {
            _shopService = new ShopService();
        }

        public void Process(string command)
        {
            if (command.StartsWith("Add"))
            {
                try
                {
                    string[] splitCommand = command.Split(" ");
                    _shopService.Add(splitCommand[1], splitCommand[2], decimal.Parse(splitCommand[3]));
               }
                catch (Exception)
               {
                    Console.WriteLine("The command was not recognized!");
               }
            }
            else if (command.StartsWith("Remove"))
            {
                try
                {
                    string[] splitCommand = command.Split(" ");
                    _shopService.Remove(splitCommand[1]);
                }
                catch(Exception)
                {
                    Console.WriteLine("The command was not recognized!");
                }
            }
            else if (command.StartsWith("Show balance"))
            {
                Console.WriteLine("Balance: {0}", _shopService.GetBalance());
            }
            else if (command.StartsWith("Show"))
            {
                List<ShopItem> items = _shopService.GetAll();

                foreach (ShopItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemQuantity: {item.Quantity} ItemPrice: {item.Price}");
                }
            }
            else if (command.StartsWith("Set"))
            {
                try
                {
                    string[] splitCommand = command.Split(" ");
                    _shopService.Update(splitCommand[1], splitCommand[2]);
                }
                catch(Exception)
                {
                    Console.WriteLine("The command was not recognized!");
                }
            }
            else if (command.StartsWith(""))
            { }





            else if (command.StartsWith("Exit"))
            {
                Environment.Exit(0);
            }
        }
    }
}
