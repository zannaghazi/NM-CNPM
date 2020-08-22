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
using BUS;

namespace Presentation
{
    public partial class AddConfigForm : Form
    {
        MainForm mainForm;
        string title;

        public MainBUS mainBus;
        public HometownBUS hometownBUS;
        public JobBUS jobBUS;
        public RelationshipBUS relationshipBUS;
        public DeathReasonBUS deathReasonBUS;
        public BurialLocationBUS burialLocationBUS;


        public AddConfigForm(MainForm main)
        {
            this.mainForm = main;
            this.title = mainForm.cbLoaiQuyDinh.Text;
            InitializeComponent();
            initData();
            load_title();
        }
        private void initData()
        {
            this.mainBus = new MainBUS();
            this.deathReasonBUS = new DeathReasonBUS(mainBus);
            this.burialLocationBUS = new BurialLocationBUS(mainBus);
            this.hometownBUS = new HometownBUS(this.mainBus);
            this.jobBUS = new JobBUS(this.mainBus);
            this.relationshipBUS = new RelationshipBUS(this.mainBus);
        }
        private void load_title()
        {
            this.lblAddConfigTitle.Text = "THÊM " + title.ToUpper();
            this.lblTenQuanHeMoi.Text += title.ToLower() + " mới";
        }
        //          Loại quan hệ
        //          Quê quán
        //          Nghề nghiệp
        //          Nguyên nhân mất
        //          Địa điểm mai táng
        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            if (title == "Loại quan hệ")
            {
                RelationshipDTO relDTO = new RelationshipDTO(0, txtTenQuanHeMoi.Text, false);
                if (txtTenQuanHeMoi.Text != "")
                {
                    if (relationshipBUS.AddRel(relDTO))
                    {
                        MessageBox.Show("Thêm quan hệ mới thành công");
                        this.mainForm.Load_LoaiQuanHe();
                    }
                    else
                    {
                        MessageBox.Show("Thêm quan hệ mới thất bại, vui lòng kiểm tra lại");
                    }
                }
            }
            if (title == "Quê quán")
            {
                HometownDTO hometownDTO = new HometownDTO(0, txtTenQuanHeMoi.Text, false);
                if (txtTenQuanHeMoi.Text != "")
                {
                    if (hometownBUS.AddHometown(hometownDTO))
                    {
                        MessageBox.Show("Thêm quê quán mới thành công");
                        this.mainForm.Load_QueQuan();
                    }
                    else
                    {
                        MessageBox.Show("Thêm quê quán mới thất bại, vui lòng kiểm tra lại");
                    }
                }
            }
            if (title == "Nghề nghiệp")
            {
                JobDTO jobDTO = new JobDTO(0, txtTenQuanHeMoi.Text, false);
                if (txtTenQuanHeMoi.Text != "")
                {
                    if (jobBUS.AddJob(jobDTO))
                    {
                        MessageBox.Show("Thêm nghề nghiệp mới thành công");
                        this.mainForm.Load_NgheNghiep();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nghề nghiệp mới thất bại, vui lòng kiểm tra lại");
                    }
                }
            }
            if (title == "Nguyên nhân mất")
            {
                DeathReasonDTO deathReasonDTO = new DeathReasonDTO(0, txtTenQuanHeMoi.Text, false);
                if (txtTenQuanHeMoi.Text != "")
                {
                    if (deathReasonBUS.AddDeathreason(deathReasonDTO))
                    {
                        MessageBox.Show("Thêm nguyên nhân mất mới thành công");
                        this.mainForm.Load_NguyenNhanMat();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nguyên nhân mất mới thất bại, vui lòng kiểm tra lại");
                    }
                }
            }
            if (title == "Địa điểm mai táng")
            {
                BurialLocationDTO burialLocationDTO = new BurialLocationDTO(0, txtTenQuanHeMoi.Text, false);
                if (txtTenQuanHeMoi.Text != "")
                {
                    if (burialLocationBUS.AddBurialLoc(burialLocationDTO))
                    {
                        MessageBox.Show("Thêm địa điểm mai táng mới thành công");
                        this.mainForm.Load_DiaDiemMaiTang();
                    }
                    else
                    {
                        MessageBox.Show("Thêm địa điểm mai táng mới thất bại, vui lòng kiểm tra lại");
                    }
                }
            }
            this.Close();
        }
    }
}
