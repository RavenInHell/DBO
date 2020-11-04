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
        /// <summary>
        /// 打开数据库连接界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_popup_SetConnection_Click(object sender, RoutedEventArgs e)
        {
            SetConnectionWindow setConnectionWindow = new SetConnectionWindow 
            {
                //设置新开窗体的居中位置
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this,
                //控制窗体右上角的缩小放大的功能
                ResizeMode = ResizeMode.NoResize,

            };
            setConnectionWindow.Show();
        }
    }
}
