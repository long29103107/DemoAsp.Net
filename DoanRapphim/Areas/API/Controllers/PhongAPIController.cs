using DoanRapphim.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoanRapphim.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public PhongAPIController(DPContext context)
        {
            _context = context;
        }
        // GET: api/<PhongAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("DSPhong")]
        public string DSphong()
        {

            var dsphong = _context.Phong.ToList();
            var dsrapchieuphim = _context.RapChieuPhim.ToList();
            var Kq = from phong in dsphong
                     join rapchieuphim in dsrapchieuphim on phong.IdRapChieu equals rapchieuphim.Id
                     select new
                     {
                         tenrap = rapchieuphim.TenRapChieu,
                         tenphong = phong.TenPhong,
                         soluonghang = phong.SoLuongHang,
                         soluongcot = phong.SoLuongCot,
                         Id = phong.Id
                     };
            return JsonConvert.SerializeObject(Kq);
        }
        // GET api/<PhongAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id,string tp,string qh,int rp,DateTime nc,DateTime gc)
        {
            var lc = _context.LichChieu.ToList();
            var phi = _context.Phim.ToList();
            var pho = _context.Phong.ToList();
            var sc = _context.SuatChieu.ToList();
            var lp = _context.LoaiPhim.ToList();
            var r = _context.RapChieuPhim.ToList();
            var result1 = from phim in phi
                          join suatchieu in sc on phim.Id equals suatchieu.IdPhim
                          join loaiphim in lp on phim.IdLoaiPhim equals loaiphim.Id
                          join lichchieu in lc on suatchieu.IdLichChieu equals lichchieu.Id
                          join phong in pho on lichchieu.IdPhong equals phong.Id
                          join rap in r on phong.IdRapChieu equals rap.Id
                          where phim.Id == id && rap.ThanhPho == tp && rap.QuanHuyen == qh && rap.Id == rp && lichchieu.NgayChieu == nc && suatchieu.GioChieu == gc
                          select new
                          {
                              Id = phong.Id,
                              TenPhong = phong.TenPhong,
                          };
            //var result = result1.GroupBy(i => i.GioChieu).Select(group => group.First());
            return JsonConvert.SerializeObject(result1);
        }

        [HttpGet("Hang")]
        public string Hangcot(int id, string tp, string qh, int rp, DateTime nc, DateTime gc,int p)
        {
            var lc = _context.LichChieu.ToList();
            var phi = _context.Phim.ToList();
            var pho = _context.Phong.ToList();
            var sc = _context.SuatChieu.ToList();
            var lp = _context.LoaiPhim.ToList();
            var r = _context.RapChieuPhim.ToList();
            var result1 = from phim in phi
                          join suatchieu in sc on phim.Id equals suatchieu.IdPhim
                          join loaiphim in lp on phim.IdLoaiPhim equals loaiphim.Id
                          join lichchieu in lc on suatchieu.IdLichChieu equals lichchieu.Id
                          join phong in pho on lichchieu.IdPhong equals phong.Id
                          join rap in r on phong.IdRapChieu equals rap.Id
                          where phim.Id == id && rap.ThanhPho == tp && rap.QuanHuyen == qh && rap.Id == rp && lichchieu.NgayChieu == nc && suatchieu.GioChieu == gc && phong.Id == p
                          select new
                          {
                              tenphong = phong.TenPhong,
                              soluonghang = phong.SoLuongHang,
                              soluongcot = phong.SoLuongCot,
                              Id = phong.Id
                          };
            //var result = result1.GroupBy(i => i.GioChieu).Select(group => group.First());
            return JsonConvert.SerializeObject(result1);
        }

        // POST api/<PhongAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhongAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhongAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
