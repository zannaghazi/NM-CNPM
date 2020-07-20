using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DeathMemberDTO
    {
        private int maThanhVien;
        private int maNguyenNhan;
        private int maDiaDiem;
        private DateTime ngayMat;

        public DeathMemberDTO(int maThanhVien, int maNguyenNhan, int maDiaDiem, DateTime ngayMat)
        {
            this.maThanhVien = maThanhVien;
            this.maNguyenNhan = maNguyenNhan;
            this.maDiaDiem = maDiaDiem;
            this.ngayMat = ngayMat;
        }

        public int getMaThanhVien()
        {
            return this.maThanhVien;
        }

        public int getMaNguyenNhan()
        {
            return this.maNguyenNhan;
        }

        public int getMaDiaDiem()
        {
            return this.maDiaDiem;
        }

        public DateTime getNgayMat()
        {
            return this.ngayMat;
        }
    }
}
