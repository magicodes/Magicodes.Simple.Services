using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpLanguages
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string DisplayName { get; set; }
        public string Icon { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string Name { get; set; }
        public int? TenantId { get; set; }
        public bool IsDisabled { get; set; }
    }
}
