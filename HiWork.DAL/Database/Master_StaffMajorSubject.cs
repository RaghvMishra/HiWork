
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
    
public partial class Master_StaffMajorSubject
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Master_StaffMajorSubject()
    {

        this.Master_StaffMajorSubjectDetails = new HashSet<Master_StaffMajorSubjectDetails>();

        this.Staff_EducationalHistory = new HashSet<Staff_EducationalHistory>();

    }


    public System.Guid ID { get; set; }

    public string Code { get; set; }

    public string Name_en { get; set; }

    public string Name_jp { get; set; }

    public string Name_kr { get; set; }

    public string Name_cn { get; set; }

    public string Name_fr { get; set; }

    public string Name_tl { get; set; }

    public long CreatedBy { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public Nullable<long> UpdatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public bool IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_StaffMajorSubjectDetails> Master_StaffMajorSubjectDetails { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Staff_EducationalHistory> Staff_EducationalHistory { get; set; }

}

}
