
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
    
public partial class ProfitShareSetting
{

    public long ID { get; set; }

    public Nullable<int> SCharge { get; set; }

    public Nullable<int> BCharge { get; set; }

    public Nullable<int> CCharge { get; set; }

    public Nullable<int> PartnerCharge { get; set; }

    public Nullable<int> FrontSalesCharge { get; set; }

    public Nullable<int> AssistantCharge { get; set; }

    public Nullable<int> PersonCharge1 { get; set; }

    public Nullable<int> PersonCharge2 { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public Nullable<long> CreatedBy { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<long> UpdatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public Nullable<int> Sales { get; set; }

    public Nullable<int> OutwardsSalesPersonShare { get; set; }

}

}
