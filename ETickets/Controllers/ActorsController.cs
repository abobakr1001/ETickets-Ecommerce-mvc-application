using ETickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ETickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext dbContext;

        public ActorsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var data = this.dbContext.Actors.ToList();
            return View();
        }
    }
}
