using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoanRapphim.Areas.Admin.Models;
using DoanRapphim.Data;
using Newtonsoft.Json;

namespace DoanRapphim.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VeController : Controller
    {
        private readonly DPContext _context;

        public VeController(DPContext context)
        {
            _context = context;
        }
        //[HttpPost]
        //public JsonResult AjaxPost(string json)
        //{
        //    VeModel ve = new VeModel();
        //    var a = JsonConvert.DeserializeObject(json);
        //    return Json(ve);
        //}
        // GET: Admin/Ve
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Ve.Include(v => v.LoaiGhe).Include(v => v.NguoiDung).Include(v => v.Phim).Include(v => v.Phong);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Ve/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veModel = await _context.Ve
                .Include(v => v.LoaiGhe)
                .Include(v => v.NguoiDung)
                .Include(v => v.Phim)
                .Include(v => v.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veModel == null)
            {
                return NotFound();
            }

            return View(veModel);
        }

        // GET: Admin/Ve/Create
        public IActionResult Create()
        {
            ViewData["IdLoaiGhe"] = new SelectList(_context.LoaiGhe, "Id", "TenLoaiGhe");
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan");
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim");
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong");
            return View();
        }

        // POST: Admin/Ve/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdNguoiDung,IdLoaiGhe,IdPhong,IdPhim,ThanhPho,QuanHuyen,IdRap,NgayChieu,GioChieu,TenGhe,NgayDat,GiaVe")] VeModel veModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdLoaiGhe"] = new SelectList(_context.LoaiGhe, "Id", "TenLoaiGhe", veModel.IdLoaiGhe);
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan", veModel.IdNguoiDung);
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim", veModel.IdPhim);
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong", veModel.IdPhong);
            return Json(veModel);
        }

        // GET: Admin/Ve/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veModel = await _context.Ve.FindAsync(id);
            if (veModel == null)
            {
                return NotFound();
            }
            ViewData["IdLoaiGhe"] = new SelectList(_context.LoaiGhe, "Id", "TenLoaiGhe", veModel.IdLoaiGhe);
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan", veModel.IdNguoiDung);
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim", veModel.IdPhim);
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong", veModel.IdPhong);
            return View(veModel);
        }

        // POST: Admin/Ve/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdNguoiDung,IdLoaiGhe,IdPhong,IdPhim,ThanhPho,QuanHuyen,IdRap,NgayChieu,GioChieu,TenGhe,NgayDat,GiaVe")] VeModel veModel)
        {
            if (id != veModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeModelExists(veModel.Id))
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
            ViewData["IdLoaiGhe"] = new SelectList(_context.LoaiGhe, "Id", "TenLoaiGhe", veModel.IdLoaiGhe);
            ViewData["IdNguoiDung"] = new SelectList(_context.NguoiDung, "Id", "TaiKhoan", veModel.IdNguoiDung);
            ViewData["IdPhim"] = new SelectList(_context.Phim, "Id", "TenPhim", veModel.IdPhim);
            ViewData["IdPhong"] = new SelectList(_context.Phong, "Id", "TenPhong", veModel.IdPhong);
            return View(veModel);
        }

        // GET: Admin/Ve/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veModel = await _context.Ve
                .Include(v => v.LoaiGhe)
                .Include(v => v.NguoiDung)
                .Include(v => v.Phim)
                .Include(v => v.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veModel == null)
            {
                return NotFound();
            }

            return View(veModel);
        }

        // POST: Admin/Ve/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veModel = await _context.Ve.FindAsync(id);
            _context.Ve.Remove(veModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeModelExists(int id)
        {
            return _context.Ve.Any(e => e.Id == id);
        }
    }
}
