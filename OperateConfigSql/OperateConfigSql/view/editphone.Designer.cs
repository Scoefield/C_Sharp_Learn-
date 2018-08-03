namespace OperateConfigSql.view
{
    partial class editphone
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
            this.txtb_edecs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtb_ephone = new System.Windows.Forms.TextBox();
            this.txtb_ename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb_edecs
            // 
            this.txtb_edecs.Location = new System.Drawing.Point(131, 127);
            this.txtb_edecs.Name = "txtb_edecs";
            this.txtb_edecs.Size = new System.Drawing.Size(123, 21);
            this.txtb_edecs.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "描  述：";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(213, 196);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(65, 196);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "确定";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtb_ephone
            // 
            this.txtb_ephone.Location = new System.Drawing.Point(129, 86);
            this.txtb_ephone.Name = "txtb_ephone";
            this.txtb_ephone.Size = new System.Drawing.Size(125, 21);
            this.txtb_ephone.TabIndex = 11;
            // 
            // txtb_ename
            // 
            this.txtb_ename.Location = new System.Drawing.Point(129, 42);
            this.txtb_ename.Name = "txtb_ename";
            this.txtb_ename.Size = new System.Drawing.Size(125, 21);
            this.txtb_ename.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "号  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓  名：";
            // 
            // editphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.txtb_edecs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtb_ephone);
            this.Controls.Add(this.txtb_ename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editphone";
            this.Text = "editphone";
            this.Load += new System.EventHandler(this.editphone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_edecs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtb_ephone;
        private System.Windows.Forms.TextBox txtb_ename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}