using BUS;
using DTO;
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

namespace Presentation
{
    public partial class MainForm : Form
    {
        // Controlled variables
        public bool LOGIN_STATS = false;
        public string username = "";

        private int selectedMemberRow = -1;

        public MainBUS mainBus;
        public MemberBUS memberBus;
        public HometownBUS hometownBUS;
        public JobBUS jobBUS;
        public RelationshipBUS relationshipBUS;
        public DeathReasonBUS deathReasonBUS;
        public BurialLocationBUS burialLocationBUS;


        // Cache the tab control's page
        private TabPage cacheTabChange = null;
        private TabPage cacheTabReport = null;

        public MainForm()
        {
            InitializeComponent();
            this.InitFormSetting();
            this.InitData();
        }

        /// <summary>
        /// Edit customize setting for form
        /// </summary>
        private void InitFormSetting()
        {
            // Align column header to center
            this.tbMember.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbMember.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbMember.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbMember.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbMember.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // NON-LOGIN FORM
            this.cacheTabChange = this.tbChange;
            this.cacheTabReport = this.tbReport;
            this.tabControl.TabPages.Remove(this.tbChange);
            this.tabControl.TabPages.Remove(this.tbReport);

            this.btnAddMember.Enabled = false;
            this.LOGIN_STATS = false;
        }

        /// <summary>
        /// Initial data and references
        /// </summary>
        private void InitData()
        {
            this.mainBus = new MainBUS();
            this.deathReasonBUS = new DeathReasonBUS(mainBus);
            this.burialLocationBUS = new BurialLocationBUS(mainBus);
            this.memberBus = new MemberBUS(this.mainBus);
            this.hometownBUS = new HometownBUS(this.mainBus);
            this.jobBUS = new JobBUS(this.mainBus);
            this.relationshipBUS = new RelationshipBUS(this.mainBus);

            List<ThanhVienVM> allMember = this.memberBus.GetListMember();
            for (int i = 0; i < allMember.Count; i++) {
                this.tbMember.Rows.Add(
                    allMember[i].hoTen,
                    allMember[i].ngaySinh,
                    allMember[i].gioiTinh,
                    allMember[i].chaMe,
                    allMember[i].ngheNghiep);
            }
            this.tbMember.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.LOGIN_STATS == false)
            {
                LoginForm loginForm = new LoginForm(this);
                loginForm.ShowDialog();
            } else
            {
                this.LogoutCallBack();
            }
        }

        public void LoginCallBack()
        {
            this.btnLogin.Text = "ĐĂNG XUẤT: " + this.username;
            this.LOGIN_STATS = true;

            this.tabControl.TabPages.Add(this.cacheTabChange);
            this.tabControl.TabPages.Add(this.cacheTabReport);

            this.btnAddMember.Enabled = true;
            this.LOGIN_STATS = true;
        }

        public void LogoutCallBack()
        {
            this.tabControl.TabPages.Remove(this.tbChange);
            this.tabControl.TabPages.Remove(this.tbReport);

            this.btnAddMember.Enabled = false;
            this.LOGIN_STATS = false;

            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.username = "";
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMember addMemberForm = new AddMember(this, 0);
            addMemberForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = this.txtSearch.Text.Trim();

            this.tbMember.Rows.Clear();
            
            if (String.IsNullOrEmpty(keyword))
            {
                List<ThanhVienVM> Member = this.memberBus.GetListMember();
                for (int i = 0; i < Member.Count; i++)
                {
                    this.tbMember.Rows.Add(
                        Member[i].hoTen,
                        Member[i].ngaySinh,
                        Member[i].gioiTinh,
                        Member[i].chaMe,
                        Member[i].ngheNghiep);
                }
            }
            else
            {
                List<ThanhVienVM> Member = this.memberBus.FindMember(keyword);
                for (int i = 0; i < Member.Count; i++)
                {
                    this.tbMember.Rows.Add(
                        Member[i].hoTen,
                        Member[i].ngaySinh,
                        Member[i].gioiTinh,
                        Member[i].chaMe,
                        Member[i].ngheNghiep);
                }
            }
        }

        private void tbMember_SelectionChanged(object sender, EventArgs e)
        {
            if (selectedMemberRow == -1)
            {
                this.selectedMemberRow = this.tbMember.CurrentCell.RowIndex;
                return;
            }
            this.selectedMemberRow = this.tbMember.CurrentCell.RowIndex;
            List<DTO.MemberDTO> currentData = this.memberBus.GetCurrentDTO();
            AddMember viewForm = new AddMember(this, 1, currentData[this.selectedMemberRow]);
            if (this.LOGIN_STATS == false)
            {
                viewForm = new AddMember(this, 2, currentData[this.selectedMemberRow]);
            }
            viewForm.ShowDialog();
        }
        private void Load_grvLoaiQuanHe()
        {
            this.mainBus = new MainBUS();
            this.relationshipBUS = new RelationshipBUS(mainBus);
            grvAllQuyDinh.DataSource = this.relationshipBUS.getAll();
        }

        //private void cbLoaiQuyDinh_TextUpdate(object sender, EventArgs e)
        //{
        //    this.mainBus = new MainBUS();
        //    this.relationshipBUS = new RelationshipBUS(this.mainBus);

        //    grvAllQuyDinh.Rows.Clear();
        //    if (cbLoaiQuyDinh.Text == "Loại quan hệ") //sel ind already updated
        //    {
        //        List<RelationshipDTO> allRel = this.relationshipBUS.getAll();
        //        for (int i = 0; i < allRel.Count; i++)
        //        {
        //            this.grvAllQuyDinh.Rows.Add(
        //                allRel[i].getMaQuanHe(),
        //                allRel[i].getTenQuanHe());
        //        }
        //        this.grvAllQuyDinh.ClearSelection();
        //    }
        //}

        //          Loại quan hệ
        //          Quê quán
        //          Nghề nghiệp
        //          Nguyên nhân mất
        //          Địa điểm mai táng
        public void Load_DiaDiemMaiTang()
        {
            grvAllQuyDinh.Rows.Clear();
            grvAllQuyDinh.Columns.Clear();
            List<BurialLocationDTO> allBurialLoc = this.burialLocationBUS.getAll();

            grvAllQuyDinh.Columns.Add("MADIADIEMMAITANG", "Mã địa điểm mai táng");
            grvAllQuyDinh.Columns.Add("TENDIADIEMMAITANG", "Tên địa điểm mai táng");

            this.grvAllQuyDinh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grvAllQuyDinh.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            this.grvAllQuyDinh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grvAllQuyDinh.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < allBurialLoc.Count; i++)
            {
                this.grvAllQuyDinh.Rows.Add(
                    allBurialLoc[i].getMaDiaDiem(),
                    allBurialLoc[i].getTenDiaDiem());
            }
            this.grvAllQuyDinh.ClearSelection();
        }
        public void Load_NguyenNhanMat()
        {
            grvAllQuyDinh.Rows.Clear();
            grvAllQuyDinh.Columns.Clear();
            List<DeathReasonDTO> allDeathReason = this.deathReasonBUS.getAll();

            grvAllQuyDinh.Columns.Add("MANGUYENNHANCHET", "Mã nguyên nhân chết");
            grvAllQuyDinh.Columns.Add("TENNGUYENNHANCHET", "Tên nguyên nhân chết");

            this.grvAllQuyDinh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grvAllQuyDinh.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            this.grvAllQuyDinh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grvAllQuyDinh.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < allDeathReason.Count; i++)
            {
                this.grvAllQuyDinh.Rows.Add(
                    allDeathReason[i].getMaNguyenNhan(),
                    allDeathReason[i].getTenNguyenNhan());
            }
            this.grvAllQuyDinh.ClearSelection();
        }
        public void Load_NgheNghiep()
        {
            grvAllQuyDinh.Rows.Clear();
            grvAllQuyDinh.Columns.Clear();
            List<JobDTO> allJob = this.jobBUS.getAll();

            grvAllQuyDinh.Columns.Add("MANGHENGHIEP", "Mã nghề nghiệp");
            grvAllQuyDinh.Columns.Add("TENNGHENGHIEP", "Tên nghề nghiệp");

            this.grvAllQuyDinh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grvAllQuyDinh.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.grvAllQuyDinh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grvAllQuyDinh.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < allJob.Count; i++)
            {
                this.grvAllQuyDinh.Rows.Add(
                    allJob[i].getMaNgheNghiep(),
                    allJob[i].getTenNgheNghiep());
            }
            this.grvAllQuyDinh.ClearSelection();
        }
        public void Load_QueQuan()
        {
            grvAllQuyDinh.Rows.Clear();
            grvAllQuyDinh.Columns.Clear();
            List<HometownDTO> allHomeTown = this.hometownBUS.getAll();

            grvAllQuyDinh.Columns.Add("MAQUEQUAN", "Mã quê quán");
            grvAllQuyDinh.Columns.Add("TENQUEQUAN", "Tên quê quán");

            this.grvAllQuyDinh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grvAllQuyDinh.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.grvAllQuyDinh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grvAllQuyDinh.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < allHomeTown.Count; i++)
            {
                this.grvAllQuyDinh.Rows.Add(
                    allHomeTown[i].getMaQueQuan(),
                    allHomeTown[i].getTenQueQuan());
            }
            this.grvAllQuyDinh.ClearSelection();
        }
        public void Load_LoaiQuanHe()
        {
            grvAllQuyDinh.Rows.Clear();
            grvAllQuyDinh.Columns.Clear();
            List<RelationshipDTO> allRel = this.relationshipBUS.getAll();

            grvAllQuyDinh.Columns.Add("MAQUANHE", "Mã quan hệ");
            grvAllQuyDinh.Columns.Add("TENQUANHE", "Tên quan hệ");

            this.grvAllQuyDinh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grvAllQuyDinh.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.grvAllQuyDinh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvAllQuyDinh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grvAllQuyDinh.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < allRel.Count; i++)
            {
                this.grvAllQuyDinh.Rows.Add(
                    allRel[i].getMaQuanHe(),
                    allRel[i].getTenQuanHe());
            }
            this.grvAllQuyDinh.ClearSelection();
        }
        private void cbLoaiQuyDinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mainBus = new MainBUS();
            this.relationshipBUS = new RelationshipBUS(this.mainBus);

            string loaiQuanHe = cbLoaiQuyDinh.SelectedItem as string;
            if (loaiQuanHe == "Địa điểm mai táng")
            {
                Load_DiaDiemMaiTang();
            }
            if(loaiQuanHe == "Nguyên nhân mất")
            {
                Load_NguyenNhanMat();
            }
            if (loaiQuanHe == "Nghề nghiệp")
            {
                Load_NgheNghiep();
            }
            if (loaiQuanHe == "Quê quán")
            {
                Load_QueQuan();
            }
            if (loaiQuanHe == "Loại quan hệ")
            {
                Load_LoaiQuanHe();
            }
        }

        private void btnAddNewConfig_Click(object sender, EventArgs e)
        {
            AddConfigForm add_cnfg = new AddConfigForm(this);
            add_cnfg.ShowDialog();
        }
    }
}
