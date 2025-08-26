using Microsoft.AspNetCore.Mvc;
using MonthlyRevenue.Models;
using MonthlyRevenue.Services.Interfaces;

namespace MonthlyRevenue.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RevenueController : Controller
    {
        private readonly IRevenueService _service;

        public RevenueController(IRevenueService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string companyId)
        {
            var result = await _service.GetByCompanyIdAsync(companyId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CompanyRevenueDto dto)
        {
            await _service.InsertAsync(dto);
            return Ok();
        }
    }
}
