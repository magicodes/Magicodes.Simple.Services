using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpEditions
    {
        public AbpEditions()
        {
            AbpFeatures = new HashSet<AbpFeatures>();
            AbpTenants = new HashSet<AbpTenants>();
            AppSubscriptionPayments = new HashSet<AppSubscriptionPayments>();
        }

        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string DisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string Name { get; set; }
        public string Discriminator { get; set; }
        public decimal? AnnualPrice { get; set; }
        public int? ExpiringEditionId { get; set; }
        public decimal? MonthlyPrice { get; set; }
        public int? TrialDayCount { get; set; }
        public int? WaitingDayAfterExpire { get; set; }

        public virtual ICollection<AbpFeatures> AbpFeatures { get; set; }
        public virtual ICollection<AbpTenants> AbpTenants { get; set; }
        public virtual ICollection<AppSubscriptionPayments> AppSubscriptionPayments { get; set; }
    }
}
