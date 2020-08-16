namespace Presentation
{
    partial class AddConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.lblAddConfigTitle = new System.Windows.Forms.Label();
            this.lblTenQuanHeMoi = new System.Windows.Forms.Label();
            this.txtTenQuanHeMoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Location = new System.Drawing.Point(189, 155);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(127, 59);
            this.btnAddConfig.TabIndex = 0;
            this.btnAddConfig.Text = "Thêm";
            this.btnAddConfig.UseVisualStyleBackColor = true;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // lblAddConfigTitle
            // 
            this.lblAddConfigTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddConfigTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddConfigTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAddConfigTitle.Name = "lblAddConfigTitle";
            this.lblAddConfigTitle.Size = new System.Drawing.Size(494, 76);
            this.lblAddConfigTitle.TabIndex = 1;
            this.lblAddConfigTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenQuanHeMoi
            // 
            this.lblTenQuanHeMoi.AutoSize = true;
            this.lblTenQuanHeMoi.Location = new System.Drawing.Point(3, 92);
            this.lblTenQuanHeMoi.Name = "lblTenQuanHeMoi";
            this.lblTenQuanHeMoi.Size = new System.Drawing.Size(29, 13);
            this.lblTenQuanHeMoi.TabIndex = 2;
            this.lblTenQuanHeMoi.Text = "Tên ";
            // 
            // txtTenQuanHeMoi
            // 
            this.txtTenQuanHeMoi.Location = new System.Drawing.Point(6, 117);
            this.txtTenQuanHeMoi.Name = "txtTenQuanHeMoi";
            this.txtTenQuanHeMoi.Size = new System.Drawing.Size(484, 20);
            this.txtTenQuanHeMoi.TabIndex = 3;
            // 
            // AddConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 235);
            this.Controls.Add(this.txtTenQuanHeMoi);
            this.Controls.Add(this.lblTenQuanHeMoi);
            this.Controls.Add(this.lblAddConfigTitle);
            this.Controls.Add(this.btnAddConfig);
            this.Name = "AddConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddConfigForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.Label lblAddConfigTitle;
        private System.Windows.Forms.Label lblTenQuanHeMoi;
        private System.Windows.Forms.TextBox txtTenQuanHeMoi;
    }
}