using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class ServiceProductPriceFormulas
    {
        public long Id { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? TenantId { get; set; }
        public long? SortNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long ServiceProductPriceId { get; set; }
        public int FormulaKind { get; set; }
        public string FormulaCondition { get; set; }
        public string FormulaExpression { get; set; }
        public decimal OtherFee { get; set; }

        public virtual ServiceProductPrices ServiceProductPrice { get; set; }
    }
}
