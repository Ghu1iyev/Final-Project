using Back2.DAL;
using Back2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back2.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            HomeVM home = new HomeVM
            {
                portfolios = await _context.portfolios.ToListAsync(),
            };
            return View(home);
        }

    }
}
