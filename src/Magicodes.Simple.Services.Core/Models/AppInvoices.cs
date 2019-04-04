using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AppInvoices
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string TenantAddress { get; set; }
        public string TenantLegalName { get; set; }
        public string TenantTaxNo { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public string Contact { get; set; }
    }
}
