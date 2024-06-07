
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
    
public partial class Master_StaffCurrentState
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Master_StaffCurrentState()
    {

        this.Staff_CurrentStates = new HashSet<Staff_CurrentStates>();

    }


    public System.Guid ID { get; set; }

    public string Name_en { get; set; }

    public string Name_jp { get; set; }

    public string Name_kr { get; set; }

    public string Name_cn { get; set; }

    public string Name_fr { get; set; }

    public string Name_tl { get; set; }

    public string Description_en { get; set; }

    public string Description_jp { get; set; }

    public string Description_kr { get; set; }

    public string Description_cn { get; set; }

    public string Description_fr { get; set; }

    public string Description_tl { get; set; }

    public Nullable<int> SortBy { get; set; }

    public bool IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<long> CreatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public Nullable<long> UpdatedBy { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Staff_CurrentStates> Staff_CurrentStates { get; set; }

}

}
