using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using Products.Application.Interfaces.Persistence;
using Products.Domain.Categories;

namespace Products.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CategoryCreatedResponse>
    {
        private readonly ICategoryRepository _repository;
        private readonly CreateCategoryCommandValidator _validator;
        private readonly ILogger<CreateCategoryCommandHandler> _logger;

        public CreateCategoryCommandHandler(
            ICategoryRepository repository, 
            ILogger<CreateCategoryCommandHandler> logger, 
            CreateCategoryCommandValidator validator)
        {
            _repository = repository;
            _logger = logger;
            _validator = validator;
        }

        public async Task<CategoryCreatedResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _validator.ValidateAndThrowAsync(request, cancellationToken);
            
            var categoryId = Guid.NewGuid();
            var category = new Category(categoryId, request.Name);

            try
            {
                await _repository.Create(category);
                return new CategoryCreatedResponse(categoryId);
            }
            catch (Exception ex)
            {
                _logger.LogError("Category creation failed: {ex}", ex);
                throw;
            }
        }
    }
}