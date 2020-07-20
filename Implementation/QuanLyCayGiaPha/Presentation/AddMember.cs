using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using DTO;

namespace Presentation
{
    public partial class AddMember : Form
    {
        private MainForm parent;
        public AddMember()
        {
            InitializeComponent();
        }

        public AddMember(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.LoadData();
        }

        public void LoadData()
        {
            List<QueQuanVM> dataQueQuan = parent.hometownBUS.getAllTenQueQuan();
            for (int i = 0; i < dataQueQuan.Count; i++)
            {
                this.cbHometown.Items.Add(dataQueQuan[i].tenQueQuan);
            }
            List<NgheNghiepVM> dataNgheNghiep = parent.jobBUS.getAllTenNgheNghiep();
            for (int i = 0; i < dataNgheNghiep.Count; i++)
            {
                this.cbJob.Items.Add(dataNgheNghiep[i].tenNgheNghiep);
            }
            this.cbGender.Items.Add("Nam");
            this.cbGender.Items.Add("Nữ");
            List<QuanHeVM> dataQuanHe = parent.relationshipBUS.getAllTenQuanHe();
            for (int  i = 0; i < dataQuanHe.Count; i++)
            {
                this.cbRelationship.Items.Add(dataQuanHe[i].tenQuanHe);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // DUMMY DATA
            MemberDTO newMem = new MemberDTO(
                1,
                1,
                4,
                "Game thủ",
                "Võ Thanh Game Thủ",
                false,
                "Hồ Chí Minh",
                DateTime.Now,
                false,
                3);

            if (this.parent.memberBus.AddMember(newMem))
            {
                string message = "Thêm thành viên " + newMem.getTenThanhVien() + " thành công!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                string message = "Thêm thành viên " + newMem.getTenThanhVien() + " thất bại!";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
