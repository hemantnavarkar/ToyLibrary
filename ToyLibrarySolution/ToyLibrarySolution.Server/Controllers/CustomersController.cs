using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyLibrarySolution.Server.DBContext;

namespace ToyLibrarySolution.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private SQLContext sqlContext;
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger, SQLContext sqlContext)
        {
            _logger = logger;
            this.sqlContext = sqlContext;
        }

        [HttpGet(Name = "GetCustomers")]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.sqlContext.Customers.ToListAsync());
        }
    }
}
