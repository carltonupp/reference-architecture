using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Products.Application.Interfaces.Persistence;
using Products.Domain.Products;

namespace Products.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductCreatedResponse>
    {
        private readonly IProductRepository _repository;
        private readonly CreateProductCommandValidator _validator;

        public CreateProductCommandHandler(IProductRepository repository, CreateProductCommandValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<ProductCreatedResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _validator.ValidateAndThrowAsync(request, cancellationToken);

            var product = Product.Create(request.Name, request.Description, 
                request.ProductCode, request.Category,
                    request.Cost, request.Sell);
            
            var productId = await _repository.Create(product);
            return new ProductCreatedResponse(productId);
        }
    }
}