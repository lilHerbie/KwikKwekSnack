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
        private readonly Repository _repo;
        private System.Timers.Timer _timer; 

        public MainController()
        {
            _repo = new Repository();
            _timer = new(interval: 1000);
            TestTimer();
        }

        private void ShowOrders()
        {
            foreach (var o in GetOrders())
            {
                Console.WriteLine(o.Id + ":" + o.Status.ToString());
            }
            
        }

        private List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(_repo.GetActiveOrder());
            foreach(Order order in _repo.GetQueuedOrders())
            {
                orders.Add(order);
            }
            orders.Add(_repo.GetLastFinishedOrder());

            return orders;

        }


        private void TestTimer()
        {
            _timer.Elapsed += (sender, e) => ShowOrders();
            _timer.Start();

            Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
