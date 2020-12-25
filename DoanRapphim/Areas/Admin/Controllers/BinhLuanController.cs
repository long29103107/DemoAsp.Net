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
    public class BinhLuanController : Controller
    {
        private readonly DPContext _context;

        public BinhLuanController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/BinhLuan
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.BinhLuan.Include(b => b.NguoiDung).Include(b => b.Phim);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/BinhLuan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuanModel = await _context.BinhLuan
                .Include(b => b.NguoiDung)
                .Include(b => b.Phim)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (binhLuanModel == null)
            {
                return NotFound();
            }

            return View(binhLuanModel);
        }

        // GET: Admin/BinhLuan/Create
        public IActionResult Create()
        {
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan");
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim");
            return View();
        }

        // POST: Admin/BinhLuan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdNguoiDung,IdPhim,NoiDung,NgayDang,TinhTrang")] BinhLuanModel binhLuanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(binhLuanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan", binhLuanModel.IdNguoiDung);
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim", binhLuanModel.IdPhim);
            return View(binhLuanModel);
        }

        // GET: Admin/BinhLuan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuanModel = await _context.BinhLuan.FindAsync(id);
            if (binhLuanModel == null)
            {
                return NotFound();
            }
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan", binhLuanModel.IdNguoiDung);
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim", binhLuanModel.IdPhim);
            return View(binhLuanModel);
        }

        // POST: Admin/BinhLuan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdNguoiDung,IdPhim,NoiDung,NgayDang,TinhTrang")] BinhLuanModel binhLuanModel)
        {
            if (id != binhLuanModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(binhLuanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BinhLuanModelExists(binhLuanModel.Id))
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
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan", binhLuanModel.IdNguoiDung);
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim", binhLuanModel.IdPhim);
            return View(binhLuanModel);
        }

        // GET: Admin/BinhLuan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuanModel = await _context.BinhLuan
                .Include(b => b.NguoiDung)
                .Include(b => b.Phim)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (binhLuanModel == null)
            {
                return NotFound();
            }

            return View(binhLuanModel);
        }

        // POST: Admin/BinhLuan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var binhLuanModel = await _context.BinhLuan.FindAsync(id);
            _context.BinhLuan.Remove(binhLuanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BinhLuanModelExists(int id)
        {
            return _context.BinhLuan.Any(e => e.Id == id);
        }
    }
}
