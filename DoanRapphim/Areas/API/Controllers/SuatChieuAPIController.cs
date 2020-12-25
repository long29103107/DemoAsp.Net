
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoanRapphim.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoanRapphim.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuatChieuAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public SuatChieuAPIController(DPContext context)
        {
            _context = context;
        }
        // GET: api/<SuatChieuAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var sc = _context.SuatChieu.ToList();
            var lsc = _context.LoaiSuatChieu.ToList();
            var lc = _context.LichChieu.ToList();
            var p = _context.Phim.ToList();
            var result = from suatchieu in sc
                         join loaisuatchieu in lsc on suatchieu.IdLoaiSuatChieu equals loaisuatchieu.Id
                         join phim in p on suatchieu.IdPhim equals phim.Id
                         join lichchieu in lc on suatchieu.IdLichChieu equals lichchieu.Id
                         select new
                         {
                             Id = suatchieu.Id,
                             TenLoai = loaisuatchieu.TenSuatChieu,
                             Phim = phim.TenPhim,
                             NgayChieu = lichchieu.NgayChieu,
                             GioChieu = suatchieu.GioChieu
                         };
            return new string[] { JsonConvert.SerializeObject(result) };
        }

        // GET api/<SuatChieuAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id,string tp,string qh,int rp,DateTime nc)
        {
            //var ds = _context.SuatChieu.ToList();
            //var dsloai = _context.LoaiSuatChieu.ToList();
            //var result = from suatchieu in ds
            //             join loaisuatchieu in dsloai on suatchieu.IdLoaiSuatChieu equals loaisuatchieu.Id
            //             where suatchieu.Id == id
            //             select new
            //             {
            //                 GioChieu = suatchieu.GioChieu,
            //                 TinhTrang = suatchieu.TinhTrang,
            //                 TenLoaiSuatChieu = loaisuatchieu.TenSuatChieu,
            //                 GiaLoaiSuatChieu = loaisuatchieu.GiaSuatChieu,
            //                 Id = suatchieu.Id
            //             };
            //return JsonConvert.SerializeObject(result);
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
                          where phim.Id == id && rap.ThanhPho == tp && rap.QuanHuyen == qh && rap.Id == rp && lichchieu.NgayChieu == nc
                          select new
                          {
                              GioChieu = suatchieu.GioChieu,
                          };
            var result = result1.GroupBy(i => i.GioChieu).Select(group => group.First());
            return JsonConvert.SerializeObject(result);
        }

        // POST api/<SuatChieuAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SuatChieuAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuatChieuAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
