using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ArticleInfos
    {
        public ArticleInfos()
        {
            ArticleTagInfos = new HashSet<ArticleTagInfos>();
        }

        public long Id { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? TenantId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public bool IsNeedAuthorizeAccess { get; set; }
        public long ColumnInfoId { get; set; }
        public long? ArticleSourceInfoId { get; set; }
        public DateTime? ReleaseTime { get; set; }
        public string SeoTitle { get; set; }
        public string KeyWords { get; set; }
        public string Introduction { get; set; }
        public string StaticPageUrl { get; set; }
        public string Url { get; set; }
        public int RecommendedType { get; set; }
        public long ViewCount { get; set; }
        public string Code { get; set; }
        public bool IsStatic { get; set; }

        public virtual ArticleSourceInfos ArticleSourceInfo { get; set; }
        public virtual ColumnInfos ColumnInfo { get; set; }
        public virtual ICollection<ArticleTagInfos> ArticleTagInfos { get; set; }
    }
}
