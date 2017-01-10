using System;

namespace DTO
{
    public class CT_GiaoHangDTO
    {
        public string MaHD { get; set; }
        public string MaTB { get; set; }
        public int SLDaGiao { get; set; }
        public int DonGia { get; set; }
        public int SoTien { get; set; }
        public DateTime NgayLap{ get; set; }
        public DateTime NgayThuHoi { get; set; }
        public string NVGiao { get; set; }
    }
}
