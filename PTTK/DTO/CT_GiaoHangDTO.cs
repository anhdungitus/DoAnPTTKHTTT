using System;

namespace DTO
{
    public class CT_GiaoHangDTO
    {
        public string MaPGH { get; set; }
        public string MaTB { get; set; }
        public int SLDaGiao { get; set; }
        public float DonGia { get; set; }
        public float SoTien { get; set; }
        public DateTime NgayLap{ get; set; }
        public DateTime NgayThuHoi { get; set; }
    }
}
