using System;
using System.Collections.Generic;
using System.Text;
using YTcms.Common;

namespace YTcms.DAL
{
    /// <summary>
    /// 数据访问类:系统配置
    /// </summary>
    public partial class sysconfig
    {
        private static object lockHelper = new object();

        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        public Dapper.Model.sysconfig loadConfig(string configFilePath)
        {
            return (Dapper.Model.sysconfig)SerializationHelper.Load(typeof(Dapper.Model.sysconfig), configFilePath);
        }

        /// <summary>
        /// 写入站点配置文件
        /// </summary>
        public Dapper.Model.sysconfig saveConifg(Dapper.Model.sysconfig model, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, configFilePath);
            }
            return model;
        }

    }
}
