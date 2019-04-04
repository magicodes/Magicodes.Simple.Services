using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AppSubscriptionPayments
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int DayCount { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int EditionId { get; set; }
        public int Gateway { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string PaymentId { get; set; }
        public int? PaymentPeriodType { get; set; }
        public int Status { get; set; }
        public int TenantId { get; set; }
        public string InvoiceNo { get; set; }

        public virtual AbpEditions Edition { get; set; }
    }
}
