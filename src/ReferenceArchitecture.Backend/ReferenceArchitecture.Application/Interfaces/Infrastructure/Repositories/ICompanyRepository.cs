using ReferenceArchitecture.Domain.Companies;

namespace ReferenceArchitecture.Application.Interfaces.Infrastructure.Repositories;

public interface ICompanyRepository
{
    Task<bool> Create(Company company);
}