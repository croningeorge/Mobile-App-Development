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
    using System.Collections.Generic;
    
    public partial class MDeliveryStatu
    {
        public MDeliveryStatu()
        {
            this.OrderDeliveries = new HashSet<OrderDelivery>();
            this.TeleOrderDeliveries = new HashSet<TeleOrderDelivery>();
        }
    
        public short DlstID { get; set; }
        public string DeliveryStatus { get; set; }
        public bool StatusId { get; set; }
    
        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
        public virtual ICollection<TeleOrderDelivery> TeleOrderDeliveries { get; set; }
    }
}
