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
        private Repository _repo;
        private List<Order> _orders;
        private Order _curOrder;
        private Order _lastCompletedOrder;
        private System.Timers.Timer _timer; 

        public MainController()
        {
            _timer = new(interval: 1000);
            TestTimer();
            _repo = new Repository();
            _orders = new List<Order>();
        }

        public void ShowOrders()
        {
            _orders = GetOrders();
            foreach (var o in _orders)
            {
                Console.WriteLine(o.Status);
            }
        }

        private List<Order> GetOrders()
        {
            return _repo.GetOrders().ToList();
        }

        private void OnTimedEvent()
        {
            GetOrders();
            ShowOrders();
        }

        private void TestTimer()
        {
            _timer.Elapsed += (sender, e) => OnTimedEvent();
            _timer.Start();

            Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
