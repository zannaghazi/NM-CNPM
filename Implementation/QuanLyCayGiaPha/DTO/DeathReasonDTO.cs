using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DeathReasonDTO
    {
        private int maNguyenNhan;
        private string tenNguyenNhan;
        private bool daXoa;

        public DeathReasonDTO(int maNguyenNhan, string tenNguyenNhan, bool daXoa)
        {
            this.maNguyenNhan = maNguyenNhan;
            this.tenNguyenNhan = tenNguyenNhan;
            this.daXoa = daXoa;
        }

        public int getMaNguyenNhan()
        {
            return this.maNguyenNhan;
        }

        public string getTenNguyenNhan()
        {
            return this.tenNguyenNhan;
        }
    }
}
