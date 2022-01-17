using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReferenceArchitecture.Application.Companies.Commands.CreateCompany;

namespace ReferenceArchitecture.API.Controllers;

public class CompanyController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<CompanyController> _logger;

    public CompanyController(IMediator mediator, 
        ILogger<CompanyController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCompany(CreateCompanyCommand command)
    {
        try
        {
            var response = await _mediator.Send(command);
            return CreatedAtRoute("GetCompany", new { id = response.Id });
        }
        catch (Exception e)
        {
            _logger.LogError("An error occured: {e.Message}", e);
            throw;
        }
    }
}