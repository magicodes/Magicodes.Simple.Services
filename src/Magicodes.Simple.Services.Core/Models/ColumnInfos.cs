using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ColumnInfos
    {
        public ColumnInfos()
        {
            ArticleInfos = new HashSet<ArticleInfos>();
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
        public string Description { get; set; }
        public long? SortNo { get; set; }
        public bool IsActive { get; set; }
        public string Introduction { get; set; }
        public long ParentId { get; set; }
        public bool IsNeedAuthorizeAccess { get; set; }
        public string IconCls { get; set; }
        public string Url { get; set; }
        public string Alias { get; set; }
        public string KeyWords { get; set; }
        public string SeoTitle { get; set; }
        public string Code { get; set; }
        public int? MaxItemCount { get; set; }
        public bool IsStatic { get; set; }
        public int ColumnType { get; set; }
        public int Position { get; set; }
        public bool IsHeaderNav { get; set; }
        public string StaticPageUrl { get; set; }
        public bool IsFooterNav { get; set; }

        public virtual ICollection<ArticleInfos> ArticleInfos { get; set; }
    }
}
