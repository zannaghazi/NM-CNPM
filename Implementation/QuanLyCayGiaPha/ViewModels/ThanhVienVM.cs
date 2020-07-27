using System;

namespace ViewModels
{
    public class ThanhVienVM
    {
        public int ID;
        public int maThanhVien;
        public string hoTen;
        public string ngaySinh;
        public string gioiTinh;
        public string chaMe;
        public string ngheNghiep;

        public ThanhVienVM(DTO.MemberDTO memberDTO, DTO.JobDTO jobDTO)
        {
            this.ID = memberDTO.getMaThanhVien();
            this.maThanhVien = memberDTO.getMaThanhVien();
            this.hoTen = memberDTO.getTenThanhVien();
            this.ngaySinh = memberDTO.getNgaySinh().ToString("dd/MM/yyyy");
            if (memberDTO.getGioiTinh())
            {
                this.gioiTinh = "Nam";
            }else
            {
                this.gioiTinh = "Nữ";
            }
            if (memberDTO.getMaQuanHe() == 1)
            {
                this.chaMe = memberDTO.getThanhVienCu();
            }else
            {
                this.chaMe = "";
            }
            this.ngheNghiep = jobDTO.getTenNgheNghiep();
        }
    }
}
