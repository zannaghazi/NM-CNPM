﻿using DAO;
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
        private List<DTO.MemberDTO> data;
        private JobDAO jobDAO;

        public MemberBUS(MainBUS main)
        {
            this.mainBus = main;
            this.memberDAO = new MemberDAO(this.mainBus.GetCommand());
            this.jobDAO = new JobDAO(this.mainBus.GetCommand());
            this.data = this.memberDAO.getAllMember();

        }

        public List<ViewModels.ThanhVienVM> GetListMember()
        {
            List<ThanhVienVM> result = new List<ThanhVienVM>();
            this.data = this.memberDAO.getAllMember();
            for (int i = 0; i < this.data.Count; i++)
            {
                int maNgheNghiep = this.data[i].getMaNgheNghiep();
                JobDTO ngheNghiep = this.jobDAO.getJobByID(maNgheNghiep);
                ThanhVienVM temp = new ThanhVienVM(data[i], ngheNghiep);

                result.Add(temp);
            }

            return result;
        }

        public List<ViewModels.ThanhVienVM> FindMember(string keyword)
        {
            List<ThanhVienVM> result = new List<ThanhVienVM>();
            this.data = this.memberDAO.findMember(keyword);
            for (int i = 0; i < this.data.Count; i++)
            {
                int maNgheNghiep = this.data[i].getMaNgheNghiep();
                JobDTO ngheNghiep = this.jobDAO.getJobByID(maNgheNghiep);
                ThanhVienVM temp = new ThanhVienVM(data[i], ngheNghiep);

                result.Add(temp);
            }

            return result;
        }

        public List<ViewModels.ThanhVienVM> GetListCurrentMember()
        {
            List<ThanhVienVM> result = new List<ThanhVienVM>();
            for (int i = 0; i < this.data.Count; i++)
            {
                int maNgheNghiep = this.data[i].getMaNgheNghiep();
                JobDTO ngheNghiep = this.jobDAO.getJobByID(maNgheNghiep);
                ThanhVienVM temp = new ThanhVienVM(data[i], ngheNghiep);

                result.Add(temp);
            }

            return result;
        }

        public List<MemberDTO> GetCurrentDTO()
        {
            return this.data;
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

        public bool AdjustMemberStatus(MemberDTO member)
        {
            if (this.memberDAO.AdjustMemberStatus(member))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
    }
}
