namespace ClassLibraryOfBao
{
    partial class UserControlOclock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbGiay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPhut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbMiliGiay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(167, 182);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbGiay
            // 
            this.lbGiay.AutoSize = true;
            this.lbGiay.Location = new System.Drawing.Point(298, 93);
            this.lbGiay.Name = "lbGiay";
            this.lbGiay.Size = new System.Drawing.Size(24, 17);
            this.lbGiay.TabIndex = 16;
            this.lbGiay.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.Location = new System.Drawing.Point(248, 93);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(24, 17);
            this.lbPhut.TabIndex = 12;
            this.lbPhut.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Location = new System.Drawing.Point(198, 93);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(24, 17);
            this.lbGio.TabIndex = 10;
            this.lbGio.Text = "00";
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(337, 182);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(75, 23);
            this.btnLap.TabIndex = 18;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbMiliGiay
            // 
            this.lbMiliGiay.AutoSize = true;
            this.lbMiliGiay.Location = new System.Drawing.Point(334, 93);
            this.lbMiliGiay.Name = "lbMiliGiay";
            this.lbMiliGiay.Size = new System.Drawing.Size(24, 17);
            this.lbMiliGiay.TabIndex = 19;
            this.lbMiliGiay.Text = "00";
            // 
            // UserControlOclock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMiliGiay);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbGiay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPhut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGio);
            this.Name = "UserControlOclock";
            this.Size = new System.Drawing.Size(632, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbMiliGiay;
    }
}
