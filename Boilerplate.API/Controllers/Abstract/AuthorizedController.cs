using Boilerplate.API.Controllers.Filters;
using Boilerplate.API.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Boilerplate.API.Controllers.Abstract
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ExceptionHandlerFilter]
    public class AuthorizedController : Controller
    {
        public override OkObjectResult Ok([ActionResultObjectValue] object value)
        {
            return base.Ok(new ApiJsonResponse(value));
        }
    }
}
