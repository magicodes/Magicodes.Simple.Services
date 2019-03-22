using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class OrderServicesInfo
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
        public long AddValueServicesId { get; set; }
        public long? AddValueServiceInfoId { get; set; }
        public string Name { get; set; }
        public string Snumber { get; set; }
        public short Type { get; set; }
        public long? CurrencyInfoId1 { get; set; }
        public int CurrencyInfoId { get; set; }
        public short Unit { get; set; }
        public decimal Price { get; set; }
        public string Tips { get; set; }

        public virtual AddValueServiceInfos AddValueServiceInfo { get; set; }
        public virtual CurrencyInfos CurrencyInfoId1Navigation { get; set; }
        public virtual PackageOrderInfos PackageOrderInfo { get; set; }
    }
}
