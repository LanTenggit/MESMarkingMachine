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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.lb_send = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bn_Point = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口";
            // 
            // cb_com
            // 
            this.cb_com.FormattingEnabled = true;
            this.cb_com.Location = new System.Drawing.Point(69, 30);
            this.cb_com.Name = "cb_com";
            this.cb_com.Size = new System.Drawing.Size(77, 20);
            this.cb_com.TabIndex = 1;
            // 
            // cb_boty
            // 
            this.cb_boty.FormattingEnabled = true;
            this.cb_boty.Location = new System.Drawing.Point(226, 30);
            this.cb_boty.Name = "cb_boty";
            this.cb_boty.Size = new System.Drawing.Size(69, 20);
            this.cb_boty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // bn_sure
            // 
            this.bn_sure.Location = new System.Drawing.Point(315, 28);
            this.bn_sure.Name = "bn_sure";
            this.bn_sure.Size = new System.Drawing.Size(67, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指令设置";
            // 
            // tb_NG
            // 
            this.tb_NG.Location = new System.Drawing.Point(64, 57);
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
            this.label4.Location = new System.Drawing.Point(11, 60);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Y);
            this.groupBox2.Controls.Add(this.tb_X);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(285, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "坐标设置";
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(109, 57);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(63, 21);
            this.tb_Y.TabIndex = 3;
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(109, 24);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(63, 21);
            this.tb_X.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y轴偏移坐标";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "X轴偏移坐标";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_send);
            this.groupBox3.Controls.Add(this.lb_send);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(19, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息";
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(393, 28);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(45, 21);
            this.tb_send.TabIndex = 3;
            // 
            // lb_send
            // 
            this.lb_send.AutoSize = true;
            this.lb_send.Location = new System.Drawing.Point(283, 31);
            this.lb_send.Name = "lb_send";
            this.lb_send.Size = new System.Drawing.Size(29, 12);
            this.lb_send.TabIndex = 2;
            this.lb_send.Text = "Send";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "RGB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "坐标";
            // 
            // bn_Point
            // 
            this.bn_Point.Location = new System.Drawing.Point(394, 27);
            this.bn_Point.Name = "bn_Point";
            this.bn_Point.Size = new System.Drawing.Size(75, 23);
            this.bn_Point.TabIndex = 10;
            this.bn_Point.Text = "坐标";
            this.bn_Point.UseVisualStyleBackColor = true;
            this.bn_Point.Click += new System.EventHandler(this.bn_Point_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.bn_Point);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bn_sure);
            this.Controls.Add(this.cb_boty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_com);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "出标机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_send;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bn_Point;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

