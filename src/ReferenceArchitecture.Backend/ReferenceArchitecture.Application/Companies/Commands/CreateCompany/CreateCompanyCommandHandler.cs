using MediatR;
using Microsoft.Extensions.Logging;
using ReferenceArchitecture.Application.Interfaces.Infrastructure.Repositories;
using ReferenceArchitecture.Domain.Companies;

namespace ReferenceArchitecture.Application.Companies.Commands.CreateCompany;

public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyResponse>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly ILogger<CreateCompanyCommandHandler> _logger;

    public CreateCompanyCommandHandler(ICompanyRepository companyRepository, ILogger<CreateCompanyCommandHandler> logger)
    {
        _companyRepository = companyRepository;
        _logger = logger;
    }

    public async Task<CreateCompanyResponse> Handle(CreateCompanyCommand command, CancellationToken cancellationToken)
    {
        var companyId = Guid.NewGuid();
        var company = new Company(companyId, command.Name);

        try
        {
            var result = await _companyRepository.Create(company);

            return result switch
            {
                true => new CreateCompanySuccess(companyId),
                _ => new CreateCompanyFailure()
            };
        }
        catch (Exception ex)
        {
            _logger.LogError("Error occured when creating Company: {ex.Message}", ex);
            return new CreateCompanyFailure();
        }
    }
}