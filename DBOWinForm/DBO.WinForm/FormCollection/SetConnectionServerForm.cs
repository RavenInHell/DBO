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
    public partial class SetConnectionServerForm : Form
    {
        public SetConnectionServerForm()
        {
            InitializeComponent();
        }

        private void btn_SetConnection_CancleToServer_Click(object sender, EventArgs e)
        {
            //关闭服务器连接的窗体，取消操作
            if (Application.OpenForms["SetConnectionServerForm"] !=null)
            {
                Application.OpenForms["SetConnectionServerForm"].Close();
            }
            
        }
    }
}
