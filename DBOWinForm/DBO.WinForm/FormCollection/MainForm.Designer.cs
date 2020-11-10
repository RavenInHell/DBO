namespace DBO.WinForm.FormCollection
{
    partial class Form_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainForm));
            this.pnl_Main_Header = new System.Windows.Forms.Panel();
            this.lbl_Main_Header = new System.Windows.Forms.Label();
            this.pnl_MainForm_Background = new System.Windows.Forms.Panel();
            this.pnl_MainForm_LeftColumn = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_MainForm_AnalysisConnection = new System.Windows.Forms.ToolStripButton();
            this.tsb_MainForm_ConnectionToDB = new System.Windows.Forms.ToolStripButton();
            this.tsb_MainForm_DisconectDB = new System.Windows.Forms.ToolStripButton();
            this.pic_MainForm_BackGround = new System.Windows.Forms.PictureBox();
            this.pnl_Main_Header.SuspendLayout();
            this.pnl_MainForm_Background.SuspendLayout();
            this.pnl_MainForm_LeftColumn.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MainForm_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main_Header
            // 
            this.pnl_Main_Header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Main_Header.Controls.Add(this.lbl_Main_Header);
            this.pnl_Main_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Main_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main_Header.Name = "pnl_Main_Header";
            this.pnl_Main_Header.Padding = new System.Windows.Forms.Padding(5, 0, 0, 10);
            this.pnl_Main_Header.Size = new System.Drawing.Size(1405, 81);
            this.pnl_Main_Header.TabIndex = 0;
            // 
            // lbl_Main_Header
            // 
            this.lbl_Main_Header.AutoSize = true;
            this.lbl_Main_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Main_Header.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Main_Header.Location = new System.Drawing.Point(40, 20);
            this.lbl_Main_Header.Name = "lbl_Main_Header";
            this.lbl_Main_Header.Size = new System.Drawing.Size(167, 39);
            this.lbl_Main_Header.TabIndex = 0;
            this.lbl_Main_Header.Text = "数据库操作";
            // 
            // pnl_MainForm_Background
            // 
            this.pnl_MainForm_Background.Controls.Add(this.pnl_MainForm_LeftColumn);
            this.pnl_MainForm_Background.Controls.Add(this.pic_MainForm_BackGround);
            this.pnl_MainForm_Background.Controls.Add(this.pnl_Main_Header);
            this.pnl_MainForm_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainForm_Background.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainForm_Background.Name = "pnl_MainForm_Background";
            this.pnl_MainForm_Background.Size = new System.Drawing.Size(1405, 686);
            this.pnl_MainForm_Background.TabIndex = 3;
            // 
            // pnl_MainForm_LeftColumn
            // 
            this.pnl_MainForm_LeftColumn.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_MainForm_LeftColumn.Controls.Add(this.toolStrip1);
            this.pnl_MainForm_LeftColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MainForm_LeftColumn.Location = new System.Drawing.Point(0, 81);
            this.pnl_MainForm_LeftColumn.Name = "pnl_MainForm_LeftColumn";
            this.pnl_MainForm_LeftColumn.Size = new System.Drawing.Size(229, 605);
            this.pnl_MainForm_LeftColumn.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_MainForm_AnalysisConnection,
            this.tsb_MainForm_ConnectionToDB,
            this.tsb_MainForm_DisconectDB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(229, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "tsp_MainForm_OperationConnectionDBMenu";
            // 
            // tsb_MainForm_AnalysisConnection
            // 
            this.tsb_MainForm_AnalysisConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_MainForm_AnalysisConnection.Image = global::DBO.WinForm.Properties.Resources.image_MainForm_AllConnection_Btn;
            this.tsb_MainForm_AnalysisConnection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_MainForm_AnalysisConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_MainForm_AnalysisConnection.Name = "tsb_MainForm_AnalysisConnection";
            this.tsb_MainForm_AnalysisConnection.Size = new System.Drawing.Size(53, 32);
            this.tsb_MainForm_AnalysisConnection.Text = "连接类型";
            // 
            // tsb_MainForm_ConnectionToDB
            // 
            this.tsb_MainForm_ConnectionToDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_MainForm_ConnectionToDB.Image = ((System.Drawing.Image)(resources.GetObject("tsb_MainForm_ConnectionToDB.Image")));
            this.tsb_MainForm_ConnectionToDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_MainForm_ConnectionToDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_MainForm_ConnectionToDB.Name = "tsb_MainForm_ConnectionToDB";
            this.tsb_MainForm_ConnectionToDB.Size = new System.Drawing.Size(29, 32);
            this.tsb_MainForm_ConnectionToDB.Text = "连接";
            this.tsb_MainForm_ConnectionToDB.Click += new System.EventHandler(this.tsb_MainForm_ConnectionToDB_Click);
            // 
            // tsb_MainForm_DisconectDB
            // 
            this.tsb_MainForm_DisconectDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_MainForm_DisconectDB.Image = global::DBO.WinForm.Properties.Resources.image_MainForm_CloseConnection_Btn1;
            this.tsb_MainForm_DisconectDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_MainForm_DisconectDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_MainForm_DisconectDB.Name = "tsb_MainForm_DisconectDB";
            this.tsb_MainForm_DisconectDB.Size = new System.Drawing.Size(29, 32);
            this.tsb_MainForm_DisconectDB.Text = "关闭现有连接";
            // 
            // pic_MainForm_BackGround
            // 
            this.pic_MainForm_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_MainForm_BackGround.Image = global::DBO.WinForm.Properties.Resources.image_BackGround;
            this.pic_MainForm_BackGround.Location = new System.Drawing.Point(0, 81);
            this.pic_MainForm_BackGround.Name = "pic_MainForm_BackGround";
            this.pic_MainForm_BackGround.Size = new System.Drawing.Size(1405, 605);
            this.pic_MainForm_BackGround.TabIndex = 0;
            this.pic_MainForm_BackGround.TabStop = false;
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1405, 686);
            this.Controls.Add(this.pnl_MainForm_Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MainForm";
            this.Text = "数据库操作";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Main_Header.ResumeLayout(false);
            this.pnl_Main_Header.PerformLayout();
            this.pnl_MainForm_Background.ResumeLayout(false);
            this.pnl_MainForm_LeftColumn.ResumeLayout(false);
            this.pnl_MainForm_LeftColumn.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MainForm_BackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel pnl_Main_Header;
        private System.Windows.Forms.Label lbl_Main_Header;
        private System.Windows.Forms.Panel pnl_MainForm_LeftColumn;
        private System.Windows.Forms.PictureBox pic_MainForm_BackGround;
        private System.Windows.Forms.Panel pnl_MainForm_Background;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_MainForm_OpenConnection;
        private System.Windows.Forms.ToolStripButton tsb_MainForm_AnalysisConnection;
        private System.Windows.Forms.ToolStripButton tsb_MainForm_ConnectionToDB;
        private System.Windows.Forms.ToolStripButton tsb_MainForm_DisconectDB;
    }
}