using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class RateInfos
    {
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
        public long? SourceCurrencyId { get; set; }
        public decimal SourceValue { get; set; }
        public long? TargetCurrencyId { get; set; }
        public decimal TargetValue { get; set; }

        public virtual CurrencyInfos SourceCurrency { get; set; }
        public virtual CurrencyInfos TargetCurrency { get; set; }
    }
}
