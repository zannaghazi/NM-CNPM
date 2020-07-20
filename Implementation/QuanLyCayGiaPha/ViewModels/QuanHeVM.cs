using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace ViewModels
{
    public class QuanHeVM
    {
        public string tenQuanHe;

        public QuanHeVM(RelationshipDTO relateDTO)
        {
            this.tenQuanHe = relateDTO.getTenQuanHe();
        }
    }
}
