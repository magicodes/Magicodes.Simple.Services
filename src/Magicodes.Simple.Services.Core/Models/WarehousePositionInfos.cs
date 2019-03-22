using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class WarehousePositionInfos
    {
        public WarehousePositionInfos()
        {
            StorePackInfos = new HashSet<StorePackInfos>();
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
        public long WarehouseAreaInfoId { get; set; }

        public virtual WarehouseAreaInfos WarehouseAreaInfo { get; set; }
        public virtual ICollection<StorePackInfos> StorePackInfos { get; set; }
    }
}
