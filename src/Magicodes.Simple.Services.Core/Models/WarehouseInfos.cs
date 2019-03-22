using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class WarehouseInfos
    {
        public WarehouseInfos()
        {
            OrderPackageInfos = new HashSet<OrderPackageInfos>();
            OrderRules = new HashSet<OrderRules>();
            PackageOrderInfos = new HashSet<PackageOrderInfos>();
            ServiceProductInfos = new HashSet<ServiceProductInfos>();
            ServiceProductPrices = new HashSet<ServiceProductPrices>();
            StorePackInfosFristWarehouseInfo = new HashSet<StorePackInfos>();
            StorePackInfosPreviouWarehouseInfo = new HashSet<StorePackInfos>();
            StorePackInfosWarehouseInfo = new HashSet<StorePackInfos>();
            WarehouseAreaInfos = new HashSet<WarehouseAreaInfos>();
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
        public short WarehouseType { get; set; }
        public string Consignee { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public decimal TransportFee { get; set; }
        public int TransportFeeType { get; set; }
        public decimal OverdueFee { get; set; }
        public int OverdueFeeType { get; set; }
        public string Tips { get; set; }
        public long? CountryId { get; set; }

        public virtual DistrictInfos Country { get; set; }
        public virtual ICollection<OrderPackageInfos> OrderPackageInfos { get; set; }
        public virtual ICollection<OrderRules> OrderRules { get; set; }
        public virtual ICollection<PackageOrderInfos> PackageOrderInfos { get; set; }
        public virtual ICollection<ServiceProductInfos> ServiceProductInfos { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPrices { get; set; }
        public virtual ICollection<StorePackInfos> StorePackInfosFristWarehouseInfo { get; set; }
        public virtual ICollection<StorePackInfos> StorePackInfosPreviouWarehouseInfo { get; set; }
        public virtual ICollection<StorePackInfos> StorePackInfosWarehouseInfo { get; set; }
        public virtual ICollection<WarehouseAreaInfos> WarehouseAreaInfos { get; set; }
    }
}
