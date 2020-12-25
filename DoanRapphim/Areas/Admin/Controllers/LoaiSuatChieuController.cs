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
    public class LoaiSuatChieuController : Controller
    {
        private readonly DPContext _context;

        public LoaiSuatChieuController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiSuatChieu
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiSuatChieu.ToListAsync());
        }

        // GET: Admin/LoaiSuatChieu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSuatChieuModel = await _context.LoaiSuatChieu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiSuatChieuModel == null)
            {
                return NotFound();
            }

            return View(loaiSuatChieuModel);
        }

        // POST: Admin/LoaiSuatChieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenSuatChieu,GiaSuatChieu")] LoaiSuatChieuModel loaiSuatChieuModel)
        {
            if (id != loaiSuatChieuModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSuatChieuModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSuatChieuModelExists(loaiSuatChieuModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/LoaiSuatChieu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSuatChieuModel = await _context.LoaiSuatChieu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiSuatChieuModel == null)
            {
                return NotFound();
            }

            return View(loaiSuatChieuModel);
        }

        // POST: Admin/LoaiSuatChieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiSuatChieuModel = await _context.LoaiSuatChieu.FindAsync(id);
            _context.LoaiSuatChieu.Remove(loaiSuatChieuModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSuatChieuModelExists(int id)
        {
            return _context.LoaiSuatChieu.Any(e => e.Id == id);
        }
    }
}
