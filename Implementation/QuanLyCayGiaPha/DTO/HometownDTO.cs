using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class HometownDTO
    {
        private int maQueQuan;
        private string tenQueQuan;
        private bool daXoa;

        public HometownDTO(int maQueQuan, string tenQueQuan, bool daXoa)
        {
            this.maQueQuan = maQueQuan;
            this.tenQueQuan = tenQueQuan;
            this.daXoa = daXoa;
        }

        public int getMaQueQuan()
        {
            return this.maQueQuan;
        }

        public string getTenQueQuan()
        {
            return this.tenQueQuan;
        }

        public bool getDaXoa()
        {
            return this.daXoa;
        }
    }
}
