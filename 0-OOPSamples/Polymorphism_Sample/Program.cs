using System;
using System.Collections.Generic;

namespace Polymorphism_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureOverload = new Figure();

            var figures = new List<Figure>()
            {
                new Circle(),
                new Triangle()
            };

            foreach (var figure in figures)
                figure.Draw();

            figureOverload.Draw("Overloading test");

            Console.ReadKey();
        }
    }
}