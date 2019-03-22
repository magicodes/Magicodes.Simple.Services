using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ProductCategoryInfos
    {
        public ProductCategoryInfos()
        {
            OrderGoodsInfosBigProductCategoryInfo = new HashSet<OrderGoodsInfos>();
            OrderGoodsInfosSmallProductCategoryInfo = new HashSet<OrderGoodsInfos>();
            ServiceProductPricesBigProductCategoryInfo = new HashSet<ServiceProductPrices>();
            ServiceProductPricesSmallProductCategoryInfo = new HashSet<ServiceProductPrices>();
            TaxNoInfos = new HashSet<TaxNoInfos>();
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
        public long? ParentId { get; set; }
        public string FullName { get; set; }
        public long? CountryInfoId { get; set; }
        public bool IsAllowTransport { get; set; }
        public bool IsNeedInsure { get; set; }
        public bool IsNeedReinforce { get; set; }
        public bool IsNeedSeparateTransport { get; set; }
        public bool IsNeedSuttle { get; set; }
        public bool IsHighFigure { get; set; }

        public virtual DistrictInfos CountryInfo { get; set; }
        public virtual ICollection<OrderGoodsInfos> OrderGoodsInfosBigProductCategoryInfo { get; set; }
        public virtual ICollection<OrderGoodsInfos> OrderGoodsInfosSmallProductCategoryInfo { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPricesBigProductCategoryInfo { get; set; }
        public virtual ICollection<ServiceProductPrices> ServiceProductPricesSmallProductCategoryInfo { get; set; }
        public virtual ICollection<TaxNoInfos> TaxNoInfos { get; set; }
    }
}
