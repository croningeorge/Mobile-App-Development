//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pertamina.LPG.API.Models
{
    using System;
    
    public partial class GetIssuesListForSUser_Result
    {
        public int OrdrID { get; set; }
        public string InvoiceNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.TimeSpan OrderTime { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public decimal GrandTotal { get; set; }
        public string Address { get; set; }
    }
}
