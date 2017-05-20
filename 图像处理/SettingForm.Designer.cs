namespace 图像处理
{
    partial class SettingForm
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
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Yuzhi_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(156, 151);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_Btn.TabIndex = 0;
            this.Edit_Btn.Text = "确定";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Yuzhi_textBox
            // 
            this.Yuzhi_textBox.Location = new System.Drawing.Point(156, 28);
            this.Yuzhi_textBox.Name = "Yuzhi_textBox";
            this.Yuzhi_textBox.Size = new System.Drawing.Size(100, 21);
            this.Yuzhi_textBox.TabIndex = 1;
            this.Yuzhi_textBox.Text = "-255~255之间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "二值化阈值：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "工业相机照片保存路径：";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(156, 73);
            this.Address_textBox.Multiline = true;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(215, 21);
            this.Address_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "间隔时间（ms）:";
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(156, 116);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(100, 21);
            this.Time_textBox.TabIndex = 7;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 200);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yuzhi_textBox);
            this.Controls.Add(this.Edit_Btn);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.TextBox Yuzhi_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Time_textBox;
    }
}