using System.Threading.Tasks;
using MyDeal.TechTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyDeal.TechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : Controller
    {
        private readonly ISettingsService _settingsService;


        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        public async Task<ActionResult> GetSettings()
        {
            var response = await _settingsService.GetUserDetails(2);
            return Ok(response);
        }
    }
}