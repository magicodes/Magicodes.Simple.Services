using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpPersistedGrants
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Data { get; set; }
        public DateTime? Expiration { get; set; }
        public string SubjectId { get; set; }
        public string Type { get; set; }
    }
}
