using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoanRapphim.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoanRapphim.Controllers
{
    public class DanhSachPhimController : Controller
    {
        private readonly DPContext _context;

        public DanhSachPhimController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.Phim.FirstOrDefaultAsync(m => m.Id == id);
            if (phimModel == null)
            {
                return NotFound();
            }

            return View(phimModel);
        }
    }
}
