using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime dtNow, dtSet; //定义两个时间变量，用来显示当前时间以及设置时间

        private void 系统时间_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //如果按钮显示的是设置，那么按下以后显示“终止”计时
            if (button1.Text == "设置") 
            {
                button1.Text = "停止";
                计时控制.Start();//启动计时控制
                label6.Text = "倒计时开始";
            }
            else if(button1.Text == "停止")
            {
                button1.Text = "设置";
                计时控制.Stop();
                label6.Text = "倒计时取消";
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            系统时间.Interval = 1000;//设置“系统时间”组件，的执行时间间隔
            系统时间.Enabled = true; // 启动“系统时间”组件
            numericUpDown1.Value = DateTime.Now.Minute;//显示当前分
            numericUpDown2.Value = DateTime.Now.Second;//显示当前秒

        }
    }
}
