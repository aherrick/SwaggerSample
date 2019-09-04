namespace Microsoft.Examples.V2.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SwaggerSample.Filters;

    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiKeyFilter]
    public class OrdersController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get() => Ok(true);
    }
}