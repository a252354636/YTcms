//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YTcms.EF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class dt_feedback
    {
        public int id { get; set; }
        public int site_id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string user_name { get; set; }
        public string user_tel { get; set; }
        public string user_qq { get; set; }
        public string user_email { get; set; }
        public System.DateTime add_time { get; set; }
        public string reply_content { get; set; }
        public Nullable<System.DateTime> reply_time { get; set; }
        public byte is_lock { get; set; }
    }
}
