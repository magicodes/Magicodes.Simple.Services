using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpRoleClaims
    {
        public long Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int RoleId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpRoles Role { get; set; }
    }
}
