
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
    
public partial class Order_WebDocuments
{

    public System.Guid ID { get; set; }

    public System.Guid OrderID { get; set; }

    public string Name { get; set; }

    public string FileDescription { get; set; }

    public string DownloadURL { get; set; }

    public Nullable<System.DateTime> UploadDate { get; set; }

    public Nullable<long> WordCount { get; set; }

    public string OriginalName { get; set; }

    public string Extension { get; set; }

}

}
