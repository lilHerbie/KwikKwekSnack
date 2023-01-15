using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Extensions.Internal;
using System.Threading;

namespace ConsoleApp
{
    public class MainController
    {
        private int _orderTime;
        private Repository _repo;
        private List<Order> _orders;
        private Order _mostRecentOrder;

        public MainController(Repository repo)
        {
            _repo = repo;
        }

        public void PrintStartup()
        {
            Console.WriteLine("Beste medewerker, +\n hier een lijst met de te verwerken bestellingen. +\n Bestellingen die klaar zijn worden in het groen weergegeven.");

            Console.WriteLine();

            Console.WriteLine("Hoeveel seconden zijn er nodig om één bestelling te verwerken? (Kies een getal tussen de 5 en 60 seconden)");
            Console.WriteLine();

            bool IsJuist = false;
            while (!IsJuist)
            {
                Console.Write("Seconden: ");
                var input = Console.ReadLine();
                string line = input == null ? "" : input.ToString();

                _orderTime = int.Parse(line);
                if (_orderTime >= 5 && _orderTime <= 60)
                {
                    IsJuist = true;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("kies tussen de 5 en 60 seconden");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            }


        }

        public void ShowOrders()
        {
            _orders = _repo.GetQueuedOrders();
            Console.Clear();
            Console.WriteLine($"Id \tStatus");

            for (int i = 0; i < _orders.Count; i++)
            {

                if (i == 0)
                {
                    _orders[i].Status = Status.isBeingPrepared;
                    _repo.UpdateOrder(_orders[i]);
                }
                Console.WriteLine($"{_orders[i].Id} \t{_orders[i].Status.ToString().Replace("_", " ")} ");

            }

            Console.WriteLine("");

           if (_mostRecentOrder != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{_mostRecentOrder.Id} \t{_mostRecentOrder.Status.ToString().Replace("_", " ")} ");
                Console.ResetColor();
            }

            Console.WriteLine();

        }

        public void Start()
        {
            while (true)
            {
                
                foreach (var order in _orders)
                {
                    Thread.Sleep(_orderTime * 1000);
                    order.Status = Status.ready;
                    _repo.UpdateOrder(order);
                    _mostRecentOrder = order;
                    ShowOrders();
                }
         
                Thread.Sleep(_orderTime);
                if(_repo.GetQueuedOrders().Count > 0)
                {
                     ShowOrders();
                }

            }

            
            


        }

    }
}
