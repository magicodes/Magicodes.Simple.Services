using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class GoodsInfos
    {
        public GoodsInfos()
        {
            GoodsAttributeInfos = new HashSet<GoodsAttributeInfos>();
            GoodsSpecs = new HashSet<GoodsSpecs>();
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
        public string Name { get; set; }
        public string Sellpoint { get; set; }
        public decimal Price { get; set; }
        public int Num { get; set; }
        public string Image { get; set; }
        public long Cid { get; set; }
        public int States { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<GoodsAttributeInfos> GoodsAttributeInfos { get; set; }
        public virtual ICollection<GoodsSpecs> GoodsSpecs { get; set; }
    }
}
