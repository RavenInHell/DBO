using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBO.WinForm.FormCollection
{
    public partial class Form_MainForm : Form
    {
        public SetConnectionServerForm setConnectionServerForm;
        public Form_MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 连接服务器按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_MainForm_ConnectionToDB_Click(object sender, EventArgs e)
        {
            setConnectionServerForm = new SetConnectionServerForm
            {
                //设置服务器连接的窗口屏幕居中（非窗体居中）
                StartPosition = FormStartPosition.CenterScreen
            };
            setConnectionServerForm.Show();
        }
    }
}
