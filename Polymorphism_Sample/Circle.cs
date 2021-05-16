using System;

namespace Polymorphism_Sample
{
    internal class Circle : Figure
    {
        #region Public Methods
            
        public override void Draw()
        {
            Console.WriteLine("Drawning Circle");
        }

        #endregion Public Methods
    }
}