using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ReceiverInfos
    {
        public ReceiverInfos()
        {
            PackageOrderInfos = new HashSet<PackageOrderInfos>();
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
        public string Name { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string DetailAddress { get; set; }
        public string PaintMarker { get; set; }
        public string Contact { get; set; }
        public string IdCardNo { get; set; }

        public virtual ICollection<PackageOrderInfos> PackageOrderInfos { get; set; }
    }
}
