using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AbpUserLoginAttempts
    {
        public long Id { get; set; }
        public string BrowserInfo { get; set; }
        public string ClientIpAddress { get; set; }
        public string ClientName { get; set; }
        public DateTime CreationTime { get; set; }
        public byte Result { get; set; }
        public string TenancyName { get; set; }
        public int? TenantId { get; set; }
        public long? UserId { get; set; }
        public string UserNameOrEmailAddress { get; set; }
    }
}
