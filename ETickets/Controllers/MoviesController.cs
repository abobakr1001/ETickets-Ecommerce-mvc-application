using ETickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ETickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext dbContext;

        public MoviesController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult>  Index()
        {
            var data = await this.dbContext.movies.ToListAsync();
            return View();
        }
    }
}
