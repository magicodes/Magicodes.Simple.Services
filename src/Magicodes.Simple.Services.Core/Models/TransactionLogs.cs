using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Host
{
    public partial class TransactionLogs
    {
        public long Id { get; set; }
        public decimal CurrencyCurrencyValue { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
        public string ClientIpAddress { get; set; }
        public string ClientName { get; set; }
        public bool IsFreeze { get; set; }
        public int PayChannel { get; set; }
        public int Terminal { get; set; }
        public int TransactionState { get; set; }
        public string CustomData { get; set; }
        public string OutTradeNo { get; set; }
        public string TransactionId { get; set; }
        public DateTime? PayTime { get; set; }
        public string Exception { get; set; }
        public string Name { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
