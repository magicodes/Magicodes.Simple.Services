using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ServiceProductPrices
    {
        public ServiceProductPrices()
        {
            ServiceProductPriceFormulas = new HashSet<ServiceProductPriceFormulas>();
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
        public long? FromCountryInfoId { get; set; }
        public long? FromCountryId { get; set; }
        public long? ToCountryInfoId { get; set; }
        public long? ToCountryId { get; set; }
        public long? FromProvinceId { get; set; }
        public long? ToProvinceId { get; set; }
        public short PriceKind { get; set; }
        public long? WarehouseInfoId { get; set; }
        public long? ServiceProductInfoId { get; set; }
        public long? SmallProductCategoryInfoId { get; set; }
        public long? BigProductCategoryInfoId { get; set; }
        public short WeightModel { get; set; }
        public decimal WeightModelValue { get; set; }
        public decimal InsuranceRate { get; set; }
        public decimal MinFee { get; set; }
        public decimal ServiceFee { get; set; }
        public long? WeightUnitInfoId { get; set; }
        public long? MeasurementUnitInfoId { get; set; }
        public long? CurrencyInfoId { get; set; }
        public decimal FeeExchangeRate { get; set; }
        public decimal MaxValue { get; set; }
        public long? UserLevelInfoId { get; set; }

        public virtual ProductCategoryInfos BigProductCategoryInfo { get; set; }
        public virtual CurrencyInfos CurrencyInfo { get; set; }
        public virtual DistrictInfos FromCountry { get; set; }
        public virtual DistrictInfos FromProvince { get; set; }
        public virtual MeasurementUnitInfos MeasurementUnitInfo { get; set; }
        public virtual ServiceProductInfos ServiceProductInfo { get; set; }
        public virtual ProductCategoryInfos SmallProductCategoryInfo { get; set; }
        public virtual DistrictInfos ToCountry { get; set; }
        public virtual DistrictInfos ToProvince { get; set; }
        public virtual UserTypeInfos UserLevelInfo { get; set; }
        public virtual WarehouseInfos WarehouseInfo { get; set; }
        public virtual WeightUnitInfos WeightUnitInfo { get; set; }
        public virtual ICollection<ServiceProductPriceFormulas> ServiceProductPriceFormulas { get; set; }
    }
}
