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
    
    public partial class InvoiceNumber
    {
        public int InvnrID { get; set; }
        public int InvoiceNumber1 { get; set; }
        public int AgenID { get; set; }
    
        public virtual Agency Agency { get; set; }
    }
}
