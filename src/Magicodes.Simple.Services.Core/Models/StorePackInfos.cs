using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class StorePackInfos
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
        public string StoreCode { get; set; }
        public string ForecastCode { get; set; }
        public string OtherInfoId { get; set; }
        public long? UserId { get; set; }
        public string UserCode { get; set; }
        public decimal Weight { get; set; }
        public decimal OutstoreWeight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public long? WarehouseInfoId { get; set; }
        public long? WarehousePositionInfoId { get; set; }
        public long? WarehouseAreaInfoId { get; set; }
        public long? PreviouWarehouseInfoId { get; set; }
        public long? FristWarehouseInfoId { get; set; }
        public short StoreStatus { get; set; }
        public string InStockTempleteName { get; set; }
        public string PickingTempleteName { get; set; }
        public string InvoiceTempleteName { get; set; }

        public virtual WarehouseInfos FristWarehouseInfo { get; set; }
        public virtual WarehouseInfos PreviouWarehouseInfo { get; set; }
        public virtual AbpUsers User { get; set; }
        public virtual WarehouseAreaInfos WarehouseAreaInfo { get; set; }
        public virtual WarehouseInfos WarehouseInfo { get; set; }
        public virtual WarehousePositionInfos WarehousePositionInfo { get; set; }
    }
}
