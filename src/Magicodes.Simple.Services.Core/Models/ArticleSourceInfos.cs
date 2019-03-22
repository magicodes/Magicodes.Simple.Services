using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ArticleSourceInfos
    {
        public ArticleSourceInfos()
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
        public string Name { get; set; }

        public virtual ICollection<ArticleInfos> ArticleInfos { get; set; }
    }
}
