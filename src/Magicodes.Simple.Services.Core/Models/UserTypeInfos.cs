using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class UserTypeInfos
    {
        public UserTypeInfos()
        {
            ServiceProductPrices = new HashSet<ServiceProductPrices>();
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
        public bool IsAutoUpgrade { get; set; }
        public decimal UpgradeAmountFrom { get; set; }
        public decimal UpgradeAmountTo { get; set; }
        public int UpgradeAmountType { get; set; }
        public decimal RebateRate { get; set; }
        public decimal MaxRebate { get; set; }

        public virtual ICollection<ServiceProductPrices> ServiceProductPrices { get; set; }
    }
}
