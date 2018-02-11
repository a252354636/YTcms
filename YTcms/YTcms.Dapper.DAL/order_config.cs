using System;
using System.Collections.Generic;
using System.Text;
using YTcms.Common;

namespace YTcms.DAL
{
    public partial class orderconfig
    {
        private static object lockHelper = new object();

        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        public Dapper.Model.orderconfig loadConfig(string configFilePath)
        {
            return (Dapper.Model.orderconfig)SerializationHelper.Load(typeof(Dapper.Model.orderconfig), configFilePath);
        }

        /// <summary>
        /// 写入站点配置文件
        /// </summary>
        public Dapper.Model.orderconfig saveConifg(Dapper.Model.orderconfig model, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, configFilePath);
            }
            return model;
        }

    }
}
