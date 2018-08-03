namespace OperateConfigSql
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
            this.btn_test = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtb_quary = new System.Windows.Forms.TextBox();
            this.btn_quary = new System.Windows.Forms.Button();
            this.btn_flash = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进度条ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(3, 10);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "测试数据库";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_test);
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 41);
            this.panel1.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(403, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(61, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(336, 10);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(61, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(274, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "增加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 286);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯录";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phone,
            this.decs,
            this.phoneid});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(467, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "号码";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 150;
            // 
            // decs
            // 
            this.decs.DataPropertyName = "decs";
            this.decs.HeaderText = "描述";
            this.decs.Name = "decs";
            this.decs.ReadOnly = true;
            this.decs.Width = 160;
            // 
            // phoneid
            // 
            this.phoneid.DataPropertyName = "phoneid";
            this.phoneid.HeaderText = "phoneid";
            this.phoneid.Name = "phoneid";
            this.phoneid.ReadOnly = true;
            this.phoneid.Visible = false;
            // 
            // txtb_quary
            // 
            this.txtb_quary.Location = new System.Drawing.Point(275, 82);
            this.txtb_quary.Name = "txtb_quary";
            this.txtb_quary.Size = new System.Drawing.Size(123, 21);
            this.txtb_quary.TabIndex = 3;
            // 
            // btn_quary
            // 
            this.btn_quary.Location = new System.Drawing.Point(404, 80);
            this.btn_quary.Name = "btn_quary";
            this.btn_quary.Size = new System.Drawing.Size(61, 23);
            this.btn_quary.TabIndex = 4;
            this.btn_quary.Text = "查询";
            this.btn_quary.UseVisualStyleBackColor = true;
            this.btn_quary.Click += new System.EventHandler(this.btn_quary_Click);
            // 
            // btn_flash
            // 
            this.btn_flash.Location = new System.Drawing.Point(3, 80);
            this.btn_flash.Name = "btn_flash";
            this.btn_flash.Size = new System.Drawing.Size(75, 23);
            this.btn_flash.TabIndex = 5;
            this.btn_flash.Text = "刷新";
            this.btn_flash.UseVisualStyleBackColor = true;
            this.btn_flash.Click += new System.EventHandler(this.btn_flash_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(181, 82);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "导出Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(100, 82);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 7;
            this.btn_import.Text = "导入文本";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭ToolStripMenuItem.Text = "退出";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进度条ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 进度条ToolStripMenuItem
            // 
            this.进度条ToolStripMenuItem.Name = "进度条ToolStripMenuItem";
            this.进度条ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.进度条ToolStripMenuItem.Text = "进度条";
            this.进度条ToolStripMenuItem.Click += new System.EventHandler(this.进度条ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 426);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_flash);
            this.Controls.Add(this.btn_quary);
            this.Controls.Add(this.txtb_quary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtb_quary;
        private System.Windows.Forms.Button btn_quary;
        private System.Windows.Forms.Button btn_flash;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn decs;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneid;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进度条ToolStripMenuItem;
    }
}

