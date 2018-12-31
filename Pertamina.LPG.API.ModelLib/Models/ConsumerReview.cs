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
    
    public partial class ConsumerReview
    {
        public int ReviewID { get; set; }
        public int ConsID { get; set; }
        public int OrdrID { get; set; }
        public int DrvrID { get; set; }
        public int Rating { get; set; }
        public Nullable<int> ReasonID { get; set; }
        public string Comments { get; set; }
    
        public virtual Consumer Consumer { get; set; }
        public virtual ConsumerReviewReason ConsumerReviewReason { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Order Order { get; set; }
    }
}
