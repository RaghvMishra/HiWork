
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
    
public partial class Master_Address
{

    public System.Guid ID { get; set; }

    public long CountryID { get; set; }

    public string Address_en { get; set; }

    public string Address_jp { get; set; }

    public string Address_kr { get; set; }

    public string Address_cn { get; set; }

    public string Address_fr { get; set; }

    public string Address_tl { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<System.Guid> CreatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public Nullable<System.Guid> UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }



    public virtual Master_Country Master_Country { get; set; }

}

}
