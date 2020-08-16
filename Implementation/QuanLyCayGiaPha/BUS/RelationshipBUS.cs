using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace BUS
{
    public class RelationshipBUS
    {
        public MainBUS main;
        public RelationshipDAO relationshipDAO;

        public RelationshipBUS(MainBUS main)
        {
            this.main = main;
            this.relationshipDAO = new RelationshipDAO(this.main.GetCommand());
        }

        public List<QuanHeVM> getAllTenQuanHe()
        {
            List<QuanHeVM> result = new List<QuanHeVM>();

            List<RelationshipDTO> data = this.relationshipDAO.getAllRelation();

            for (int i = 0; i < data.Count; i++)
            {
                QuanHeVM temp = new QuanHeVM(data[i]);
                result.Add(temp);
            }

            return result;
        }
        public List<RelationshipDTO> getAll()
        {
            return relationshipDAO.getAllRelation();
        }
    }
}
