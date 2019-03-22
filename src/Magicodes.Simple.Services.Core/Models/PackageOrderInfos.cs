using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class PackageOrderInfos
    {
        public PackageOrderInfos()
        {
            OrderGoodsInfos = new HashSet<OrderGoodsInfos>();
            OrderServicesInfo = new HashSet<OrderServicesInfo>();
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
        public string OrderCode { get; set; }
        public string StoreCode { get; set; }
        public string Code { get; set; }
        public string ForecastCode { get; set; }
        public string ArriveDestinationCode { get; set; }
        public long? ArriveDestinationCompanyInfoId { get; set; }
        public long? ReceiverInfoId { get; set; }
        public int PaymentMethod { get; set; }
        public decimal DeclaredTotalFee { get; set; }
        public decimal EstimateTaxFee { get; set; }
        public decimal InsuredValue { get; set; }
        public decimal PremiumAmount { get; set; }
        public long? ServiceProductInfoId { get; set; }
        public long? WarehouseInfoId { get; set; }
        public long? CleaningPortInfoId { get; set; }
        public decimal FreightFee { get; set; }
        public decimal TaxFee { get; set; }
        public decimal AdditionalServicesFee { get; set; }
        public string TotalFeeRemark { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal FeeByCash { get; set; }
        public decimal TaxFeeByCash { get; set; }
        public decimal FeeByCoupon { get; set; }
        public DateTime PayTime { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime CleaningTime { get; set; }
        public DateTime GoodsReceiptTime { get; set; }
        public string ReceiptTime { get; set; }
        public long? PackageInfoId { get; set; }
        public bool IsPrint { get; set; }
        public string Eccode { get; set; }
        public string CustomerRemark { get; set; }
        public string CancelRemark { get; set; }
        public string SeparateFitId { get; set; }
        public string CustomerServiceRemark { get; set; }
        public int Source { get; set; }
        public short SpecialStatus { get; set; }
        public short Status { get; set; }
        public short StoreStatus { get; set; }

        public virtual ExpressCompanyInfos ArriveDestinationCompanyInfo { get; set; }
        public virtual CleaningPortInfos CleaningPortInfo { get; set; }
        public virtual OrderPackageInfos PackageInfo { get; set; }
        public virtual ReceiverInfos ReceiverInfo { get; set; }
        public virtual ServiceProductInfos ServiceProductInfo { get; set; }
        public virtual WarehouseInfos WarehouseInfo { get; set; }
        public virtual ICollection<OrderGoodsInfos> OrderGoodsInfos { get; set; }
        public virtual ICollection<OrderServicesInfo> OrderServicesInfo { get; set; }
    }
}
