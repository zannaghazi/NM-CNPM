using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
using ViewModels;

namespace BUS
{
    public class HometownBUS
    {
        private MainBUS main;
        private HometownDAO hometownDAO;
        public HometownBUS(MainBUS main)
        {
            this.main = main;
            hometownDAO = new HometownDAO(this.main.GetCommand());
        }

        public List<QueQuanVM> getAllTenQueQuan()
        {
            List<QueQuanVM> result = new List<QueQuanVM>();

            List<HometownDTO> data = this.hometownDAO.getAllHomeTown();

            for (int i = 0; i < data.Count; i++)
            {
                QueQuanVM temp = new QueQuanVM(data[i]);
                result.Add(temp);
            }

            return result;
        }

        public List<HometownDTO> getAll()
        {
            return hometownDAO.getAllHomeTown();
        }
        public bool AddHometown(HometownDTO home)
        {
            if (this.hometownDAO.AddHomeTown(home))
            {
                return true;
            }
            return false;
        }
    }
}
