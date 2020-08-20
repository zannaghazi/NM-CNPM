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
        public DeathMemberDAO deathMemberDAO;

        public DeathReasonBUS(MainBUS main)
        {
            this.main = main;
            this.deathMemberDAO = new DeathMemberDAO(main.GetCommand());
            this.deathReasonDAO = new DeathReasonDAO(this.main.GetCommand());
        }

        public List<string> getListDeathReasonName()
        {
            List<string> result = new List<string>();

            List<DeathReasonDTO> data = this.deathReasonDAO.getAllDeathReason();

            for (int i = 0; i < data.Count; i++)
            {
                result.Add(data[i].getTenNguyenNhan());
            }                

            return result;
        }

        public bool AddDeathMember(DeathMemberDTO data)
        {
            return deathMemberDAO.AddNewDeathMemberDAO(data);
        }



        public List<DeathReasonDTO> getAll()
        {
            return this.deathReasonDAO.getAllDeathReason();
        }
        public bool AddDeathreason(DeathReasonDTO deathreas)
        {
            if (this.deathReasonDAO.AddDeathReason(deathreas))
            {
                return true;
            }
            return false;
        }
    }
}
