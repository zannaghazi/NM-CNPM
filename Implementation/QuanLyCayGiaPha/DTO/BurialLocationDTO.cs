using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BurialLocationDTO
    {
        private int maDiaDiem;
        private string tenDiaDiem;
        private bool daXoa;

        public BurialLocationDTO(int maDiaDiem, string tenDiaDiem, bool daXoa)
        {
            this.maDiaDiem = maDiaDiem;
            this.tenDiaDiem = tenDiaDiem;
            this.daXoa = daXoa;
        }

        public int getMaDiaDiem()
        {
            return this.maDiaDiem;
        }

        public string getTenDiaDiem()
        {
            return this.tenDiaDiem;
        }
    }
}
