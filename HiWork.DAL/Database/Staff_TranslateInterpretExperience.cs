
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
    
public partial class Staff_TranslateInterpretExperience
{

    public System.Guid ID { get; set; }

    public System.Guid StaffID { get; set; }

    public Nullable<int> PriorityID { get; set; }

    public Nullable<System.Guid> TransSpecialFieldID1 { get; set; }

    public Nullable<System.Guid> TransSpecialFieldID2 { get; set; }

    public Nullable<System.Guid> TransSpecialFieldID3 { get; set; }

    public Nullable<bool> HasResearchExperience { get; set; }

    public Nullable<bool> HasMSOfficeExperience { get; set; }

    public Nullable<bool> HasMacOSExperience { get; set; }

    public Nullable<bool> HasAdobeExperience { get; set; }

    public Nullable<long> AssignedWork { get; set; }

    public Nullable<long> WorkDelay { get; set; }

    public Nullable<long> WorkClaim { get; set; }

    public Nullable<long> PuntualityPercentage { get; set; }

    public Nullable<long> ClaimPercentage { get; set; }

    public Nullable<decimal> EvaluationAvg { get; set; }

    public Nullable<decimal> EvaluationInterp { get; set; }

    public Nullable<decimal> EvaluationTrans { get; set; }

    public Nullable<decimal> EvaluationDTP { get; set; }

    public Nullable<decimal> TransRatingPunctuality { get; set; }

    public Nullable<decimal> TransRatingQuality { get; set; }

    public Nullable<decimal> TransRatingComment { get; set; }

    public Nullable<decimal> TransRatingFeedback { get; set; }

    public Nullable<decimal> TransRatingLayout { get; set; }

    public Nullable<decimal> TransRatingResponse { get; set; }

    public Nullable<decimal> TransRatingNegotiation { get; set; }

    public Nullable<decimal> InterpRatingPunctuality { get; set; }

    public Nullable<decimal> InterpRatingQuality { get; set; }

    public Nullable<decimal> InterpRatingComment { get; set; }

    public Nullable<decimal> InterpRatingFeedback { get; set; }

    public Nullable<decimal> InterpRatingReport { get; set; }

    public Nullable<decimal> InterpRatingManner { get; set; }

    public Nullable<decimal> InerpRatingNegotiation { get; set; }

    public Nullable<decimal> TransPricePerPage { get; set; }

    public Nullable<decimal> TransPricePerWord { get; set; }

    public Nullable<decimal> TransPricePerPageRequested { get; set; }

    public Nullable<decimal> TransPricePerWordRequested { get; set; }

    public string TransPriceNote_en { get; set; }

    public string TransPriceNote_jp { get; set; }

    public string TransPriceNote_kr { get; set; }

    public string TransPriceNote_cn { get; set; }

    public string TransPriceNote_fr { get; set; }

    public string TransPriceNote_tl { get; set; }

    public Nullable<decimal> InterpPricePerDay { get; set; }

    public Nullable<decimal> InterpPricePerHalfDay { get; set; }

    public Nullable<decimal> InterpPricePerHour { get; set; }

    public Nullable<decimal> InterpPricePerPageRequested { get; set; }

    public Nullable<decimal> InterpPricePerHalfDayRequested { get; set; }

    public Nullable<decimal> InterpPricePerHourRequested { get; set; }

    public string InterpPriceNote_en { get; set; }

    public string InterpPriceNote_jp { get; set; }

    public string InterpPriceNote_kr { get; set; }

    public string InterpPriceNote_cn { get; set; }

    public string InterpPriceNote_fr { get; set; }

    public string InterpPriceNote_tl { get; set; }

    public string CoordinatorSalesNote_en { get; set; }

    public string CoordinatorSalesNote_jp { get; set; }

    public string CoordinatorSalesNote_kr { get; set; }

    public string CoordinatorSalesNote_cn { get; set; }

    public string CoordinatorSalesNote_fr { get; set; }

    public string CoordinatorSalesNote_tl { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<long> CreatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public Nullable<long> UpdatedBy { get; set; }



    public virtual Staff Staff { get; set; }

}

}
