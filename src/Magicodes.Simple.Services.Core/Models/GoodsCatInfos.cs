using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class GoodsCatInfos
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
        public long ParentId { get; set; }
        public bool IsParent { get; set; }
        public string Name { get; set; }
        public int States { get; set; }
    }
}
