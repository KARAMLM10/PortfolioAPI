using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [ApiController]
    [Route("portfolioAPI[controller]")]
    public class allprojectsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public allprojectsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet(Name = "portfolioAPI")]
        public async Task<ActionResult<List<AllProjects>>> GetAll()
        {
            return Ok(await _dbContext.AllprojectsapiDBSet.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
