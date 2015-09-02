namespace mwClient
{
    partial class GateLogin
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
            this.components = new System.ComponentModel.Container();
            this.serverHostCb = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindidTb = new System.Windows.Forms.TextBox();
            this.platformCb = new System.Windows.Forms.ComboBox();
            this.portTb = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultStringLb = new System.Windows.Forms.Label();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serverHostCb
            // 
            this.serverHostCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverHostCb.FormattingEnabled = true;
            this.serverHostCb.Items.AddRange(new object[] {
            "192.168.199.224",
            "182.254.171.237",
            "127.0.0.1"});
            this.serverHostCb.Location = new System.Drawing.Point(33, 230);
            this.serverHostCb.Margin = new System.Windows.Forms.Padding(4);
            this.serverHostCb.Name = "serverHostCb";
            this.serverHostCb.Size = new System.Drawing.Size(180, 26);
            this.serverHostCb.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(270, 183);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.usernameTb);
            this.tabPage1.Controls.Add(this.passwordTb);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(262, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "账号密码登录";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(15, 34);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(148, 28);
            this.usernameTb.TabIndex = 5;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(15, 75);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(148, 28);
            this.passwordTb.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.bindidTb);
            this.tabPage2.Controls.Add(this.platformCb);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(262, 151);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "第三方登陆";
            // 
            // bindidTb
            // 
            this.bindidTb.Location = new System.Drawing.Point(40, 87);
            this.bindidTb.Margin = new System.Windows.Forms.Padding(4);
            this.bindidTb.Name = "bindidTb";
            this.bindidTb.Size = new System.Drawing.Size(148, 28);
            this.bindidTb.TabIndex = 1;
            // 
            // platformCb
            // 
            this.platformCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platformCb.FormattingEnabled = true;
            this.platformCb.Location = new System.Drawing.Point(40, 30);
            this.platformCb.Margin = new System.Windows.Forms.Padding(4);
            this.platformCb.Name = "platformCb";
            this.platformCb.Size = new System.Drawing.Size(180, 26);
            this.platformCb.TabIndex = 0;
            // 
            // portTb
            // 
            this.portTb.Location = new System.Drawing.Point(30, 269);
            this.portTb.Margin = new System.Windows.Forms.Padding(4);
            this.portTb.Name = "portTb";
            this.portTb.Size = new System.Drawing.Size(182, 28);
            this.portTb.TabIndex = 9;
            this.portTb.Text = "3014";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(144, 317);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(89, 18);
            this.statusLbl.TabIndex = 8;
            this.statusLbl.Text = "statusLbl";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultStringLb
            // 
            this.resultStringLb.AutoSize = true;
            this.resultStringLb.Location = new System.Drawing.Point(30, 385);
            this.resultStringLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultStringLb.Name = "resultStringLb";
            this.resultStringLb.Size = new System.Drawing.Size(62, 18);
            this.resultStringLb.TabIndex = 11;
            this.resultStringLb.Text = "label1";
            // 
            // GateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 451);
            this.Controls.Add(this.serverHostCb);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.portTb);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultStringLb);
            this.Name = "GateLogin";
            this.Text = "GateLogin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverHostCb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox bindidTb;
        private System.Windows.Forms.ComboBox platformCb;
        private System.Windows.Forms.TextBox portTb;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultStringLb;
        private System.Windows.Forms.BindingSource userDataBindingSource;
    }
}