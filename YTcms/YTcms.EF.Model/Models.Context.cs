﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dt_article_albums> dt_article_albums { get; set; }
        public virtual DbSet<dt_article_attach> dt_article_attach { get; set; }
        public virtual DbSet<dt_article_attribute_field> dt_article_attribute_field { get; set; }
        public virtual DbSet<dt_article_category> dt_article_category { get; set; }
        public virtual DbSet<dt_article_comment> dt_article_comment { get; set; }
        public virtual DbSet<dt_article_tags> dt_article_tags { get; set; }
        public virtual DbSet<dt_article_tags_relation> dt_article_tags_relation { get; set; }
        public virtual DbSet<dt_channel_article_content> dt_channel_article_content { get; set; }
        public virtual DbSet<dt_channel_article_down> dt_channel_article_down { get; set; }
        public virtual DbSet<dt_channel_article_goods> dt_channel_article_goods { get; set; }
        public virtual DbSet<dt_channel_article_news> dt_channel_article_news { get; set; }
        public virtual DbSet<dt_channel_article_photo> dt_channel_article_photo { get; set; }
        public virtual DbSet<dt_channel_article_video> dt_channel_article_video { get; set; }
        public virtual DbSet<dt_express> dt_express { get; set; }
        public virtual DbSet<dt_feedback> dt_feedback { get; set; }
        public virtual DbSet<dt_link> dt_link { get; set; }
        public virtual DbSet<dt_mail_template> dt_mail_template { get; set; }
        public virtual DbSet<dt_manager> dt_manager { get; set; }
        public virtual DbSet<dt_manager_log> dt_manager_log { get; set; }
        public virtual DbSet<dt_manager_role> dt_manager_role { get; set; }
        public virtual DbSet<dt_manager_role_value> dt_manager_role_value { get; set; }
        public virtual DbSet<dt_navigation> dt_navigation { get; set; }
        public virtual DbSet<dt_oauth_app> dt_oauth_app { get; set; }
        public virtual DbSet<dt_order_goods> dt_order_goods { get; set; }
        public virtual DbSet<dt_orders> dt_orders { get; set; }
        public virtual DbSet<dt_payment> dt_payment { get; set; }
        public virtual DbSet<dt_site_channel> dt_site_channel { get; set; }
        public virtual DbSet<dt_site_channel_field> dt_site_channel_field { get; set; }
        public virtual DbSet<dt_site_oauth> dt_site_oauth { get; set; }
        public virtual DbSet<dt_site_payment> dt_site_payment { get; set; }
        public virtual DbSet<dt_sites> dt_sites { get; set; }
        public virtual DbSet<dt_sms_template> dt_sms_template { get; set; }
        public virtual DbSet<dt_user_addr_book> dt_user_addr_book { get; set; }
        public virtual DbSet<dt_user_amount_log> dt_user_amount_log { get; set; }
        public virtual DbSet<dt_user_attach_log> dt_user_attach_log { get; set; }
        public virtual DbSet<dt_user_code> dt_user_code { get; set; }
        public virtual DbSet<dt_user_group_price> dt_user_group_price { get; set; }
        public virtual DbSet<dt_user_groups> dt_user_groups { get; set; }
        public virtual DbSet<dt_user_login_log> dt_user_login_log { get; set; }
        public virtual DbSet<dt_user_message> dt_user_message { get; set; }
        public virtual DbSet<dt_user_oauth> dt_user_oauth { get; set; }
        public virtual DbSet<dt_user_point_log> dt_user_point_log { get; set; }
        public virtual DbSet<dt_user_recharge> dt_user_recharge { get; set; }
        public virtual DbSet<dt_users> dt_users { get; set; }
    }
}
