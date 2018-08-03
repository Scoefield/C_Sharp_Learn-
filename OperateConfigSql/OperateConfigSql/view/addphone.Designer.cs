namespace OperateConfigSql.view
{
    partial class addphone
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.txtb_phone = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_decs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "号  码：";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(129, 39);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(125, 21);
            this.txtb_name.TabIndex = 2;
            // 
            // txtb_phone
            // 
            this.txtb_phone.Location = new System.Drawing.Point(129, 83);
            this.txtb_phone.Name = "txtb_phone";
            this.txtb_phone.Size = new System.Drawing.Size(125, 21);
            this.txtb_phone.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(65, 193);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "添加";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(213, 193);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "描  述：";
            // 
            // txtb_decs
            // 
            this.txtb_decs.Location = new System.Drawing.Point(131, 124);
            this.txtb_decs.Name = "txtb_decs";
            this.txtb_decs.Size = new System.Drawing.Size(123, 21);
            this.txtb_decs.TabIndex = 7;
            // 
            // addphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 260);
            this.Controls.Add(this.txtb_decs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtb_phone);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addphone";
            this.Text = "examadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.TextBox txtb_phone;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_decs;
    }
}