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
        private MemberDTO data;

        private int formMode = -1;
        private readonly int ADD_MODE = 0;
        private readonly int VIEW_MODE = 1;
        public AddMember()
        {
            InitializeComponent();
        }

        public AddMember(MainForm parent, int mode, MemberDTO memberData = null)
        {
            InitializeComponent();
            this.formMode = mode;
            this.parent = parent;
            this.data = memberData;
            this.LoadBaseData();
            
        }

        public void LoadBaseData()
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

            if (this.formMode == this.ADD_MODE)
            {
                this.InitSettingAndDataForAddMode();
            }else if (this.formMode == this.VIEW_MODE)
            {
                this.InitSettingAndDataForViewMode();
            }else
            {
                this.InitSettingAdnDataForNonLogin();
            }
        }

        public void setEnableAndDisableAllField(bool mode)
        {
            this.cbRelationship.Enabled = mode;
            this.cbJob.Enabled = mode;
            this.cbGender.Enabled = mode;
            this.cbHometown.Enabled = mode;

            this.txtAddress.Enabled = mode;
            this.txtBirthday.Enabled = mode;
            this.txtGeneration.Enabled = mode;
            this.txtName.Enabled = mode;
            this.txtOldMember.Enabled = mode;
        }

        public void InitSettingAndDataForAddMode()
        {
            // form setting
            this.setEnableAndDisableAllField(true);
            this.lbTitle.Text = "THÊM THÀNH VIÊN MỚI";
            
            // init data
            this.cbHometown.SelectedIndex = 0;
            this.cbJob.SelectedIndex = 0;
            this.cbGender.SelectedIndex = 0;
            this.cbRelationship.SelectedIndex = 0;

            this.txtAddress.Text = "";
            this.txtBirthday.Value = DateTime.Now;
            this.txtGeneration.Text = "0";
            this.txtName.Text = "";
            this.txtOldMember.Text = "";

            this.btnSubmitArchieve.Visible = false;
            this.btnSave.Text = "Lưu";

            this.btnSave.Enabled = true;
        }

        public void InitSettingAndDataForViewMode()
        {
            // form setting
            this.setEnableAndDisableAllField(false);
            this.lbTitle.Text = "THÔNG TIN THÀNH VIÊN";

            if (this.data == null)
            {
                MessageBox.Show(
                    "Đã có lỗi xảy ra trong quá trình tải dữ liệu.\nHãy thử lại sau",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // init data
            this.cbHometown.SelectedIndex = this.data.getMaQueQuan() - 1;
            this.cbJob.SelectedIndex = this.data.getMaNgheNghiep() - 1;
            this.cbGender.SelectedIndex = this.data.getGioiTinh() ? 0 : 1;
            this.cbRelationship.SelectedIndex = this.data.getMaQuanHe() - 1;

            this.txtAddress.Text = this.data.getDiaChi().Trim();
            this.txtBirthday.Value = this.data.getNgaySinh();
            this.txtGeneration.Text = this.data.getDoi().ToString();
            this.txtName.Text = this.data.getTenThanhVien().Trim();
            this.txtOldMember.Text = this.data.getThanhVienCu().Trim();

            this.btnSubmitArchieve.Visible = true;
            this.btnSave.Text = "Ghi nhận thành tích";

            this.btnSubmitArchieve.Enabled = true;
            this.btnSave.Enabled = true;
        }

        public void InitSettingAdnDataForNonLogin()
        {
            // form setting
            this.setEnableAndDisableAllField(false);
            this.lbTitle.Text = "THÔNG TIN THÀNH VIÊN";

            if (this.data == null)
            {
                MessageBox.Show(
                    "Đã có lỗi xảy ra trong quá trình tải dữ liệu.\nHãy thử lại sau",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // init data
            this.cbHometown.SelectedIndex = this.data.getMaQueQuan() - 1;
            this.cbJob.SelectedIndex = this.data.getMaNgheNghiep() - 1;
            this.cbGender.SelectedIndex = this.data.getGioiTinh() ? 0 : 1;
            this.cbRelationship.SelectedIndex = this.data.getMaQuanHe() - 1;

            this.txtAddress.Text = this.data.getDiaChi().Trim();
            this.txtBirthday.Value = this.data.getNgaySinh();
            this.txtGeneration.Text = this.data.getDoi().ToString();
            this.txtName.Text = this.data.getTenThanhVien().Trim();
            this.txtOldMember.Text = this.data.getThanhVienCu().Trim();

            this.btnSubmitArchieve.Visible = true;
            this.btnSave.Text = "Ghi nhận thành tích";

            this.btnSubmitArchieve.Enabled = false;
            this.btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.formMode == this.ADD_MODE)
            {
                if (!this.ValidationData())
                {
                    MessageBox.Show("Thông tin nhập vào không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MemberDTO newMem = new MemberDTO(
                    this.cbHometown.SelectedIndex + 1,
                    this.cbRelationship.SelectedIndex + 1,
                    this.cbJob.SelectedIndex + 1,
                    this.txtName.Text.Trim(),
                    this.txtOldMember.Text.Trim(),
                    (this.cbGender.SelectedIndex == 0),
                    this.txtAddress.Text.Trim(),
                    this.txtBirthday.Value.Date,
                    false,
                    Int32.Parse(this.txtGeneration.Text.Trim()));

                if (this.parent.memberBus.AddMember(newMem))
                {
                    string message = "Thêm thành viên " + newMem.getTenThanhVien() + " thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string message = "Thêm thành viên " + newMem.getTenThanhVien() + " thất bại!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (this.formMode == this.VIEW_MODE)
            {
                AddArchieve addArchieve = new AddArchieve(this.data, this.parent)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                addArchieve.ShowDialog();
            }
        }
        private bool ValidationData()
        {
            if (cbHometown.SelectedIndex == -1 ||
                cbGender.SelectedIndex == -1 ||
                cbJob.SelectedIndex == -1 ||
                cbRelationship.SelectedIndex == -1)
            {
                return false;
            }

            if (String.IsNullOrEmpty(this.txtAddress.Text.Trim()) ||
                String.IsNullOrEmpty(this.txtGeneration.Text.Trim()) ||
                String.IsNullOrEmpty(this.txtName.Text.Trim()) ||
                String.IsNullOrEmpty(this.txtOldMember.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        private void txtGeneration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSubmitArchieve_Click(object sender, EventArgs e)
        {
            DeathRecord deathRecord = new DeathRecord(this.data, this.parent)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            deathRecord.ShowDialog();
        }
    }
}
