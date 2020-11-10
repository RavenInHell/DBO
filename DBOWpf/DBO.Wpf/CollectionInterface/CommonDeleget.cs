using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DBO.Wpf.CollectionInterface
{
    public  class CommonDeleget
    {
        private static bool _isOpen;

        public static bool IsOpen
        {
            get { return _isOpen; }
            set
            {
                if (_isOpen != null)
                {
                    value = _isOpen;
                }

            }
        }

        public delegate void Limit(Window receiveWindow);
        public void LimitWindow(Window receiveWindow)
        {
            foreach (Window item in Application.Current.Windows)
            {
                ////判断是否是要找的窗体
                //if (item is receiveWindow)
                //{
                //    setConnectionWindow.Close();
                //    //找到所需窗体，结束循环窗体
                //    break;
                //}
            }
        }
    }
}
