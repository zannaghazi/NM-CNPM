using DAO;
using DTO;
using System;
using System.Collections.Generic;
using ViewModels;

namespace BUS
{
    public class MemberBUS
    {
        private MainBUS mainBus;
        private MemberDAO memberDAO;
        private SystemContrantDAO systemContrantDAO;
        private List<DTO.MemberDTO> data;

        public MemberBUS(MainBUS main)
        {
            this.mainBus = main;
            this.memberDAO = new MemberDAO(this.mainBus.GetCommand());
            this.systemContrantDAO = new SystemContrantDAO(this.mainBus.GetCommand());
            this.data = this.memberDAO.getAllMember();

        }

        public List<ViewModels.ThanhVienVM> GetListMember()
        {
            List<ThanhVienVM> result = new List<ThanhVienVM>();

            for (int i = 0; i < this.data.Count; i++)
            {
                int maNgheNghiep = this.data[i].getMaNgheNghiep();
                JobDTO ngheNghiep = this.systemContrantDAO.getJobByID(maNgheNghiep);
                ThanhVienVM temp = new ThanhVienVM(data[i], ngheNghiep);

                result.Add(temp);
            }

            return result;
        }

        public bool CheckLogin(string username, string password)
        {
            string systemPass = System.IO.File.ReadAllText("UserConfig.txt");
            if (username.Equals("admin") && password.Equals(systemPass))
            {
                return true;
            }

            return false;
        }

        public bool AddMember(MemberDTO member)
        {
            if (this.memberDAO.AddMember(member))
            {
                return true;
            }
            return false;
        }
    }
}
