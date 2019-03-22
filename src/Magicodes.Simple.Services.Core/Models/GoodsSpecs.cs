using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class GoodsSpecs
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
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal? OriginalPrice { get; set; }
        public int AvailableStock { get; set; }
        public int LockStock { get; set; }
        public int SalesStock { get; set; }
        public int ActualStock { get; set; }
        public string Description { get; set; }
        public long? GoodsInfoId { get; set; }
        public string ImageUrls { get; set; }
        public bool IsActive { get; set; }

        public virtual GoodsInfos GoodsInfo { get; set; }
    }
}
