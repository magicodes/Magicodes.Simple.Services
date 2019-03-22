using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ServiceProductInfos
    {
        public ServiceProductInfos()
        {
            OrderRules = new HashSet<OrderRules>();
            PackageOrderInfos = new HashSet<PackageOrderInfos>();
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
        public long WarehouseInfoId { get; set; }
        public long? CleaningPortInfoId { get; set; }
        public string TransporTefficiency { get; set; }
        public long? FromCountryInfoId { get; set; }
        public long? FromCountryId { get; set; }
        public long? ToCountryInfoId { get; set; }
        public long? ToCountryId { get; set; }
        public string Tips { get; set; }

        public virtual CleaningPortInfos CleaningPortInfo { get; set; }
        public virtual DistrictInfos FromCountry { get; set; }
        public virtual DistrictInfos ToCountry { get; set; }
        public virtual WarehouseInfos WarehouseInfo { get; set; }
        public virtual ICollection<OrderRules> OrderRules { get; set; }
        public virtual ICollection<PackageOrderInfos> PackageOrderInfos { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPrices { get; set; }
    }
}
