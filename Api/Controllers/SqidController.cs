using Domain.shared.ShortId;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SqidController : ControllerBase
{
    private readonly ISquid _squidService;
    public SqidController(ISquid squidService)
    {
        _squidService = squidService;
    }
    [HttpGet]
    public ActionResult<string> Get()
    {
        var uuid = _squidService.SquidId();
        return uuid;
    }
}
