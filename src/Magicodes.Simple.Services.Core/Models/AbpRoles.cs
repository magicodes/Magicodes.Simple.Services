using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpRoles
    {
        public AbpRoles()
        {
            AbpPermissions = new HashSet<AbpPermissions>();
            AbpRoleClaims = new HashSet<AbpRoleClaims>();
        }

        public int Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string DisplayName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsStatic { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpUsers CreatorUser { get; set; }
        public virtual AbpUsers DeleterUser { get; set; }
        public virtual AbpUsers LastModifierUser { get; set; }
        public virtual ICollection<AbpPermissions> AbpPermissions { get; set; }
        public virtual ICollection<AbpRoleClaims> AbpRoleClaims { get; set; }
    }
}
