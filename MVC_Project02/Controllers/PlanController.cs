using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project02.Context;

namespace MVC_Project02.Controllers
{
    public class PlanController : Controller
    {

        private GymDbContext dbContext = new();

        public IActionResult IndexTest()
        {
            return View();
        }
    public async Task<IActionResult> Index()
        {
            var plans = await dbContext.plans.ToListAsync();
            return View(plans);
        }

    }

}
