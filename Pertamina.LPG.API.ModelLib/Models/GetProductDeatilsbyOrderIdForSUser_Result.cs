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
    
    public partial class GetProductDeatilsbyOrderIdForSUser_Result
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PromoProduct { get; set; }
        public int RefillQuantity { get; set; }
        public decimal RefillPrice { get; set; }
        public decimal PromoRefill { get; set; }
        public Nullable<decimal> ShippingPrice { get; set; }
        public Nullable<decimal> ShippingPromoPrice { get; set; }
        public decimal TotamAmount { get; set; }
    }
}