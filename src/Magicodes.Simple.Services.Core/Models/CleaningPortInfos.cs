using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class CleaningPortInfos
    {
        public CleaningPortInfos()
        {
            OrderRules = new HashSet<OrderRules>();
            PackageOrderInfos = new HashSet<PackageOrderInfos>();
            ServiceProductInfos = new HashSet<ServiceProductInfos>();
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
        public bool IsNeedCardNo { get; set; }
        public bool IsAutoGetArriveDestinationCode { get; set; }
        public bool RepeatShr { get; set; }
        public int RepeatShrnumber { get; set; }
        public string TempleteName { get; set; }
        public long ExpressCompanyInfoId { get; set; }
        public int CleaningProtPriority { get; set; }
        public short CleaningProtKind { get; set; }

        public virtual ExpressCompanyInfos ExpressCompanyInfo { get; set; }
        public virtual ICollection<OrderRules> OrderRules { get; set; }
        public virtual ICollection<PackageOrderInfos> PackageOrderInfos { get; set; }
        public virtual ICollection<ServiceProductInfos> ServiceProductInfos { get; set; }
        public virtual ICollection<TaxFormulaInfos> TaxFormulaInfos { get; set; }
    }
}
