
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
    
public partial class Master_TeamToMarket
{

    public System.Guid ID { get; set; }

    public System.Guid TeamID { get; set; }

    public System.Guid MarketID { get; set; }

    public bool IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }



    public virtual Master_Market Master_Market { get; set; }

    public virtual Master_Team Master_Team { get; set; }

    public virtual Master_TeamToMarket Master_TeamToMarket1 { get; set; }

    public virtual Master_TeamToMarket Master_TeamToMarket2 { get; set; }

}

}
