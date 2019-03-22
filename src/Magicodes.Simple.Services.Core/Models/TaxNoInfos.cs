using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class TaxNoInfos
    {
        public TaxNoInfos()
        {
            TaxFormulaInfos = new HashSet<TaxFormulaInfos>();
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
        public string ShortName { get; set; }
        public string Code { get; set; }
        public long? SortNo { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public bool IsShowInClient { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Name { get; set; }
        public decimal? TaxRate { get; set; }
        public string RecordNo { get; set; }
        public long? ProductCategoryInfoId { get; set; }

        public virtual ProductCategoryInfos ProductCategoryInfo { get; set; }
        public virtual ICollection<TaxFormulaInfos> TaxFormulaInfos { get; set; }
    }
}
