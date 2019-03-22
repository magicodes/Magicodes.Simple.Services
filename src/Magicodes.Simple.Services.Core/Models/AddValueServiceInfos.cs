using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AddValueServiceInfos
    {
        public AddValueServiceInfos()
        {
            OrderServicesInfo = new HashSet<OrderServicesInfo>();
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
        public string Snumber { get; set; }
        public short Type { get; set; }
        public long? CurrencyInfoId1 { get; set; }
        public int CurrencyInfoId { get; set; }
        public short Unit { get; set; }
        public decimal Price { get; set; }
        public string Tips { get; set; }

        public virtual CurrencyInfos CurrencyInfoId1Navigation { get; set; }
        public virtual ICollection<OrderServicesInfo> OrderServicesInfo { get; set; }
    }
}
