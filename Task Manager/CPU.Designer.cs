﻿
namespace Task_Manager
{
    partial class CPU
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.storage_main_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuUsagePb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.cpuSpeedPb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuTempPb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.userName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.computerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cpuUsagePb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // storage_main_title
            // 
            this.storage_main_title.AutoSize = true;
            this.storage_main_title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_main_title.Location = new System.Drawing.Point(34, 27);
            this.storage_main_title.Name = "storage_main_title";
            this.storage_main_title.Size = new System.Drawing.Size(156, 26);
            this.storage_main_title.TabIndex = 3;
            this.storage_main_title.Text = "CPU Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU Usage";
            // 
            // cpuUsagePb
            // 
            this.cpuUsagePb.Controls.Add(this.cpuUsageLabel);
            this.cpuUsagePb.FillThickness = 10;
            this.cpuUsagePb.Location = new System.Drawing.Point(71, 478);
            this.cpuUsagePb.Name = "cpuUsagePb";
            this.cpuUsagePb.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.cpuUsagePb.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.cpuUsagePb.ProgressThickness = 10;
            this.cpuUsagePb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuUsagePb.ShadowDecoration.Parent = this.cpuUsagePb;
            this.cpuUsagePb.Size = new System.Drawing.Size(129, 128);
            this.cpuUsagePb.TabIndex = 6;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsageLabel.Location = new System.Drawing.Point(38, 57);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(57, 19);
            this.cpuUsageLabel.TabIndex = 10;
            this.cpuUsageLabel.Text = "00:00%";
            // 
            // cpuSpeedPb
            // 
            this.cpuSpeedPb.FillThickness = 10;
            this.cpuSpeedPb.Location = new System.Drawing.Point(328, 478);
            this.cpuSpeedPb.Name = "cpuSpeedPb";
            this.cpuSpeedPb.ProgressThickness = 10;
            this.cpuSpeedPb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuSpeedPb.ShadowDecoration.Parent = this.cpuSpeedPb;
            this.cpuSpeedPb.Size = new System.Drawing.Size(129, 128);
            this.cpuSpeedPb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Core Speed";
            // 
            // cpuTempPb
            // 
            this.cpuTempPb.FillThickness = 10;
            this.cpuTempPb.Location = new System.Drawing.Point(585, 478);
            this.cpuTempPb.Name = "cpuTempPb";
            this.cpuTempPb.ProgressThickness = 10;
            this.cpuTempPb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuTempPb.ShadowDecoration.Parent = this.cpuTempPb;
            this.cpuTempPb.Size = new System.Drawing.Size(129, 128);
            this.cpuTempPb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPU Temperature";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(17, 446);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(750, 26);
            this.guna2Separator1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 20;
            this.guna2CustomGradientPanel2.Controls.Add(this.userName);
            this.guna2CustomGradientPanel2.Controls.Add(this.label7);
            this.guna2CustomGradientPanel2.Controls.Add(this.computerName);
            this.guna2CustomGradientPanel2.Controls.Add(this.label5);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(39, 68);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(364, 148);
            this.guna2CustomGradientPanel2.TabIndex = 18;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(6, 96);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(53, 23);
            this.userName.TabIndex = 14;
            this.userName.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Code Name";
            // 
            // computerName
            // 
            this.computerName.AutoSize = true;
            this.computerName.BackColor = System.Drawing.Color.Transparent;
            this.computerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerName.Location = new System.Drawing.Point(6, 37);
            this.computerName.Name = "computerName";
            this.computerName.Size = new System.Drawing.Size(53, 23);
            this.computerName.TabIndex = 12;
            this.computerName.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPU Name";
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cpuTempPb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpuSpeedPb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpuUsagePb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storage_main_title);
            this.Name = "CPU";
            this.Size = new System.Drawing.Size(789, 679);
            this.Load += new System.EventHandler(this.CPU_Load);
            this.cpuUsagePb.ResumeLayout(false);
            this.cpuUsagePb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storage_main_title;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuUsagePb;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuSpeedPb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuTempPb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label computerName;
        private System.Windows.Forms.Label label5;
    }
}