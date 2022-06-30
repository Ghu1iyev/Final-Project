using Back2.DAL;
using Back2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back2.Areas.RevasAdmin.Controllers
{
    [Area("RevasAdmin")]
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Portfolio> portfolios = await _context.portfolios.ToListAsync();
            return View(portfolios);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Detail(int id)
        {
            Portfolio portfolio = await _context.portfolios.FirstOrDefaultAsync(p => p.Id == id);
            if (portfolio == null) NotFound();
            return View(portfolio);
        }
        public async Task<IActionResult> Edit()
        {
            return View();
        }
       
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
