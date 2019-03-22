using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpUserLogins
    {
        public long Id { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }

        public virtual AbpUsers User { get; set; }
    }
}
