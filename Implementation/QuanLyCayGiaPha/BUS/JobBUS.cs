using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace BUS
{
    public class JobBUS
    {
        public MainBUS main;
        public JobDAO JobDAO;

        public JobBUS(MainBUS main)
        {
            this.main = main;
            this.JobDAO = new JobDAO(this.main.GetCommand());
        }

        public List<NgheNghiepVM> getAllTenNgheNghiep()
        {
            List<NgheNghiepVM> result = new List<NgheNghiepVM>();

            List<JobDTO> data = this.JobDAO.getAllJob();

            for (int i = 0; i < data.Count; i++)
            {
                NgheNghiepVM temp = new NgheNghiepVM(data[i]);
                result.Add(temp);
            }

            return result;
        }
    }
}
