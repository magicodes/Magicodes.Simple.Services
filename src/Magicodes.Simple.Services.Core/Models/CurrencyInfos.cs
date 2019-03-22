using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class CurrencyInfos
    {
        public CurrencyInfos()
        {
            AddValueServiceInfos = new HashSet<AddValueServiceInfos>();
            OrderServicesInfo = new HashSet<OrderServicesInfo>();
            RateInfosSourceCurrency = new HashSet<RateInfos>();
            RateInfosTargetCurrency = new HashSet<RateInfos>();
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
        public long? CountryId { get; set; }
        public string Symbol { get; set; }

        public virtual DistrictInfos Country { get; set; }
        public virtual ICollection<AddValueServiceInfos> AddValueServiceInfos { get; set; }
        public virtual ICollection<OrderServicesInfo> OrderServicesInfo { get; set; }
        public virtual ICollection<RateInfos> RateInfosSourceCurrency { get; set; }
        public virtual ICollection<RateInfos> RateInfosTargetCurrency { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPrices { get; set; }
    }
}
