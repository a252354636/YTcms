﻿using System;
using System.Collections.Generic;
using System.Text;
using YTcms.Common;

namespace YTcms.DAL
{
    /// <summary>
    /// 数据访问类:会员配置
    /// </summary>
    public partial class userconfig
    {
        private static object lockHelper = new object();

        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        public Dapper.Model.userconfig loadConfig(string configFilePath)
        {
            return (Dapper.Model.userconfig)SerializationHelper.Load(typeof(Dapper.Model.userconfig), configFilePath);
        }

        /// <summary>
        /// 写入站点配置文件
        /// </summary>
        public Dapper.Model.userconfig saveConifg(Dapper.Model.userconfig model, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, configFilePath);
            }
            return model;
        }

    }
}
