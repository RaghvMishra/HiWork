
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
    
public partial class Master_Country
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Master_Country()
    {

        this.Employees = new HashSet<Employee>();

        this.Master_Address = new HashSet<Master_Address>();

        this.Master_Bank = new HashSet<Master_Bank>();

        this.Master_BranchOffice = new HashSet<Master_BranchOffice>();

        this.Master_Department = new HashSet<Master_Department>();

        this.Master_Designation = new HashSet<Master_Designation>();

        this.Master_Team = new HashSet<Master_Team>();

        this.Master_Culture = new HashSet<Master_Culture>();

        this.Master_Division = new HashSet<Master_Division>();

        this.Staff_EducationalHistory = new HashSet<Staff_EducationalHistory>();

        this.Staffs = new HashSet<Staff>();

    }


    public long ID { get; set; }

    public string Code { get; set; }

    public Nullable<long> CurrencyID { get; set; }

    public string Name_en { get; set; }

    public string Name_jp { get; set; }

    public string Name_kr { get; set; }

    public string Name_cn { get; set; }

    public string Name_fr { get; set; }

    public string Name_tl { get; set; }

    public Nullable<bool> IsTrading { get; set; }

    public Nullable<int> SortBy { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public Nullable<long> CreatedBy { get; set; }

    public bool IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public Nullable<long> UpdatedBy { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Employee> Employees { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Address> Master_Address { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Bank> Master_Bank { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_BranchOffice> Master_BranchOffice { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Department> Master_Department { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Designation> Master_Designation { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Team> Master_Team { get; set; }

    public virtual Master_Currency Master_Currency { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Culture> Master_Culture { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Master_Division> Master_Division { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Staff_EducationalHistory> Staff_EducationalHistory { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Staff> Staffs { get; set; }

}

}
