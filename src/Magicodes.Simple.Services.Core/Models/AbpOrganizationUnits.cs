using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AbpOrganizationUnits
    {
        public AbpOrganizationUnits()
        {
            InverseParent = new HashSet<AbpOrganizationUnits>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string DisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public long? ParentId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpOrganizationUnits Parent { get; set; }
        public virtual ICollection<AbpOrganizationUnits> InverseParent { get; set; }
    }
}
