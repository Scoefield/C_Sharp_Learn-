using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace OperateConfigSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (helpersql.Testcon())
            {
                MessageBox.Show("数据库连接成功！", "tips");
            }
            else
            {
                MessageBox.Show("数据库连接失败！！！");
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            view.addphone exaddform = new view.addphone();
            exaddform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (helpersql.Testcon())
            {
                try
                {
                    dataGridView1.AutoGenerateColumns = false;
                    string sqlquary = string.Format("SELECT * FROM mobile");
                    DataSet dataset = helpersql.GetDataSet(CommandType.Text, sqlquary);
                    dataGridView1.DataSource = dataset.Tables[0];
                    dataGridView1.ClearSelection();
                }
                catch(Exception)
                {
                    
                }
            }
            dataGridView1.CellClick += DataGridView1_CellClick;     //dataGridView 点击触发事件
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int i = e.RowIndex;
                mobilephone mphone = new mobilephone();
                mphone.phoneid = Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value.ToString());
                mphone.name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                mphone.phone = dataGridView1.Rows[i].Cells[1].Value.ToString();
                mphone.decs = dataGridView1.Rows[i].Cells[2].Value.ToString();
                //session.clearsession();
                session.selectphone = helpersql.GetDataSet(CommandType.Text,string.Format("SELECT * FROM mobile WHERE phoneid={0}", mphone.phoneid)).Tables[0].ToModels<mobilephone>().First();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)   //修改按钮触发
        {
            //if(dataGridView1.SelectedRows.Count > 0)    //判断是否选择了一行
            //{
            //    //MessageBox.Show("It has been select row");
            //    view.editphone editform = new view.editphone();
            //    editform.Show();
            //}
            if (session.selectphone == null)
            {
                MessageBox.Show("请选择一个号码！");
            }
            else
            {
                view.editphone editphone = new view.editphone();
                editphone.Show();
            }
        }

        private void btn_flash_Click(object sender, EventArgs e)    //刷新按钮触发
        {
            //清空 dataGridView1 内容，保留第一行的字段
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;

            //查询并在 dataGridView1 中显示内容
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                string sqlquary = string.Format("SELECT * FROM mobile");
                DataSet dataset = helpersql.GetDataSet(CommandType.Text, sqlquary);
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)   //删除按钮触发
        {
            if (session.selectphone != null)
            {
                if (MessageBox.Show("确认删除？选中的信息都会删除!!!", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sqlstr = string.Format("DELETE FROM mobile WHERE phoneid={0}", session.selectphone.phoneid);
                    try
                    {
                        //helpersql.ExecuteNonQuery(CommandType.Text, sqlstr);
                        helpersql.ExecuteScalar(CommandType.Text, sqlstr);
                        //refreshexam();
                        MessageBox.Show("删除成功!!!");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("删除失败!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择你要删除的数据!!!");
            }
        }

        private void btn_quary_Click(object sender, EventArgs e)
        {
            //清空 dataGridView1 内容，保留第一行的字段
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;

            string quaryname = txtb_quary.Text;
            //查询并在 dataGridView1 中显示内容
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                string sqlquary = string.Format("SELECT * FROM mobile WHERE name='{0}'", quaryname);    //根据姓名来查询
                DataSet dataset = helpersql.GetDataSet(CommandType.Text, sqlquary);
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (CommandHelper.ExportExcel(session.selectphone.name + "号码", dataGridView1))
            {
                MessageBox.Show("文件： " + session.selectphone.name + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            List<string> sqllist = new List<string>();
            //int phoneid = session.selectphone.phoneid;
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入试卷代号..."));
                Task t1 = Task.Factory.StartNew(() => {
                    string[] aList = File.ReadAllLines(ofd1.FileName, Encoding.UTF8);
                    string sqlorigin = "TRUNCATE TABLE mobile;";  //清空表
                    sqllist.Add(sqlorigin);
                    foreach (var a in aList)
                    {
                        Console.WriteLine(a);
                        string[] a1 = a.Split('\t');    //Tab键分隔
                        try
                        {
                            string sql = string.Format("INSERT INTO mobile(name, phone, decs) VALUES ('{0}','{1}','{2}')", a1[0].Trim(), a1[1].Trim(), a1[2].Trim());
                            //string sql1 = string.Format("INSERT INTO AI_paper (papercode,lm_postfix,name,`desc`,status,examid) VALUES ('{0}','{1}','{2}','{2}','0',{3})", a1[1].Trim(), a1[2].Trim(), a1[3].Trim(), examid);
                            sqllist.Add(sql);
                            //sqllist.Add(sql1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    helpersql.ExecuteSqlTran(sqllist);
                });
                // textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入试卷代号成功!!!"));
                //MessageBox.Show("导入成功！");
            }

        }

        private void 进度条ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Processbar processbar = new view.Processbar();
            processbar.Show();
        }
    }
}
