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
        public int TransactionId { get; set; }
        public string TradePair { get; set; }
        public System.DateTime Date { get; set; }
        public decimal AmountUSD { get; set; }
        public string TradeType { get; set; }
        public decimal Fee { get; set; }
    }
}
