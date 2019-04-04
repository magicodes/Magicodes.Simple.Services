using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AbpUserNotifications
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public int State { get; set; }
        public int? TenantId { get; set; }
        public Guid TenantNotificationId { get; set; }
        public long UserId { get; set; }
    }
}
