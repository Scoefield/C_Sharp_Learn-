using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OperateConfigSql.view
{
    public partial class Processbar : Form
    {
        public Processbar()
        {
            InitializeComponent();
        }

        private void Processbar_Load(object sender, EventArgs e)
        {

        }

        //定义一个代理，用于更新ProgressBar的值（Value）及在执行方法的时候，返回方法的处理信息。
        private delegate void SetPos(int ipos, string vinfo);//代理委托

        //进度条值更新函数
        private void SetTextMesssage(int ipos, string vinfo)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMesssage);
                this.Invoke(setpos, new object[] { ipos, vinfo });
            }
            else
            {
                this.label1.Text = ipos.ToString() + "/100";
                this.progressBar1.Value = Convert.ToInt32(ipos);
                this.txt_show.AppendText(vinfo);
            }
        }

        //开始按钮函数实现
        private void btn_start_Click(object sender, EventArgs e)
        {
            Thread fThread = new Thread(new ThreadStart(SleepT));   //创建线程
            fThread.Start();    //开启线程
        }

        //新的线程执行函数
        private void SleepT()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(5);   //5毫秒更新一次
                SetTextMesssage(100 * i / 500, i.ToString() + "\r\n");
            }
        }
    }
}
