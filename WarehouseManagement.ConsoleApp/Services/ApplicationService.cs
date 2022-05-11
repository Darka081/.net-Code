using System;
using System.Collections.Generic;

namespace WarehouseManagement.ConsoleApp.Services
{
    public class ApplicationService
    {
        private WarehouseService _warehouseService;

        public ApplicationService()
        {
            _warehouseService = new WarehouseService();
        }

        public void Process(string command)
        {
            if (command.StartsWith("Add"))
            {
                string[] splitCommand = command.Split(" ");

                _warehouseService.Add(splitCommand[1], splitCommand[2]);
            }
            else if (command.StartsWith("Remove"))
            {
                string[] splitCommand = command.Split(" ");
                _warehouseService.Remove(splitCommand[1]);
            }
            else if (command.StartsWith("Show"))
            {
                List<WarehouseItem> items = _warehouseService.GetAll();

                foreach (WarehouseItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemQuantity: {item.Quantity}");
                }
            }
            else if (command.StartsWith("Set"))
            {
                string[] splitCommand = command.Split(" ");

                _warehouseService.Update(splitCommand[1], splitCommand[2]);
            }
            else if (command.StartsWith("Exit"))
            {
                //Console.WriteLine("Press X button on the right upper corner!");

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect command");
            }
        }
    }
}
