using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace ViewModels
{
    public class QueQuanVM
    {
        public string tenQueQuan;

        public QueQuanVM(HometownDTO hometownDTO)
        {
            this.tenQueQuan = hometownDTO.getTenQueQuan();
        }
    }
}
