using System;

namespace DTO
{
    public class MemberDTO
    {
        private int maThanhVien;
        private int maQueQuan;
        private int maLoaiQuanHe;
        private int maNgheNghiep;
        private string tenThanhVien;
        private string thanhVienCu;
        private DateTime ngayPhatSinh;
        private bool gioiTinh;
        private string diaChi;
        private DateTime ngaySinh;
        private bool trangThaiMat;
        private int doi;

        public MemberDTO()
        {

        }

        public MemberDTO(int maThanhVien, int maQueQuan, int maLoaiQuanHe, int maNgheNghiep, string tenThanhVien,
            string thanhvienCu, DateTime ngayPhatSinh, bool gioiTinh, string diaChi, DateTime ngaySinh, bool trangThaiMat, int doi)
        {
            this.maThanhVien = maThanhVien;
            this.maQueQuan = maQueQuan;
            this.maLoaiQuanHe = maLoaiQuanHe;
            this.maNgheNghiep = maNgheNghiep;
            this.tenThanhVien = tenThanhVien;
            this.thanhVienCu = thanhvienCu;
            this.ngayPhatSinh = ngayPhatSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.trangThaiMat = trangThaiMat;
            this.doi = doi;
        }

        public MemberDTO(int maQueQuan, int maLoaiQuanHe, int maNgheNghiep, string tenThanhVien,
            string thanhvienCu, bool gioiTinh, string diaChi, DateTime ngaySinh, bool trangThaiMat, int doi)
        {
            this.maQueQuan = maQueQuan;
            this.maLoaiQuanHe = maLoaiQuanHe;
            this.maNgheNghiep = maNgheNghiep;
            this.tenThanhVien = tenThanhVien;
            this.thanhVienCu = thanhvienCu;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.trangThaiMat = trangThaiMat;
            this.doi = doi;
        }

        public string getDiaChi()
        {
            return this.diaChi;
        }
        public bool getTrangThaiMat()
        {
            return this.trangThaiMat;
        }
        public int getDoi()
        {
            return this.doi;
        }
        public int getMaQueQuan()
        {
            return this.maQueQuan;
        }
        public string getTenThanhVien()
        {
            return this.tenThanhVien;
        }

        public int getMaQuanHe()
        {
            return this.maLoaiQuanHe;
        }
        public string getThanhVienCu()
        {
            return this.thanhVienCu;
        }

        public DateTime getNgaySinh()
        {
            return this.ngaySinh;
        }

        public int getMaNgheNghiep()
        {
            return this.maNgheNghiep;
        }

        public bool getGioiTinh()
        {
            return this.gioiTinh;
        }

        public int getMaThanhVien()
        {
            return this.maThanhVien;
        }

        public void changeTrangThaiMat()
        {
            this.trangThaiMat = true;
        }
    }
}
