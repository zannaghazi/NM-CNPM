using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DeathReasonBUS
    {
        public MainBUS main;
        public DeathReasonDAO deathReasonDAO;

        public DeathReasonBUS(MainBUS main)
        {
            this.main = main;
            this.deathReasonDAO = new DeathReasonDAO(this.main.GetCommand());
        }

        public List<DeathReasonDTO> getAll()
        {
            return this.deathReasonDAO.getAllDeathReason();
        }
    }
}
