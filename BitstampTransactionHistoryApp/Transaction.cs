//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitstampTransactionHistoryApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int id { get; set; }
        public System.DateTime datetime { get; set; }
        public decimal usd { get; set; }
        public decimal eur { get; set; }
        public decimal btc { get; set; }
        public string btc_usd { get; set; }
        public decimal fee { get; set; }
        public int order_id { get; set; }
    }
}
