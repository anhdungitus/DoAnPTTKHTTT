namespace DTO
{
    public class HopDongDTO
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public int ThoiGianDinhKi { get; set; }
        public bool PTThanhToan { get; set; }
        public bool TinhTrang { get; set; }
        public string TuyenDuong { get; set; }
        public System.DateTime NgayGiao { get; set; }
        public string DiaChi { get; set; } //Why nvarchar(10)
        public int Thue { get; set; }
        public int TongTien { get; set; } //Why float
        public int TienNhan { get; set; }
        public int No { get; set; }
    }
}
