using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Presentation
{
    public partial class AddArchieve : Form
    {
        private MemberDTO member;
        private MainForm parent;
        public AddArchieve()
        {
            InitializeComponent();
        }

        public AddArchieve(MemberDTO member, MainForm parent)
        {
            InitializeComponent();
            this.member = member;
            this.parent = parent;
            this.InitSettingAndData();
        }

        public void InitSettingAndData()
        {
            this.lbName.Text = this.member.getTenThanhVien();

            // Add type to combobox
            List<string> typeData = this.parent.archieveBUS.getListArchiveTypeName();
            for (int i = 0; i < typeData.Count; i++) {
                this.cbType.Items.Add(typeData[i]);
            }
            this.cbType.SelectedIndex = 0;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;

            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Bạn chưa nhập tên thành tích", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int type = this.cbType.SelectedIndex + 1;
            DateTime date = this.txtDate.Value;
            
            ArchieveDetailDTO data = new ArchieveDetailDTO(-1, this.member.getMaThanhVien(), type, date, name);
            if (this.parent.archieveBUS.AddArchieveDetail(data))
            {
                MessageBox.Show("Ghi nhận thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }else
            {
                MessageBox.Show("Ghi nhận thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
