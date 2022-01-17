namespace ReferenceArchitecture.Application.Companies.Commands.CreateCompany;

public class CreateCompanyResponse
{
    public Guid Id { get; set; }
    public bool Success { get; set; }
}

public class CreateCompanyFailure : CreateCompanyResponse
{
    public CreateCompanyFailure()
    {
        Success = false;
    }
}

public class CreateCompanySuccess : CreateCompanyResponse
{
    public CreateCompanySuccess(Guid id)
    {
        Id = id;
        Success = true;
    }
}