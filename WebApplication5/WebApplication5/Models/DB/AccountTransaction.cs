//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountTransaction
    {
        public int transactionID { get; set; }
        public string transactionName { get; set; }
        public System.DateTime transactionDate { get; set; }
        public string Debit_Credit { get; set; }
        public long amount { get; set; }
        public int subtypeID { get; set; }
        public int accountNo { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual subTypesOfHeadAccount subTypesOfHeadAccount { get; set; }
    }
}