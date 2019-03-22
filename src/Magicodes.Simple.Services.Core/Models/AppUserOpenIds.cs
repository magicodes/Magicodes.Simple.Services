using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AppUserOpenIds
    {
        public long Id { get; set; }
        public string OpenId { get; set; }
        public int? TenantId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public DateTime CreationTime { get; set; }
        public long UserId { get; set; }
        public int From { get; set; }
        public string UnionId { get; set; }

        public virtual AbpUsers User { get; set; }
    }
}
