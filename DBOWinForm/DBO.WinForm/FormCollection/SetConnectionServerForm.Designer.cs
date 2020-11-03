namespace DBO.WinForm.FormCollection
{
    partial class SetConnectionServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetConnectionServerForm));
            this.pnl_SetConnectionServer_Head = new System.Windows.Forms.Panel();
            this.lbl_SetConnectionServer_HeadTitle = new System.Windows.Forms.Label();
            this.pnl_SetConnectionServer_Background = new System.Windows.Forms.Panel();
            this.lbl_SetConnection_ServerType = new System.Windows.Forms.Label();
            this.lbl_SetConnection_UserAccount = new System.Windows.Forms.Label();
            this.lbl_SetConnection_Authentication = new System.Windows.Forms.Label();
            this.lbl_SetConnection_ServerPortName = new System.Windows.Forms.Label();
            this.lbl_SetConnection_UserPassword = new System.Windows.Forms.Label();
            this.chk_SetConnection_RemberPssword = new System.Windows.Forms.CheckBox();
            this.pic_SetConnection_BelowSplitLine = new System.Windows.Forms.PictureBox();
            this.pic_SetConnection_CenterSpliterLine = new System.Windows.Forms.PictureBox();
            this.cmb_SetConnection_ServerType = new System.Windows.Forms.ComboBox();
            this.cmb_SetConnection_Authentication = new System.Windows.Forms.ComboBox();
            this.cmb_SetConnection_UserAccount = new System.Windows.Forms.ComboBox();
            this.cmb_SetConnection_ServerPortName = new System.Windows.Forms.ComboBox();
            this.tb_SetConnection_UserPad = new System.Windows.Forms.TextBox();
            this.btn_SetConnection_ConnectionToServer = new System.Windows.Forms.Button();
            this.btn_SetConnection_CancleToServer = new System.Windows.Forms.Button();
            this.pnl_SetConnectionServer_Head.SuspendLayout();
            this.pnl_SetConnectionServer_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SetConnection_BelowSplitLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SetConnection_CenterSpliterLine)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_SetConnectionServer_Head
            // 
            this.pnl_SetConnectionServer_Head.Controls.Add(this.lbl_SetConnectionServer_HeadTitle);
            this.pnl_SetConnectionServer_Head.Location = new System.Drawing.Point(3, 3);
            this.pnl_SetConnectionServer_Head.Name = "pnl_SetConnectionServer_Head";
            this.pnl_SetConnectionServer_Head.Size = new System.Drawing.Size(730, 80);
            this.pnl_SetConnectionServer_Head.TabIndex = 0;
            // 
            // lbl_SetConnectionServer_HeadTitle
            // 
            this.lbl_SetConnectionServer_HeadTitle.AutoSize = true;
            this.lbl_SetConnectionServer_HeadTitle.Font = new System.Drawing.Font("微软雅黑", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SetConnectionServer_HeadTitle.Location = new System.Drawing.Point(252, 17);
            this.lbl_SetConnectionServer_HeadTitle.Name = "lbl_SetConnectionServer_HeadTitle";
            this.lbl_SetConnectionServer_HeadTitle.Size = new System.Drawing.Size(184, 43);
            this.lbl_SetConnectionServer_HeadTitle.TabIndex = 0;
            this.lbl_SetConnectionServer_HeadTitle.Text = "服务器连接";
            // 
            // pnl_SetConnectionServer_Background
            // 
            this.pnl_SetConnectionServer_Background.Controls.Add(this.pnl_SetConnectionServer_Head);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.btn_SetConnection_CancleToServer);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.btn_SetConnection_ConnectionToServer);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.tb_SetConnection_UserPad);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.cmb_SetConnection_ServerPortName);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.cmb_SetConnection_UserAccount);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.cmb_SetConnection_Authentication);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.cmb_SetConnection_ServerType);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.pic_SetConnection_BelowSplitLine);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.chk_SetConnection_RemberPssword);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.lbl_SetConnection_UserPassword);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.lbl_SetConnection_ServerPortName);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.lbl_SetConnection_Authentication);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.lbl_SetConnection_UserAccount);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.lbl_SetConnection_ServerType);
            this.pnl_SetConnectionServer_Background.Controls.Add(this.pic_SetConnection_CenterSpliterLine);
            this.pnl_SetConnectionServer_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SetConnectionServer_Background.Location = new System.Drawing.Point(0, 0);
            this.pnl_SetConnectionServer_Background.Name = "pnl_SetConnectionServer_Background";
            this.pnl_SetConnectionServer_Background.Size = new System.Drawing.Size(730, 377);
            this.pnl_SetConnectionServer_Background.TabIndex = 1;
            // 
            // lbl_SetConnection_ServerType
            // 
            this.lbl_SetConnection_ServerType.AutoSize = true;
            this.lbl_SetConnection_ServerType.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SetConnection_ServerType.Location = new System.Drawing.Point(39, 104);
            this.lbl_SetConnection_ServerType.Name = "lbl_SetConnection_ServerType";
            this.lbl_SetConnection_ServerType.Size = new System.Drawing.Size(156, 23);
            this.lbl_SetConnection_ServerType.TabIndex = 2;
            this.lbl_SetConnection_ServerType.Text = "服务器类型（T）：";
            // 
            // lbl_SetConnection_UserAccount
            // 
            this.lbl_SetConnection_UserAccount.AutoSize = true;
            this.lbl_SetConnection_UserAccount.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SetConnection_UserAccount.Location = new System.Drawing.Point(74, 208);
            this.lbl_SetConnection_UserAccount.Name = "lbl_SetConnection_UserAccount";
            this.lbl_SetConnection_UserAccount.Size = new System.Drawing.Size(121, 23);
            this.lbl_SetConnection_UserAccount.TabIndex = 3;
            this.lbl_SetConnection_UserAccount.Text = "登录名（L）：";
            // 
            // lbl_SetConnection_Authentication
            // 
            this.lbl_SetConnection_Authentication.AutoSize = true;
            this.lbl_SetConnection_Authentication.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SetConnection_Authentication.Location = new System.Drawing.Point(54, 175);
            this.lbl_SetConnection_Authentication.Name = "lbl_SetConnection_Authentication";
            this.lbl_SetConnection_Authentication.Size = new System.Drawing.Size(141, 23);
            this.lbl_SetConnection_Authentication.TabIndex = 4;
            this.lbl_SetConnection_Authentication.Text = "身份验证（A）：";
            // 
            // lbl_SetConnection_ServerPortName
            // 
            this.lbl_SetConnection_ServerPortName.AutoSize = true;
            this.lbl_SetConnection_ServerPortName.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SetConnection_ServerPortName.Location = new System.Drawing.Point(39, 138);
            this.lbl_SetConnection_ServerPortName.Name = "lbl_SetConnection_ServerPortName";
            this.lbl_SetConnection_ServerPortName.Size = new System.Drawing.Size(156, 23);
            this.lbl_SetConnection_ServerPortName.TabIndex = 5;
            this.lbl_SetConnection_ServerPortName.Text = "服务器名称（S）：";
            // 
            // lbl_SetConnection_UserPassword
            // 
            this.lbl_SetConnection_UserPassword.AutoSize = true;
            this.lbl_SetConnection_UserPassword.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SetConnection_UserPassword.Location = new System.Drawing.Point(90, 241);
            this.lbl_SetConnection_UserPassword.Name = "lbl_SetConnection_UserPassword";
            this.lbl_SetConnection_UserPassword.Size = new System.Drawing.Size(105, 23);
            this.lbl_SetConnection_UserPassword.TabIndex = 6;
            this.lbl_SetConnection_UserPassword.Text = "密码（P）：";
            // 
            // chk_SetConnection_RemberPssword
            // 
            this.chk_SetConnection_RemberPssword.AutoSize = true;
            this.chk_SetConnection_RemberPssword.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chk_SetConnection_RemberPssword.Location = new System.Drawing.Point(251, 278);
            this.chk_SetConnection_RemberPssword.Name = "chk_SetConnection_RemberPssword";
            this.chk_SetConnection_RemberPssword.Size = new System.Drawing.Size(91, 24);
            this.chk_SetConnection_RemberPssword.TabIndex = 7;
            this.chk_SetConnection_RemberPssword.Text = "记住密码";
            this.chk_SetConnection_RemberPssword.UseVisualStyleBackColor = true;
            // 
            // pic_SetConnection_BelowSplitLine
            // 
            this.pic_SetConnection_BelowSplitLine.BackgroundImage = global::DBO.WinForm.Properties.Resources.image_SetConnection_BelowSplitLine;
            this.pic_SetConnection_BelowSplitLine.Image = global::DBO.WinForm.Properties.Resources.image_SetConnection_BelowSplitLine;
            this.pic_SetConnection_BelowSplitLine.Location = new System.Drawing.Point(22, 308);
            this.pic_SetConnection_BelowSplitLine.Name = "pic_SetConnection_BelowSplitLine";
            this.pic_SetConnection_BelowSplitLine.Size = new System.Drawing.Size(693, 10);
            this.pic_SetConnection_BelowSplitLine.TabIndex = 8;
            this.pic_SetConnection_BelowSplitLine.TabStop = false;
            // 
            // pic_SetConnection_CenterSpliterLine
            // 
            this.pic_SetConnection_CenterSpliterLine.BackgroundImage = global::DBO.WinForm.Properties.Resources.image_SetConnection_CenterSplitLine;
            this.pic_SetConnection_CenterSpliterLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_SetConnection_CenterSpliterLine.Location = new System.Drawing.Point(3, 84);
            this.pic_SetConnection_CenterSpliterLine.Name = "pic_SetConnection_CenterSpliterLine";
            this.pic_SetConnection_CenterSpliterLine.Size = new System.Drawing.Size(723, 3);
            this.pic_SetConnection_CenterSpliterLine.TabIndex = 1;
            this.pic_SetConnection_CenterSpliterLine.TabStop = false;
            // 
            // cmb_SetConnection_ServerType
            // 
            this.cmb_SetConnection_ServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SetConnection_ServerType.FormattingEnabled = true;
            this.cmb_SetConnection_ServerType.Location = new System.Drawing.Point(227, 104);
            this.cmb_SetConnection_ServerType.Name = "cmb_SetConnection_ServerType";
            this.cmb_SetConnection_ServerType.Size = new System.Drawing.Size(394, 23);
            this.cmb_SetConnection_ServerType.TabIndex = 9;
            // 
            // cmb_SetConnection_Authentication
            // 
            this.cmb_SetConnection_Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SetConnection_Authentication.FormattingEnabled = true;
            this.cmb_SetConnection_Authentication.Location = new System.Drawing.Point(227, 177);
            this.cmb_SetConnection_Authentication.Name = "cmb_SetConnection_Authentication";
            this.cmb_SetConnection_Authentication.Size = new System.Drawing.Size(394, 23);
            this.cmb_SetConnection_Authentication.TabIndex = 10;
            // 
            // cmb_SetConnection_UserAccount
            // 
            this.cmb_SetConnection_UserAccount.FormattingEnabled = true;
            this.cmb_SetConnection_UserAccount.Location = new System.Drawing.Point(251, 210);
            this.cmb_SetConnection_UserAccount.Name = "cmb_SetConnection_UserAccount";
            this.cmb_SetConnection_UserAccount.Size = new System.Drawing.Size(370, 23);
            this.cmb_SetConnection_UserAccount.TabIndex = 11;
            // 
            // cmb_SetConnection_ServerPortName
            // 
            this.cmb_SetConnection_ServerPortName.FormattingEnabled = true;
            this.cmb_SetConnection_ServerPortName.Location = new System.Drawing.Point(227, 142);
            this.cmb_SetConnection_ServerPortName.Name = "cmb_SetConnection_ServerPortName";
            this.cmb_SetConnection_ServerPortName.Size = new System.Drawing.Size(394, 23);
            this.cmb_SetConnection_ServerPortName.TabIndex = 12;
            // 
            // tb_SetConnection_UserPad
            // 
            this.tb_SetConnection_UserPad.Location = new System.Drawing.Point(251, 241);
            this.tb_SetConnection_UserPad.Name = "tb_SetConnection_UserPad";
            this.tb_SetConnection_UserPad.Size = new System.Drawing.Size(370, 25);
            this.tb_SetConnection_UserPad.TabIndex = 13;
            // 
            // btn_SetConnection_ConnectionToServer
            // 
            this.btn_SetConnection_ConnectionToServer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetConnection_ConnectionToServer.Location = new System.Drawing.Point(177, 324);
            this.btn_SetConnection_ConnectionToServer.Name = "btn_SetConnection_ConnectionToServer";
            this.btn_SetConnection_ConnectionToServer.Size = new System.Drawing.Size(90, 32);
            this.btn_SetConnection_ConnectionToServer.TabIndex = 14;
            this.btn_SetConnection_ConnectionToServer.Text = "连接（C）";
            this.btn_SetConnection_ConnectionToServer.UseVisualStyleBackColor = true;
            this.btn_SetConnection_ConnectionToServer.Click += new System.EventHandler(this.btn_SetConnection_ConnectionToServer_Click);
            // 
            // btn_SetConnection_CancleToServer
            // 
            this.btn_SetConnection_CancleToServer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetConnection_CancleToServer.Location = new System.Drawing.Point(293, 324);
            this.btn_SetConnection_CancleToServer.Name = "btn_SetConnection_CancleToServer";
            this.btn_SetConnection_CancleToServer.Size = new System.Drawing.Size(90, 32);
            this.btn_SetConnection_CancleToServer.TabIndex = 15;
            this.btn_SetConnection_CancleToServer.Text = "取消";
            this.btn_SetConnection_CancleToServer.UseVisualStyleBackColor = true;
            this.btn_SetConnection_CancleToServer.Click += new System.EventHandler(this.btn_SetConnection_CancleToServer_Click);
            // 
            // SetConnectionServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 377);
            this.Controls.Add(this.pnl_SetConnectionServer_Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetConnectionServerForm";
            this.Text = "连接到服务器...";
            this.pnl_SetConnectionServer_Head.ResumeLayout(false);
            this.pnl_SetConnectionServer_Head.PerformLayout();
            this.pnl_SetConnectionServer_Background.ResumeLayout(false);
            this.pnl_SetConnectionServer_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SetConnection_BelowSplitLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SetConnection_CenterSpliterLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SetConnectionServer_Head;
        private System.Windows.Forms.Label lbl_SetConnectionServer_HeadTitle;
        private System.Windows.Forms.Panel pnl_SetConnectionServer_Background;
        private System.Windows.Forms.PictureBox pic_SetConnection_CenterSpliterLine;
        private System.Windows.Forms.PictureBox pic_SetConnection_BelowSplitLine;
        private System.Windows.Forms.CheckBox chk_SetConnection_RemberPssword;
        private System.Windows.Forms.Label lbl_SetConnection_UserPassword;
        private System.Windows.Forms.Label lbl_SetConnection_ServerPortName;
        private System.Windows.Forms.Label lbl_SetConnection_Authentication;
        private System.Windows.Forms.Label lbl_SetConnection_UserAccount;
        private System.Windows.Forms.Label lbl_SetConnection_ServerType;
        private System.Windows.Forms.Button btn_SetConnection_ConnectionToServer;
        private System.Windows.Forms.TextBox tb_SetConnection_UserPad;
        private System.Windows.Forms.ComboBox cmb_SetConnection_ServerPortName;
        private System.Windows.Forms.ComboBox cmb_SetConnection_UserAccount;
        private System.Windows.Forms.ComboBox cmb_SetConnection_Authentication;
        private System.Windows.Forms.ComboBox cmb_SetConnection_ServerType;
        private System.Windows.Forms.Button btn_SetConnection_CancleToServer;
    }
}