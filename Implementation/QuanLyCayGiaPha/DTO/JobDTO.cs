using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class JobDTO
    {
        private int maNgheNghiep;
        private string tenNgheNghiep;
        private bool daXoa;

        public JobDTO(int maNgheNghiep, string tenNgheNghiep, bool daXoa)
        {
            this.maNgheNghiep = maNgheNghiep;
            this.tenNgheNghiep = tenNgheNghiep;
            this.daXoa = daXoa;
        }

        public string getTenNgheNghiep()
        {
            return this.tenNgheNghiep;
        }
    }
}
