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
    
    public partial class dt_oauth_app
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dt_oauth_app()
        {
            this.dt_site_oauth = new HashSet<dt_site_oauth>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string img_url { get; set; }
        public string remark { get; set; }
        public Nullable<int> sort_id { get; set; }
        public Nullable<byte> is_lock { get; set; }
        public string api_path { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dt_site_oauth> dt_site_oauth { get; set; }
    }
}
