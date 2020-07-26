using BUS;
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
        public bool LOGIN_STATS = false;
        public string username = "";

        public MainBUS mainBus;
        public MemberBUS memberBus;
        public HometownBUS hometownBUS;
        public JobBUS jobBUS;
        public RelationshipBUS relationshipBUS;

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
            AddMember addMemberForm = new AddMember(this);
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
    }
}
