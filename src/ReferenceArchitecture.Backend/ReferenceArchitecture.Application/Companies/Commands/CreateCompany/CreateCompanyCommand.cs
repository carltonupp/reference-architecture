using MediatR;

namespace ReferenceArchitecture.Application.Companies.Commands.CreateCompany;

public class CreateCompanyCommand : IRequest<CreateCompanyResponse>
{
    public string Name { get; set; }

    public CreateCompanyCommand(string name)
    {
        Name = name;
    }
}