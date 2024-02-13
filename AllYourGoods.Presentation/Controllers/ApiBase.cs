using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AllYourGoods.Presentation.Controllers;

[ApiController]
public class ApiBase : ControllerBase
{
    public IMediator Mediator { get; }

    protected ApiBase(IMediator mediator)
    {
        Mediator = mediator;
    }
}