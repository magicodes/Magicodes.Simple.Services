using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpFeatures
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public string Discriminator { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int? EditionId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpEditions Edition { get; set; }
    }
}
