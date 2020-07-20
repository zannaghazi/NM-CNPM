using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class RelationshipDTO
    {
        private int maQuanHe;
        private string tenQuanHe;
        private bool daXoa;

        public RelationshipDTO(int maQuanHe, string tenQuanHe, bool daXoa)
        {
            this.maQuanHe = maQuanHe;
            this.tenQuanHe = tenQuanHe;
            this.daXoa = daXoa;
        }

        public int getMaQuanHe()
        {
            return this.maQuanHe;
        }

        public string getTenQuanHe()
        {
            return this.tenQuanHe;
        }
    }
}
