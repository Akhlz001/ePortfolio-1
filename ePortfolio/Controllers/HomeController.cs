using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ePortfolio.Models;
using ePortfolio.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ePortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Skills()
        {
            ViewData["Message"] = "Your skills description page.";

            return View(await _context.Skills.OrderBy(s => s.SkillNo).ToListAsync());
        }

        public async Task<IActionResult> FullSkills()
        {
            ViewData["Message"] = "Your skills description page.";

            return View(await _context.Skills.OrderBy(s => s.SkillNo).ToListAsync());
        }

        // GET: Skills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .FirstOrDefaultAsync(m => m.SkillID == id);

            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
