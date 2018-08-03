using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperateConfigSql.view
{
    public partial class addphone : Form
    {
        public addphone()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(this.txtb_name.Text.Trim() != "" && this.txtb_phone.Text.Trim() != "")
            {
                string name = this.txtb_name.Text.Trim();
                string phone = this.txtb_phone.Text.Trim();
                string decs = this.txtb_decs.Text.Trim();
                string addsql = string.Format("INSERT INTO mobile(name,phone,decs) VALUES('{0}','{1}','{2}')", name, phone, decs);
                try
                {
                    helpersql.ExecuteScalar(CommandType.Text, addsql);
                    //Refreshexam();
                    MessageBox.Show("添加成功!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("添加失败!!!");
                }
            }
            else
            {
                MessageBox.Show("姓名或号码不能为空！！！");
            }
        }
    }
}
