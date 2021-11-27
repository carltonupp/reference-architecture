using System;

namespace Products.Domain.Categories
{
    public class Category
    {
        private Guid _categoryId;
        private string _name;
        
        public Category(Guid categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public Guid CategoryId
        {
            get => _categoryId;
            private set
            {
                if (value == Guid.Empty)
                {
                    throw new Exception("Category ID Cannot be empty");
                }

                _categoryId = value;
            }
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                _name = value;
            }
        }
    }
}