using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class AbpEntityChanges
    {
        public AbpEntityChanges()
        {
            AbpEntityPropertyChanges = new HashSet<AbpEntityPropertyChanges>();
        }

        public long Id { get; set; }
        public DateTime ChangeTime { get; set; }
        public byte ChangeType { get; set; }
        public long EntityChangeSetId { get; set; }
        public string EntityId { get; set; }
        public string EntityTypeFullName { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpEntityChangeSets EntityChangeSet { get; set; }
        public virtual ICollection<AbpEntityPropertyChanges> AbpEntityPropertyChanges { get; set; }
    }
}
