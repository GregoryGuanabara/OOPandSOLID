using OCP.Adherent.Extensions;
using System;

namespace OCP.Adherent
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            var product = new Product(1, "pen", "blue ballpoint pen", 2.00M, 3.40M, 100, true);

            Console.WriteLine($"{product.Name} - {product.ProfitMargin()}");

            Console.ReadLine();
        }

        #endregion Private Methods
    }
}