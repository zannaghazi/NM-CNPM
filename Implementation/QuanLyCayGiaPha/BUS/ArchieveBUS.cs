using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ArchieveBUS
    {
        private MainBUS mainBus;
        private ArchieveTypeDAO archieveTypeDAO;
        private ArchieveDetailDAO archieveDetailDAO;

        public ArchieveBUS(MainBUS main)
        {
            this.mainBus = main;
            this.archieveDetailDAO = new ArchieveDetailDAO(main.GetCommand());
            this.archieveTypeDAO = new ArchieveTypeDAO(main.GetCommand());
        }

        public List<string> getListArchiveTypeName()
        {
            List<string> result = new List<string>();

            List<ArchieveTypeDTO> data = this.archieveTypeDAO.getAllArchieveType();

            for (int i = 0; i < data.Count; i++)
            {
                result.Add(data[i].getTenLoaiThanhTich());
            }

            return result;
        }

        public bool AddArchieveDetail(ArchieveDetailDTO data)
        {
            return archieveDetailDAO.AddNewArchieveDetail(data);
        }
    }
}
