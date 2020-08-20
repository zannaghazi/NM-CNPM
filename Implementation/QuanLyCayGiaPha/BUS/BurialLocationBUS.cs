using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class BurialLocationBUS
    {
        private MainBUS main;
        private BurialLocationDAO burialLocationDAO;
        public BurialLocationBUS(MainBUS main)
        {
            this.main = main;
            burialLocationDAO = new BurialLocationDAO(this.main.GetCommand());
        }

        public List<string> getListBurialLocationName()
        {
            List<string> result = new List<string>();

            List<BurialLocationDTO> data = this.burialLocationDAO.getAll();

            for (int i = 0; i < data.Count; i++)
            {
                result.Add(data[i].getTenDiaDiem());
            }

            return result;
        }

        public List<BurialLocationDTO> getAll()
        {
            return burialLocationDAO.getAll();
        }
        public bool AddBurialLoc(BurialLocationDTO loc)
        {
            if (this.burialLocationDAO.AddBurialLoc(loc))
            {
                return true;
            }
            return false;
        }
    }
}
