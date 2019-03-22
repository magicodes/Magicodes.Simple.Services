using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ReceiptAddressInfos
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
        public string PhoneNo { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public long? UserId { get; set; }
        public bool IsDefault { get; set; }
        public string IdNo { get; set; }
        public int SexTypes { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public long? IdPositiveImage { get; set; }
        public long? IdNegativeImage { get; set; }

        public virtual AbpUsers User { get; set; }
    }
}
