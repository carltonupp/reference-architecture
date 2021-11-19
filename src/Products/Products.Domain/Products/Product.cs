using System;

namespace Products.Domain.Products
{
    public class Product
    {
        private string _name;
        private string _description;
        private string _productCode;
        private Guid _category;
        private decimal _sell;

        public Product(string name, string description, string productCode, Guid category, decimal cost, decimal sell)
        {
            Name = name;
            Description = description;
            ProductCode = productCode;
            Category = category;
            Cost = cost;
            Sell = sell;
        }

        public Guid ProductId { get; set; }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Product name cannot be empty");

                _name = value;
            }
        }

        public string Description
        {
            get => _description;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Product description cannot be empty");

                _description = value;
            }
        }

        public string ProductCode
        {
            get => _productCode;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Product Code cannot be empty");

                _productCode = value;
            }
        }

        public Guid Category
        {
            get => _category;
            private set
            {
                if (value == Guid.Empty)
                    throw new Exception("Category ID cannot be empty");

                _category = value;
            }
        }

        public decimal Cost { get; private set; }

        public decimal Sell
        {
            get => _sell;
            private set
            {
                if (value < Cost)
                    throw new Exception("Sell Price cannot be less than cost");

                _sell = value;
            }
        }
    }
}