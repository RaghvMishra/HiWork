﻿using HiWork.Utils.Infrastructure;

namespace HiWork.BLL.Models
{
    public class DashboardSAdminModel : BaseDomainModel<DashboardSAdminModel>
    {
        #region "Commented"
        //public decimal? jpSales { get; set; }
        //public decimal? jpPredictedSales { get; set; }
        //public decimal? jpOrderCompleted { get; set; }
        //public decimal? jpGrossProfit { get; set; }
        //public decimal? jpSalesPeviousMonth { get; set; }
        //public decimal? jpSalesPeviousYear { get; set; }
        //public decimal? jpStaffPaymentAmount { get; set; }
        //public decimal? jpTotalSalesCurrentMonth { get; set; }
        //public decimal? jpPredectedSalesNextMonth { get; set; }
        //public decimal? jpTrSales { get; set; }
        //public decimal? jpTrPredictedSales { get; set; }
        //public decimal? jpTrOrderCompleted { get; set; }
        //public decimal? jpTrGrossProfit { get; set; }
        //public decimal? jpTrSalesPeviousMonth { get; set; }
        //public decimal? jpTrSalesPeviousYear { get; set; }
        //public decimal? jpTrStaffPaymentAmount { get; set; }
        //public decimal? jpTrTotalSalesCurrentMonth { get; set; }
        //public decimal? jpTrPredectedSalesNextMonth { get; set; }
        //public decimal? jpHrSales { get; set; }
        //public decimal? jpHrPredictedSales { get; set; }
        //public decimal? jpHrOrderCompleted { get; set; }
        //public decimal? jpHrGrossProfit { get; set; }
        //public decimal? jpHrSalesPeviousMonth { get; set; }
        //public decimal? jpHrSalesPeviousYear { get; set; }
        //public decimal? jpHrStaffPaymentAmount { get; set; }
        //public decimal? jpHrTotalSalesCurrentMonth { get; set; }
        //public decimal? jpHrPredectedSalesNextMonth { get; set; }
        //public decimal? jpDvSales { get; set; }
        //public decimal? jpDvPredictedSales { get; set; }
        //public decimal? jpDvOrderCompleted { get; set; }
        //public decimal? jpDvGrossProfit { get; set; }
        //public decimal? jpDvSalesPeviousMonth { get; set; }
        //public decimal? jpDvSalesPeviousYear { get; set; }
        //public decimal? jpDvStaffPaymentAmount { get; set; }
        //public decimal? jpDvTotalSalesCurrentMonth { get; set; }
        //public decimal? jpDvPredectedSalesNextMonth { get; set; }
        //public decimal? crdySales { get; set; }
        //public decimal? crdyPredictedSales { get; set; }
        //public decimal? crdyOrderCompleted { get; set; }
        //public decimal? crdyGrossProfit { get; set; }
        //public decimal? crdySalesPeviousMonth { get; set; }
        //public decimal? crdySalesPeviousYear { get; set; }
        //public decimal? crdyStaffPaymentAmount { get; set; }
        //public decimal? crdyTotalSalesCurrentMonth { get; set; }
        //public decimal? crdyPredectedSalesNextMonth { get; set; }
        //public decimal? krSales { get; set; }
        //public decimal? krPredictedSales { get; set; }
        //public decimal? krOrderCompleted { get; set; }
        //public decimal? krGrossProfit { get; set; }
        //public decimal? krSalesPeviousMonth { get; set; }
        //public decimal? krSalesPeviousYear { get; set; }
        //public decimal? krStaffPaymentAmount { get; set; }
        //public decimal? krTotalSalesCurrentMonth { get; set; }
        //public decimal? krPredectedSalesNextMonth { get; set; }
        //public decimal? phSales { get; set; }
        //public decimal? phPredictedSales { get; set; }
        //public decimal? phOrderCompleted { get; set; }
        //public decimal? phGrossProfit { get; set; }
        //public decimal? phSalesPeviousMonth { get; set; }
        //public decimal? phSalesPeviousYear { get; set; }
        //public decimal? phStaffPaymentAmount { get; set; }
        //public decimal? phTotalSalesCurrentMonth { get; set; }
        //public decimal? phPredectedSalesNextMonth { get; set; }
        //public decimal? bdSales { get; set; }
        //public decimal? bdPredictedSales { get; set; }
        //public decimal? bdOrderCompleted { get; set; }
        //public decimal? bdGrossProfit { get; set; }
        //public decimal? bdSalesPeviousMonth { get; set; }
        //public decimal? bdSalesPeviousYear { get; set; }
        //public decimal? bdStaffPaymentAmount { get; set; }
        //public decimal? bdTotalSalesCurrentMonth { get; set; }
        //public decimal? bdPredectedSalesNextMonth { get; set; }
        #endregion "Commented"

        public decimal? jpSales { get; set; }
        public decimal? jpPredictedSales { get; set; }
        public decimal? jpOrderCompleted { get; set; }
        public decimal? jpGrossProfit { get; set; }
        public decimal? jpGrossProfitRate { get; set; }
        public decimal? jpSalesPeviousMonth { get; set; }
        public decimal? jpSalesRatePrevMonth { get; set; }
        public decimal? jpSalesPeviousYear { get; set; }
        public decimal? jpSalesRatePrevYear { get; set; }
        public decimal? jpStaffPaymentCurrMonth { get; set; }
        public decimal? jpOutstandingSalesCurrMonth { get; set; }
        public decimal? jpAvgOrderedPrice { get; set; }
        public decimal? jpStaffPaymentLastMonth { get; set; }
        public decimal? crSales { get; set; }
        public decimal? crPredictedSales { get; set; }
        public decimal? crOrderCompleted { get; set; }
        public decimal? crGrossProfit { get; set; }
        public decimal? crGrossProfitRate { get; set; }
        public decimal? crSalesPeviousMonth { get; set; }
        public decimal? crSalesRatePrevMonth { get; set; }
        public decimal? crSalesPeviousYear { get; set; }
        public decimal? crSalesRatePrevYear { get; set; }
        public decimal? crStaffPaymentCurrMonth { get; set; }
        public decimal? crOutstandingSalesCurrMonth { get; set; }
        public decimal? crAvgOrderedPrice { get; set; }
        public decimal? crStaffPaymentLastMonth { get; set; }
        public decimal? krSales { get; set; }
        public decimal? krPredictedSales { get; set; }
        public decimal? krOrderCompleted { get; set; }
        public decimal? krGrossProfit { get; set; }
        public decimal? krGrossProfitRate { get; set; }
        public decimal? krSalesPeviousMonth { get; set; }
        public decimal? krSalesRatePrevMonth { get; set; }
        public decimal? krSalesPeviousYear { get; set; }
        public decimal? krSalesRatePrevYear { get; set; }
        public decimal? krStaffPaymentCurrMonth { get; set; }
        public decimal? krOutstandingSalesCurrMonth { get; set; }
        public decimal? krAvgOrderedPrice { get; set; }
        public decimal? krStaffPaymentLastMonth { get; set; }
        public decimal? phSales { get; set; }
        public decimal? phPredictedSales { get; set; }
        public decimal? phOrderCompleted { get; set; }
        public decimal? phGrossProfit { get; set; }
        public decimal? phGrossProfitRate { get; set; }
        public decimal? phSalesPeviousMonth { get; set; }
        public decimal? phSalesRatePrevMonth { get; set; }
        public decimal? phSalesPeviousYear { get; set; }
        public decimal? phSalesRatePrevYear { get; set; }
        public decimal? phStaffPaymentCurrMonth { get; set; }
        public decimal? phOutstandingSalesCurrMonth { get; set; }
        public decimal? phAvgOrderedPrice { get; set; }
        public decimal? phStaffPaymentLastMonth { get; set; }
        public decimal? bdSales { get; set; }
        public decimal? bdPredictedSales { get; set; }
        public decimal? bdOrderCompleted { get; set; }
        public decimal? bdGrossProfit { get; set; }
        public decimal? bdGrossProfitRate { get; set; }
        public decimal? bdSalesPeviousMonth { get; set; }
        public decimal? bdSalesRatePrevMonth { get; set; }
        public decimal? bdSalesPeviousYear { get; set; }
        public decimal? bdSalesRatePrevYear { get; set; }
        public decimal? bdStaffPaymentCurrMonth { get; set; }
        public decimal? bdOutstandingSalesCurrMonth { get; set; }
        public decimal? bdAvgOrderedPrice { get; set; }
        public decimal? bdStaffPaymentLastMonth { get; set; }
    }
}
