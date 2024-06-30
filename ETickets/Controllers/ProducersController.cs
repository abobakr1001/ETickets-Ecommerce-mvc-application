using ETickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ETickets.Controllers
{
    public class ProducersController : Controller
    {

        private readonly AppDbContext dbContext;

        public ProducersController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult>  Index()
        {
            var data = await this.dbContext.Producers.ToListAsync();
            return View();
        }
    }
}
