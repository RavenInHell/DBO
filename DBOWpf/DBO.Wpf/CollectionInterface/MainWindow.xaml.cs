using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DBO.Wpf.CollectionInterface
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public SetConnectionWindow setConnectionWindow;

        /// <summary>
        /// 打开数据库连接界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_popup_OpenConnection_Click(object sender, RoutedEventArgs e)
        {
           

            if (setConnectionWindow?.WindowState==WindowState.Normal) return;

            //防止重复打开数据库连接界面
            //if (setConnectionWindow!=null) 

            setConnectionWindow = new SetConnectionWindow 
            {
                //设置新开窗体的居中位置
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this,
                //控制窗体右上角的缩小放大的功能
                ResizeMode = ResizeMode.NoResize,

            };
            setConnectionWindow.Show();
        }
        /// <summary>
        /// 断开数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_popup_CloseConnection_OnClick(object sender, RoutedEventArgs e)
        {
            //循环程序内的所有窗体
            foreach (Window item in Application.Current.Windows)
            {
                //判断是否是要找的窗体
                if (item is SetConnectionWindow)
                {
                    setConnectionWindow.Close();
                    //找到所需窗体，结束循环窗体
                    break;
                }
            }

        }


    }
}
