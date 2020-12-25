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
    public class LoaiGheAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public LoaiGheAPIController(DPContext context)
        {
            _context = context;
        }
        // GET: api/<LoaiGheAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoaiGheAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var lg = _context.LoaiGhe.ToList();
            var result = from loaighe in lg
                         where loaighe.Id == id
                         select new
                         {
                             Id = loaighe.Id,
                             GiaVe = loaighe.GiaGhe,
                         };
            return JsonConvert.SerializeObject(result);
        }

        // POST api/<LoaiGheAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoaiGheAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoaiGheAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
