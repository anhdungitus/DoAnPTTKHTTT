using System;
namespace DTO
{
    public class PhieuGiaoHangDTO
    {
        public string MaPhieu { get; set; }
        public string MaHD { get; set; }
        public string TuyenDuong { get; set; }
        public DateTime NgayGiao { get; set; }
        public string DiaChi { get; set; } //Why nvarchar(10)
        public string NVGiao { get; set; }
        public int Thue { get; set; }
        public float TongTien { get; set; } //Why float
        public float TienNhan { get; set; }
        public float No { get; set; }
    }
}
