using Jasmin.Domain.Entities;
using Jasmin.Infrastructure.Ef;
using Microsoft.AspNetCore.Mvc;

namespace Jasmin.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class BaseController:ControllerBase
{
    protected readonly DataContext _dataContext;

    public BaseController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    
}