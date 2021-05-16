using System;

namespace Polymorphism_Sample
{
    internal class Triangle : Figure
    {
        #region Public Methods

        public override void Draw()
        {
            Console.WriteLine("Drawning Triangle");
        }

        #endregion Public Methods
    }
}