using System;

namespace Polymorphism_Sample
{
    internal class Figure
    {
        #region Public Methods

        public virtual void Draw()
        {
            Console.WriteLine("Draw Figure");
        }

        public virtual void Draw(string message)
        {
            Console.WriteLine(message);
        }

        #endregion Public Methods
    }
}