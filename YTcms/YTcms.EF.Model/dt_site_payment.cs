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
    
    public partial class dt_site_payment
    {
        public int id { get; set; }
        public Nullable<int> site_id { get; set; }
        public Nullable<int> payment_id { get; set; }
        public string title { get; set; }
        public string key1 { get; set; }
        public string key2 { get; set; }
        public string key3 { get; set; }
        public string key4 { get; set; }
        public Nullable<int> sort_id { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
    
        public virtual dt_payment dt_payment { get; set; }
    }
}
