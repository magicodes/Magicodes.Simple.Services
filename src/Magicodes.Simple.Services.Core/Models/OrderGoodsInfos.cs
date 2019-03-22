using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class OrderGoodsInfos
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
        public long PackageOrderInfoId { get; set; }
        public string GoodsName { get; set; }
        public string GoodsBuyUrl { get; set; }
        public long? BigProductCategoryInfoId { get; set; }
        public long? SmallProductCategoryInfoId { get; set; }
        public decimal GoodsPrice { get; set; }
        public int GoodsCount { get; set; }
        public string ProductBrand { get; set; }
        public string ProductUnit { get; set; }
        public string ProductVersion { get; set; }
        public string BarCode { get; set; }
        public int TaxFee { get; set; }
        public int SuttleWeight { get; set; }
        public int GrossWeight { get; set; }

        public virtual ProductCategoryInfos BigProductCategoryInfo { get; set; }
        public virtual PackageOrderInfos PackageOrderInfo { get; set; }
        public virtual ProductCategoryInfos SmallProductCategoryInfo { get; set; }
    }
}
