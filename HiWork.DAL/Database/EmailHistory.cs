
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
    
public partial class EmailHistory
{

    public long ID { get; set; }

    public string EmailTo { get; set; }

    public string EmailSubject { get; set; }

    public Nullable<long> SendBy { get; set; }

    public string EmailBody { get; set; }

    public string AttachedFile { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<long> CreatedBy { get; set; }

}

}
