namespace WindowsFormsApp2
{
    partial class MTUCHECK
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_mtuCHECK = new System.Windows.Forms.Button();
            this.B_mtu1500 = new System.Windows.Forms.Button();
            this.B_mtu400 = new System.Windows.Forms.Button();
            this.T_mtuenter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_mtuetc = new System.Windows.Forms.Button();
            this.T_usermtu = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // B_mtuCHECK
            // 
            this.B_mtuCHECK.Location = new System.Drawing.Point(6, 12);
            this.B_mtuCHECK.Name = "B_mtuCHECK";
            this.B_mtuCHECK.Size = new System.Drawing.Size(222, 53);
            this.B_mtuCHECK.TabIndex = 5;
            this.B_mtuCHECK.Text = "CHECK MTU \r\n\r\nDISABLE MTU LOCK";
            this.B_mtuCHECK.UseVisualStyleBackColor = true;
            this.B_mtuCHECK.Click += new System.EventHandler(this.B_mtuCHECK_Click);
            // 
            // B_mtu1500
            // 
            this.B_mtu1500.Location = new System.Drawing.Point(104, 197);
            this.B_mtu1500.Name = "B_mtu1500";
            this.B_mtu1500.Size = new System.Drawing.Size(70, 25);
            this.B_mtu1500.TabIndex = 9;
            this.B_mtu1500.Text = "MTU1500";
            this.B_mtu1500.UseVisualStyleBackColor = true;
            this.B_mtu1500.Click += new System.EventHandler(this.B_mtu1500_Click);
            // 
            // B_mtu400
            // 
            this.B_mtu400.Location = new System.Drawing.Point(6, 197);
            this.B_mtu400.Name = "B_mtu400";
            this.B_mtu400.Size = new System.Drawing.Size(70, 25);
            this.B_mtu400.TabIndex = 8;
            this.B_mtu400.Text = "MTU400";
            this.B_mtu400.UseVisualStyleBackColor = true;
            this.B_mtu400.Click += new System.EventHandler(this.B_mtu400_Click);
            // 
            // T_mtuenter
            // 
            this.T_mtuenter.Location = new System.Drawing.Point(14, 100);
            this.T_mtuenter.Name = "T_mtuenter";
            this.T_mtuenter.Size = new System.Drawing.Size(140, 21);
            this.T_mtuenter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "네트워크 MTU 색인 입력";
            // 
            // B_mtuetc
            // 
            this.B_mtuetc.Location = new System.Drawing.Point(6, 244);
            this.B_mtuetc.Name = "B_mtuetc";
            this.B_mtuetc.Size = new System.Drawing.Size(70, 21);
            this.B_mtuetc.TabIndex = 10;
            this.B_mtuetc.Text = "etc MTU";
            this.B_mtuetc.UseVisualStyleBackColor = true;
            this.B_mtuetc.Click += new System.EventHandler(this.B_mtuetc_Click);
            // 
            // T_usermtu
            // 
            this.T_usermtu.Location = new System.Drawing.Point(80, 244);
            this.T_usermtu.Name = "T_usermtu";
            this.T_usermtu.Size = new System.Drawing.Size(139, 21);
            this.T_usermtu.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "MTU 색인값 고정";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.mtuhold);
            // 
            // MTUCHECK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 277);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.T_usermtu);
            this.Controls.Add(this.B_mtuetc);
            this.Controls.Add(this.B_mtu1500);
            this.Controls.Add(this.B_mtu400);
            this.Controls.Add(this.T_mtuenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_mtuCHECK);
            this.MaximizeBox = false;
            this.Name = "MTUCHECK";
            this.Text = "MTUCHECK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_mtuCHECK;
        private System.Windows.Forms.Button B_mtu1500;
        private System.Windows.Forms.Button B_mtu400;
        private System.Windows.Forms.TextBox T_mtuenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_mtuetc;
        private System.Windows.Forms.TextBox T_usermtu;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

