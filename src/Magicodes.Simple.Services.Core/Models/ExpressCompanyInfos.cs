using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ExpressCompanyInfos
    {
        public ExpressCompanyInfos()
        {
            CleaningPortInfos = new HashSet<CleaningPortInfos>();
            PackageOrderInfos = new HashSet<PackageOrderInfos>();
        }

        public long Id { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? TenantId { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public long? SortNo { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public bool IsShowInClient { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public short InterfaceType { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public string Parameter3 { get; set; }
        public string Parameter4 { get; set; }
        public string Parameter5 { get; set; }
        public string Parameter6 { get; set; }
        public string Parameter7 { get; set; }
        public string Parameter8 { get; set; }

        public virtual ICollection<CleaningPortInfos> CleaningPortInfos { get; set; }
        public virtual ICollection<PackageOrderInfos> PackageOrderInfos { get; set; }
    }
}
