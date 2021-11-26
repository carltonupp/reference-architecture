using Microsoft.Extensions.Logging;
using Moq;
using Products.Application.Categories.Commands.CreateCategory;
using Products.Application.Interfaces.Persistence;
using Products.Domain.Categories;

namespace Products.Application.Tests.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandFixture
    {
        public CreateCategoryCommandFixture()
        {
            var repository = new Mock<ICategoryRepository>();
            var logger = new Mock<ILogger<CreateCategoryCommandHandler>>();
            var validator = new CreateCategoryCommandValidator();

            Handler = new CreateCategoryCommandHandler(
                repository.Object, logger.Object, validator);
        }

        public CreateCategoryCommandHandler Handler { get; }
    }
}