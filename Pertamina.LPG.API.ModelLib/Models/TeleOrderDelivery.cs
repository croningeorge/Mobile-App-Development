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
    
    public partial class TeleOrderDelivery
    {
        public int TelDelvID { get; set; }
        public int TeleOrdID { get; set; }
        public int DrvrID { get; set; }
        public int AgadmID { get; set; }
        public System.DateTime AcceptedDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public short StatusId { get; set; }
        public int deviation { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual AgentAdmin AgentAdmin { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual MDeliveryStatu MDeliveryStatu { get; set; }
        public virtual TeleOrder TeleOrder { get; set; }
    }
}
