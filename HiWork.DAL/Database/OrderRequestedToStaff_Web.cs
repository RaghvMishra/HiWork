
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace HiWork.DAL.Database
{

using System;
    using System.Collections.Generic;
    
public partial class OrderRequestedToStaff_Web
{

    public System.Guid ID { get; set; }

    public System.Guid TranslatorID { get; set; }

    public System.Guid OrderID { get; set; }

    public System.Guid ClientID { get; set; }

    public Nullable<System.DateTime> RequestDate { get; set; }



    public virtual Company Company { get; set; }

    public virtual Order_Web Order_Web { get; set; }

    public virtual Staff Staff { get; set; }

}

}
