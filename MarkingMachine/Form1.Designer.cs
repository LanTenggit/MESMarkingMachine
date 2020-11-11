namespace MarkingMachine
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_com = new System.Windows.Forms.ComboBox();
            this.cb_boty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_sure = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NG = new System.Windows.Forms.TextBox();
            this.tb_OK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.lb_send = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口";
            // 
            // cb_com
            // 
            this.cb_com.FormattingEnabled = true;
            this.cb_com.Location = new System.Drawing.Point(59, 32);
            this.cb_com.Name = "cb_com";
            this.cb_com.Size = new System.Drawing.Size(57, 20);
            this.cb_com.TabIndex = 1;
            // 
            // cb_boty
            // 
            this.cb_boty.FormattingEnabled = true;
            this.cb_boty.Location = new System.Drawing.Point(189, 32);
            this.cb_boty.Name = "cb_boty";
            this.cb_boty.Size = new System.Drawing.Size(57, 20);
            this.cb_boty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // bn_sure
            // 
            this.bn_sure.Location = new System.Drawing.Point(270, 12);
            this.bn_sure.Name = "bn_sure";
            this.bn_sure.Size = new System.Drawing.Size(75, 23);
            this.bn_sure.TabIndex = 4;
            this.bn_sure.Text = "打开";
            this.bn_sure.UseVisualStyleBackColor = true;
            this.bn_sure.Click += new System.EventHandler(this.bn_sure_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_NG);
            this.groupBox1.Controls.Add(this.tb_OK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指令设置";
            // 
            // tb_NG
            // 
            this.tb_NG.Location = new System.Drawing.Point(239, 27);
            this.tb_NG.Name = "tb_NG";
            this.tb_NG.Size = new System.Drawing.Size(63, 21);
            this.tb_NG.TabIndex = 3;
            // 
            // tb_OK
            // 
            this.tb_OK.Location = new System.Drawing.Point(64, 24);
            this.tb_OK.Name = "tb_OK";
            this.tb_OK.Size = new System.Drawing.Size(63, 21);
            this.tb_OK.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "NG指令";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "OK指令";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_send);
            this.groupBox3.Controls.Add(this.lb_send);
            this.groupBox3.Location = new System.Drawing.Point(19, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息";
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(239, 22);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(63, 21);
            this.tb_send.TabIndex = 3;
            // 
            // lb_send
            // 
            this.lb_send.AutoSize = true;
            this.lb_send.Location = new System.Drawing.Point(68, 31);
            this.lb_send.Name = "lb_send";
            this.lb_send.Size = new System.Drawing.Size(29, 12);
            this.lb_send.TabIndex = 2;
            this.lb_send.Text = "Send";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "设置模板";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bn_sure);
            this.Controls.Add(this.cb_boty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_com);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "出标机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_com;
        private System.Windows.Forms.ComboBox cb_boty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_sure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_NG;
        private System.Windows.Forms.TextBox tb_OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_send;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
    }
}

