using MediatR;

namespace Products.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<CategoryCreatedResponse>
    {
        public string Name { get; set; }
    }
}