using System;
using System.Collections.Generic;
using System.Text;

namespace DBO.Core.SqlServer.Model
{
    public class Connection
    {
        /// <summary>
        /// 数据库源（数据库IP地址）
        /// </summary>
        public int DBSource { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        public string Examples { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DBName  { get; set; }

        /// <summary>
        /// 身份验证方式
        /// </summary>
        public int Authentication { get; set; }

    }
}
