using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        /// <summary>
        /// 取消服务器的连接及取消的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetConnection_CancleToServer_Click(object sender, EventArgs e)
        {
            //关闭服务器连接的窗体，取消操作
            if (Application.OpenForms["SetConnectionServerForm"] !=null)
            {
                Application.OpenForms["SetConnectionServerForm"].Close();
            }
            
        }

        /// <summary>
        /// 连接到服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetConnection_ConnectionToServer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=GalaxyServicesDB;Integrated Security=True");//建立数据库连接对象
            con.Open();//打开连接
            SqlCommand cmd = new SqlCommand("select * from [dbo].[UserInformation]", con);//建立command对象，代表可以对数据库操作了
            //SqlParameter para = new SqlParameter("@voteSum", SqlDbType.Text);
            //para.Value = 000;
            //cmd.Parameters.Add(para);//添加参数


            SqlDataAdapter sda = new SqlDataAdapter();//声明适配器对象
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds, "UserInformation");
            DataTable dt = ds.Tables["UserInformation"];
            DataRow dr = dt.Rows[0];//取出查询结果中的第一行
            MessageBox.Show(dr["voteTitle"].ToString());
             
        }
    }
}
