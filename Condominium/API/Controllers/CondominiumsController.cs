using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CondominiumsController : ControllerBase
    {
        private readonly ICondominiumService condominiumService;

        public CondominiumsController(ICondominiumService condominiumService)
        {
            this.condominiumService = condominiumService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.condominiumService.GetAll();
            return Ok(result);
        }
    }
}
