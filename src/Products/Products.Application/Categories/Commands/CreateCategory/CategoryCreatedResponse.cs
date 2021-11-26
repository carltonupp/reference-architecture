using System;

namespace Products.Application.Categories.Commands.CreateCategory
{
    public class CategoryCreatedResponse
    {
        public CategoryCreatedResponse(Guid categoryId)
        {
            CategoryId = categoryId;
        }
        
        public Guid CategoryId { get; set; }
    }
}