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
    public partial class DeathRecord : Form
    {
        private MemberDTO member;
        private MainForm parent;
        public DeathRecord()
        {
            InitializeComponent();
        }

        public DeathRecord(MemberDTO member, MainForm parent)
        {
            InitializeComponent();
            this.member = member;
            this.parent = parent;
            this.InitSettingAndData();
        }

        public void InitSettingAndData()
        {
            this.lbName.Text = member.getTenThanhVien();
            
            //Add reasonData to combobox
            List<string> reasonData = this.parent.deathReasonBUS.getListDeathReasonName();
            for (int i = 0; i < reasonData.Count; i++)
            {
                this.cbReason.Items.Add(reasonData[i]);
            }
            this.cbReason.SelectedIndex = 0;

            //Add LocationData to combobox
            List<string> LocationData = this.parent.burialLocationBUS.getListBurialLocationName();
            for (int i = 0; i < LocationData.Count; i++)
            {
                this.cbLocation.Items.Add(LocationData[i]);
            }
            this.cbLocation.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int reason = this.cbReason.SelectedIndex + 1;
            int location = this.cbLocation.SelectedIndex + 1;
            DateTime date = this.txtDate.Value;

            DeathMemberDTO data = new DeathMemberDTO(this.member.getMaThanhVien(), reason, location, date);
            //Kiểm tra trường hợp
            if (this.member.getTrangThaiMat()) //Nếu thành viên đã mất
            {
                //Còn lỗi nếu ghi nhận cho 1 người nhiều lần liên tục, do dữ liệu trên mainform chưa được cập nhật
                //sau khi ghi nhận dưới cơ sở dữ liệu
                MessageBox.Show("Không thể ghi nhận cho người đã chết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            //Thêm vào cơ sở dữ liệu
            else if (this.parent.deathReasonBUS.AddDeathMember(data) && this.parent.memberBus.AdjustMemberStatus(this.member))
            {
                //Vì dữ liệu trong database đã thay đổi, nhưng chỉ có 1 biến nên cập nhật lại cả 1 form thì quá tiêu tốn tài nguyên
                //nên ta chủ động thay đổi dữ liệu trên mainform
                this.member.changeTrangThaiMat();
                MessageBox.Show("Ghi nhận thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ghi nhận thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
