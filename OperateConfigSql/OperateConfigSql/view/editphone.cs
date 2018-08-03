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
    public partial class editphone : Form
    {
        public editphone()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editphone_Load(object sender, EventArgs e)
        {
            txtb_ename.Text = session.selectphone.name;
            txtb_ephone.Text = session.selectphone.phone;
            txtb_edecs.Text = session.selectphone.decs;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (this.txtb_ename.Text.Trim() != "")
            {
                string name = this.txtb_ename.Text.Trim();
                string phone = this.txtb_ephone.Text.Trim();
                string decs = this.txtb_edecs.Text.Trim();
                string sqlstr = string.Format("UPDATE mobile SET name = '{0}', phone = '{1}', decs ='{2}'  WHERE phoneid={3}", name, phone, decs, session.selectphone.phoneid);
                try
                {
                    helpersql.ExecuteScalar(CommandType.Text, sqlstr);
                    //Refreshexam();
                    MessageBox.Show("修改成功!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失败!!!");
                }

            }
            else
            {

                MessageBox.Show("名称不能为空!!!");
                return;
            }
        }
    }
}
