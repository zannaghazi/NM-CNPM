using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class NgheNghiepVM
    {
        public string tenNgheNghiep;

        public NgheNghiepVM(DTO.JobDTO job)
        {
            this.tenNgheNghiep = job.getTenNgheNghiep();
        }
    }
}
