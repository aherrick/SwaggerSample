namespace Microsoft.Examples.V1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SwaggerSample.Filters;

    /// </summary>
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiKeyFilter]
    public class OrdersController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get(int id) => Ok($"{true} + id");
    }
}