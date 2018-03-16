using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using technoApi.Queries;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {

        public IConfiguration Configuration { get; }
        public ProfileController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // GET
        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            var query = new ProfileQuery(Configuration);
            return new OkObjectResult(await query.AllProfilesASync());
        }
    }
}