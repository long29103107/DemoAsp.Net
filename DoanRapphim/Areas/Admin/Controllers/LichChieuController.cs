using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoanRapphim.Areas.Admin.Models;
using DoanRapphim.Data;

namespace DoanRapphim.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LichChieuController : Controller
    {
        private readonly DPContext _context;

        public LichChieuController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LichChieu
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.LichChieu.Include(l => l.Phong);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/LichChieu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuModel = await _context.LichChieu
                .Include(l => l.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lichChieuModel == null)
            {
                return NotFound();
            }

            return View(lichChieuModel);
        }

        // GET: Admin/LichChieu/Create
        public IActionResult Create()
        {
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong");
            return View();
        }

        // POST: Admin/LichChieu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPhong,NgayChieu")] LichChieuModel lichChieuModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lichChieuModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong", lichChieuModel.IdPhong);
            return View(lichChieuModel);
        }

        // GET: Admin/LichChieu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuModel = await _context.LichChieu.FindAsync(id);
            if (lichChieuModel == null)
            {
                return NotFound();
            }
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong", lichChieuModel.IdPhong);
            return View(lichChieuModel);
        }

        // POST: Admin/LichChieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPhong,IdPhim,NgayCongChieu")] LichChieuModel lichChieuModel)
        {
            if (id != lichChieuModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lichChieuModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LichChieuModelExists(lichChieuModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong", lichChieuModel.IdPhong);
            return View(lichChieuModel);
        }

        // GET: Admin/LichChieu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuModel = await _context.LichChieu
                .Include(l => l.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lichChieuModel == null)
            {
                return NotFound();
            }

            return View(lichChieuModel);
        }

        // POST: Admin/LichChieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lichChieuModel = await _context.LichChieu.FindAsync(id);
            _context.LichChieu.Remove(lichChieuModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LichChieuModelExists(int id)
        {
            return _context.LichChieu.Any(e => e.Id == id);
        }
    }
}
