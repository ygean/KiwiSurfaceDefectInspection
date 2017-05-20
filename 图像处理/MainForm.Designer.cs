namespace 图像处理
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gray_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Binarize_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetTargetPix_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditXmlData_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoRun_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopRun_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "灰度化处理时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "二值化处理时间：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 153);
            this.panel1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "缺陷分级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "处理时间详情";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.处理ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.自动运行ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 25);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_ToolStripMenuItem,
            this.Close_ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // Open_ToolStripMenuItem
            // 
            this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
            this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.Open_ToolStripMenuItem.Text = "打开";
            this.Open_ToolStripMenuItem.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // Close_ToolStripMenuItem
            // 
            this.Close_ToolStripMenuItem.Name = "Close_ToolStripMenuItem";
            this.Close_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.Close_ToolStripMenuItem.Text = "关闭";
            this.Close_ToolStripMenuItem.Click += new System.EventHandler(this.Close_ToolStripMenuItem_Click);
            // 
            // 处理ToolStripMenuItem
            // 
            this.处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gray_ToolStripMenuItem,
            this.Binarize_ToolStripMenuItem,
            this.GetTargetPix_ToolStripMenuItem});
            this.处理ToolStripMenuItem.Name = "处理ToolStripMenuItem";
            this.处理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.处理ToolStripMenuItem.Text = "处理";
            // 
            // Gray_ToolStripMenuItem
            // 
            this.Gray_ToolStripMenuItem.Name = "Gray_ToolStripMenuItem";
            this.Gray_ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.Gray_ToolStripMenuItem.Text = "灰度化";
            this.Gray_ToolStripMenuItem.Click += new System.EventHandler(this.Gray_ToolStripMenuItem_Click);
            // 
            // Binarize_ToolStripMenuItem
            // 
            this.Binarize_ToolStripMenuItem.Name = "Binarize_ToolStripMenuItem";
            this.Binarize_ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.Binarize_ToolStripMenuItem.Text = "二值化";
            this.Binarize_ToolStripMenuItem.Click += new System.EventHandler(this.Binarize_ToolStripMenuItem_Click);
            // 
            // GetTargetPix_ToolStripMenuItem
            // 
            this.GetTargetPix_ToolStripMenuItem.Name = "GetTargetPix_ToolStripMenuItem";
            this.GetTargetPix_ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.GetTargetPix_ToolStripMenuItem.Text = "获取缺陷量";
            this.GetTargetPix_ToolStripMenuItem.Click += new System.EventHandler(this.GetTargetPix_ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditXmlData_ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // EditXmlData_ToolStripMenuItem
            // 
            this.EditXmlData_ToolStripMenuItem.Name = "EditXmlData_ToolStripMenuItem";
            this.EditXmlData_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.EditXmlData_ToolStripMenuItem.Text = "修改参数";
            this.EditXmlData_ToolStripMenuItem.Click += new System.EventHandler(this.EditXmlData_ToolStripMenuItem_Click);
            // 
            // 自动运行ToolStripMenuItem
            // 
            this.自动运行ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoRun_ToolStripMenuItem,
            this.StopRun_ToolStripMenuItem});
            this.自动运行ToolStripMenuItem.Name = "自动运行ToolStripMenuItem";
            this.自动运行ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.自动运行ToolStripMenuItem.Text = "自动运行";
            // 
            // AutoRun_ToolStripMenuItem
            // 
            this.AutoRun_ToolStripMenuItem.Name = "AutoRun_ToolStripMenuItem";
            this.AutoRun_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AutoRun_ToolStripMenuItem.Text = "启动";
            this.AutoRun_ToolStripMenuItem.Click += new System.EventHandler(this.AutoRun_ToolStripMenuItem_Click);
            // 
            // StopRun_ToolStripMenuItem
            // 
            this.StopRun_ToolStripMenuItem.Name = "StopRun_ToolStripMenuItem";
            this.StopRun_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.StopRun_ToolStripMenuItem.Text = "停止";
            this.StopRun_ToolStripMenuItem.Click += new System.EventHandler(this.StopRun_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "猕猴桃图像处理检测";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Close_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Gray_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Binarize_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetTargetPix_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditXmlData_ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem 自动运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoRun_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopRun_ToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort;
    }
}

