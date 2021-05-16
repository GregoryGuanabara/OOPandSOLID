using System;

namespace Adherent
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.CreateOrder();
            order.DeleteOrder();

            Console.ReadKey();
        }
    }
}
