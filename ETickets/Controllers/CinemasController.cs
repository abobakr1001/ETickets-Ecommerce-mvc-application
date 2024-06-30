using ETickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ETickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly AppDbContext dbContext;

        public CinemasController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var data = await this.dbContext.Cinemas.ToListAsync();
            return View();
        }
    }
}
