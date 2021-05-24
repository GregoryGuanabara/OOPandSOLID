using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Adherent.Extensions
{
    public static class ProductExtension
    {
        public static double ProfitMargin(this Product produto) 
        {
            try
            {
                var profit = produto.SalePrice - produto.Cost;
                var profitMargin = (profit / produto.SalePrice) * 100;
                return Convert.ToDouble(profitMargin);
            }
            catch
            {
                throw new InvalidOperationException("Error when calculating Profit Margin.");
            }
        }
    }
}
