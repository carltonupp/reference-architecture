using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Products.Application.Categories.Commands.CreateCategory;
using Xunit;

namespace Products.Application.Tests.Categories.Commands.CreateCategory
{
    public class WhenExecutingCommandHandler : IClassFixture<CreateCategoryCommandFixture>
    {
        private readonly CreateCategoryCommandFixture _fixture;

        public WhenExecutingCommandHandler(CreateCategoryCommandFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public async Task ReturnsCategoryIdGivenValidCommand()
        {
            var command = new CreateCategoryCommand
            {
                Name = "Games Consoles"
            };

            var result = await _fixture.Handler.Handle(
                command, new CancellationToken());
            
            Assert.NotNull(result);
            Assert.NotEqual(Guid.Empty, result.CategoryId);
        }

        [Fact]
        public async Task ThrowsValidationExceptionGivenInvalidCommand()
        {
            var command = new CreateCategoryCommand
            {
                Name = " "
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                var result = await _fixture.Handler.Handle(command, new CancellationToken());
            });
        }
    }
}