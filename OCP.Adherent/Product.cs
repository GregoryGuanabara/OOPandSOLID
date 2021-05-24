using System;

namespace OCP.Adherent
{
    public class Product
    {
        #region Private Fields

        private decimal _custo = 0;
        private decimal _salePrice = 1;

        #endregion Private Fields

        #region Public Constructors

        public Product(int produtoId, string name, string description, decimal cost, decimal salePrice, int stock, bool isActivated)
        {
            ProdutoId = produtoId;
            Name = name;
            Description = description;
            Cost = cost;
            SalePrice = salePrice;
            Stock = stock;
            IsActivated = isActivated;
        }

        #endregion Public Constructors

        #region Public Properties

        public decimal Cost
        {
            get => _custo;
            private set
            {
                if (value > 0)
                    _custo = value;
            }
        }

        public string Description { get; private set; }
        public bool IsActivated { get; private set; }
        public string Name { get; private set; }
        public int ProdutoId { get; private set; }

        public decimal SalePrice
        {
            get => _salePrice;
            private set
            {
                if (value > 0)
                    _salePrice = value;
            }
        }

        public int Stock { get; private set; }

        #endregion Public Properties
    }
}