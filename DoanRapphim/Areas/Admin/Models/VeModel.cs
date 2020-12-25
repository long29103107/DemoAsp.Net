using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoanRapphim.Areas.Admin.Models
{
    public class VeModel
    {
        [Key]
        public int Id { get; set; } 
        public int IdNguoiDung { get; set; } 
        [ForeignKey("IdNguoiDung")]
        public virtual NguoiDungModel NguoiDung { get; set; }
        public int IdLoaiGhe { get; set; }  
        [ForeignKey("IdLoaiGhe")]
        public virtual LoaiGheModel LoaiGhe { get; set; }
        public int IdPhong { get; set; } 
        [ForeignKey("IdPhong")]
        public virtual PhongModel Phong { get; set; }
        public int IdPhim { get; set; }  
        [ForeignKey("IdPhim")]
        public virtual PhimModel Phim { get; set; }
        public string ThanhPho { get; set; } 
        public string QuanHuyen { get; set; } 
        public int IdRap { get; set; } 
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] 
        public DateTime NgayChieu { get; set; } 
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss tt}")]
        public DateTime GioChieu { get; set; }
        public string TenGhe { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayDat { get; set; } 
        public decimal GiaVe { get; set; } 
    }
}
