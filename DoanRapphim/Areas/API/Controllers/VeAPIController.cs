using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoanRapphim.Areas.Admin.Models;
using DoanRapphim.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoanRapphim.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public VeAPIController(DPContext context)
        {
            _context = context;
        }
        //GET: api/<VeAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VeAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("DSGhe")]
        public string Get(int id, string tp, string qh, int rp, DateTime nc, DateTime gc, int p,string dsghe)
        {
            JArray array = JsonConvert.DeserializeObject<JArray>(dsghe);
            var v = _context.Ve.ToList();
            for(int i = 0;i<array.Count;i++)
            {
                var ghe = array[i].ToString();
                var result = from ve in v
                              where ve.IdPhim == id && ve.ThanhPho == tp && ve.QuanHuyen == qh && ve.IdRap == rp && ve.NgayChieu == nc && ve.GioChieu == gc && ve.IdPhong == p && ve.TenGhe == ghe
                              select new
                              {
                                  TenGhe = ve.TenGhe,
                              };
                var count = result.ToList().Count;
                if (count != 0)
                {
                    array.RemoveAt(i);
                    i--;
                }
            }
            //var result = "";//result1.GroupBy(i => i.TenGhe).Select(group => group.First());
            return JsonConvert.SerializeObject(array);
        }

        [HttpGet("addve")]
        public string Get(int id, string tp, string qh, int rp, DateTime nc, DateTime gc, int p, int idnd, int lg, string ghe, DateTime nd, decimal gv)
        {
            JArray array = JsonConvert.DeserializeObject<JArray>(ghe);
            LinkedList<VeModel> list = new LinkedList<VeModel>();
            for (int i = 0; i < array.Count; i++)
            {
                VeModel veModel = new VeModel
                {
                    IdPhim = id,
                    ThanhPho = tp,
                    QuanHuyen = qh,
                    IdRap = rp,
                    NgayChieu = nc,
                    GioChieu = gc,
                    IdPhong = p,
                    IdNguoiDung = idnd,
                    IdLoaiGhe = lg,
                    TenGhe = array[i].ToString(),
                    NgayDat = nd,
                    GiaVe = gv,
                };
                list.AddLast(veModel);
                _context.Add(veModel);
                _context.SaveChanges();
            }
            return JsonConvert.SerializeObject(list);
        }

        // POST api/<VeAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VeAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VeAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
