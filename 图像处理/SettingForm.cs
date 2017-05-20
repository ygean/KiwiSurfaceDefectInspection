using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图像处理
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            List<string> StrArr = null;
            StrArr = OperateXml.getAllXml();
            Yuzhi_textBox.Text = StrArr[0].ToString();
            Address_textBox.Text = StrArr[1].ToString();
            Time_textBox.Text = StrArr[3].ToString();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            string[] StrArr = new string[] {"","","",""};
            SettingForm form2 = new SettingForm();
            if (Yuzhi_textBox.Text!=""&&Address_textBox.Text!="")
            {
                StrArr[0] = Yuzhi_textBox.Text;
                StrArr[1] = Address_textBox.Text;
                StrArr[3] = Time_textBox.Text;
                OperateXml.modifyXml(StrArr);                                
            }
            else
            {
                MessageBox.Show("都不能为空");
            }
            
            
        }
    }
}
