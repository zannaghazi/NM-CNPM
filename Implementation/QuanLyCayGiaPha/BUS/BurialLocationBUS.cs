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
