using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ArchieveTypeDTO
    {
        private int maLoaiThanhTich;
        private string tenLoaiThanhTich;
        private bool daXoa;

        public ArchieveTypeDTO(int maLoaiThanhTich, string tenLoaiThanhTich, bool daXoa)
        {
            this.maLoaiThanhTich = maLoaiThanhTich;
            this.tenLoaiThanhTich = tenLoaiThanhTich;
            this.daXoa = daXoa;
        }

        public int getMaLoaiThanhTich()
        {
            return this.maLoaiThanhTich;
        }

        public string getTenLoaiThanhTich()
        {
            return this.tenLoaiThanhTich;
        }
    }
}
