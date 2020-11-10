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
    /// SetConnectionWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SetConnectionWindow : Window
    {
        public delegate int LimitOperation(SetConnectionWindow setConnectionWindow);//定义委托

        

        public SetConnectionWindow()
        {
            InitializeComponent();
            
        }

        public void Limit(SetConnectionWindow setConnectionWindow)
        {
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

        /// <summary>
        /// 连接数据库操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_connectDB_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 取消连接数据库的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_cancel_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
