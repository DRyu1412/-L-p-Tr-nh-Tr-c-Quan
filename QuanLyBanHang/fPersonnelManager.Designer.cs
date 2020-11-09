namespace QuanLyBanHang
{
    partial class fPersonnelManager
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
            this.tabControl_PM = new System.Windows.Forms.TabControl();
            this.tabPage_PM = new System.Windows.Forms.TabPage();
            this.tabPage_AccountManager = new System.Windows.Forms.TabPage();
            this.groupBox_EmployeeInFo = new System.Windows.Forms.GroupBox();
            this.tabControl_PM.SuspendLayout();
            this.tabPage_PM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_PM
            // 
            this.tabControl_PM.Controls.Add(this.tabPage_PM);
            this.tabControl_PM.Controls.Add(this.tabPage_AccountManager);
            this.tabControl_PM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_PM.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_PM.Location = new System.Drawing.Point(0, 0);
            this.tabControl_PM.Name = "tabControl_PM";
            this.tabControl_PM.SelectedIndex = 0;
            this.tabControl_PM.Size = new System.Drawing.Size(1240, 782);
            this.tabControl_PM.TabIndex = 0;
            this.tabControl_PM.Tag = "";
            // 
            // tabPage_PM
            // 
            this.tabPage_PM.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_PM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_PM.Controls.Add(this.groupBox_EmployeeInFo);
            this.tabPage_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_PM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage_PM.Location = new System.Drawing.Point(4, 38);
            this.tabPage_PM.Name = "tabPage_PM";
            this.tabPage_PM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PM.Size = new System.Drawing.Size(1232, 740);
            this.tabPage_PM.TabIndex = 0;
            this.tabPage_PM.Text = "Quản Lý Nhân Sự ";
            // 
            // tabPage_AccountManager
            // 
            this.tabPage_AccountManager.Location = new System.Drawing.Point(4, 38);
            this.tabPage_AccountManager.Name = "tabPage_AccountManager";
            this.tabPage_AccountManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AccountManager.Size = new System.Drawing.Size(1232, 740);
            this.tabPage_AccountManager.TabIndex = 1;
            this.tabPage_AccountManager.Text = "Quản Lý Tài Khoản";
            this.tabPage_AccountManager.UseVisualStyleBackColor = true;
            // 
            // groupBox_EmployeeInFo
            // 
            this.groupBox_EmployeeInFo.BackColor = System.Drawing.Color.White;
            this.groupBox_EmployeeInFo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox_EmployeeInFo.Location = new System.Drawing.Point(3, 6);
            this.groupBox_EmployeeInFo.Name = "groupBox_EmployeeInFo";
            this.groupBox_EmployeeInFo.Size = new System.Drawing.Size(722, 399);
            this.groupBox_EmployeeInFo.TabIndex = 0;
            this.groupBox_EmployeeInFo.TabStop = false;
            this.groupBox_EmployeeInFo.Text = "Thông Tin Nhân Viên";
            // 
            // fPersonnelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 778);
            this.Controls.Add(this.tabControl_PM);
            this.Name = "fPersonnelManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fPersonnelManager";
            this.tabControl_PM.ResumeLayout(false);
            this.tabPage_PM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_PM;
        private System.Windows.Forms.TabPage tabPage_PM;
        private System.Windows.Forms.GroupBox groupBox_EmployeeInFo;
        private System.Windows.Forms.TabPage tabPage_AccountManager;
    }
}