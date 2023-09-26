using KontoretAb.Data;
using KontoretAb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KontoretAb.Controllers
{
    public class InfoController : Controller
    {
        private readonly KontoretABContext context;
        public InfoController(KontoretABContext _context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            List<InfoViewModel> list = new List<InfoViewModel>();
            var projectlist = await context.ProjectLists
                .Include(e=>e.Employees)
                .Include(p=>p.Projects)
                .AsNoTracking().ToListAsync();
            return View(projectlist);
        }
    }
}
