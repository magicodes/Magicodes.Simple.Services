using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class DistrictInfos
    {
        public DistrictInfos()
        {
            CurrencyInfos = new HashSet<CurrencyInfos>();
            MeasurementUnitInfos = new HashSet<MeasurementUnitInfos>();
            ProductCategoryInfos = new HashSet<ProductCategoryInfos>();
            ServiceProductInfosFromCountry = new HashSet<ServiceProductInfos>();
            ServiceProductInfosToCountry = new HashSet<ServiceProductInfos>();
            ServiceProductPricesFromCountry = new HashSet<ServiceProductPrices>();
            ServiceProductPricesFromProvince = new HashSet<ServiceProductPrices>();
            ServiceProductPricesToCountry = new HashSet<ServiceProductPrices>();
            ServiceProductPricesToProvince = new HashSet<ServiceProductPrices>();
            WarehouseInfos = new HashSet<WarehouseInfos>();
            WeightUnitInfos = new HashSet<WeightUnitInfos>();
        }

        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? TenantId { get; set; }
        public long Id { get; set; }
        public string CityCode { get; set; }
        public string AreaCode { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CurrencyInfos> CurrencyInfos { get; set; }
        public virtual ICollection<MeasurementUnitInfos> MeasurementUnitInfos { get; set; }
        public virtual ICollection<ProductCategoryInfos> ProductCategoryInfos { get; set; }
        public virtual ICollection<ServiceProductInfos> ServiceProductInfosFromCountry { get; set; }
        public virtual ICollection<ServiceProductInfos> ServiceProductInfosToCountry { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPricesFromCountry { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPricesFromProvince { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPricesToCountry { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPricesToProvince { get; set; }
        public virtual ICollection<WarehouseInfos> WarehouseInfos { get; set; }
        public virtual ICollection<WeightUnitInfos> WeightUnitInfos { get; set; }
    }
}
