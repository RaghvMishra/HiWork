
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
    
public partial class Message
{

    public long ID { get; set; }

    public System.Guid SenderID { get; set; }

    public string SenderName { get; set; }

    public System.Guid ReceiverID { get; set; }

    public string ReceiverName { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }

    public Nullable<int> Status { get; set; }

    public Nullable<System.DateTime> ReadDate { get; set; }

    public Nullable<System.DateTime> ReplyDate { get; set; }

    public string AttachedFile { get; set; }

    public Nullable<long> AttachedSize { get; set; }

    public string DownloadURL { get; set; }

    public Nullable<System.Guid> OrderID { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public Nullable<long> CreatedBy { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<long> UpdatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

}

}
