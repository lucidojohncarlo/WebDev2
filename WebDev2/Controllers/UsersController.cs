using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDev2.DataConnection;

namespace WebDev2.Controllers
{
    public class UsersController : Controller
    {
        private readonly MySqlDbContext _context;
        public UsersController(MySqlDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
    }
}
