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
    
    public partial class MDeliverySlot
    {
        public MDeliverySlot()
        {
            this.Orders = new HashSet<Order>();
            this.TeleOrders = new HashSet<TeleOrder>();
        }
    
        public short SlotID { get; set; }
        public string SlotName { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTine { get; set; }
        public bool StatusId { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<TeleOrder> TeleOrders { get; set; }
    }
}
