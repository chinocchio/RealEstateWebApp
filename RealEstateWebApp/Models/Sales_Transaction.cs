using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class Sales_Transaction
{
    public string? Sales_Contract_Number { get; set; }

    public DateOnly? Sales_Transaction_Date { get; set; }

    public string? Transaction_Type { get; set; }

    public string? Type_Of_Sale { get; set; }

    public string? Sale_Status { get; set; }

    public string? Property_Type { get; set; }

    public string? Project { get; set; }

    public string? Building_Phase { get; set; }

    public string? Floor_Block { get; set; }

    public string? Unit_Code { get; set; }

    public string? Bp_Number { get; set; }

    public string? Principal_Buyer { get; set; }

    public string? Co_Buyer { get; set; }

    public string? Spouse { get; set; }

    public string? AIF_SPA { get; set; }

    public string? Job_Title { get; set; }

    public string? Demographic_By_Market { get; set; }

    public string? Employment_Category { get; set; }

    public string? Reason_For_Purchase { get; set; }

    public string? Number_Of_Homes_In_PH { get; set; }

    public byte? With_Other_CPGI_Units { get; set; }

    public string? CPGI_Unit_Number { get; set; }

    public string? With_Dependents { get; set; }

    public string? No_Of_Dependents { get; set; }

    public decimal? Income_Declared_Of_PB { get; set; }

    public decimal? Income_Declared_Of_CB { get; set; }

    public decimal? Total_Income { get; set; }

    public decimal? Selling_Price { get; set; }

    public int? Unit_Count { get; set; }

    public DateOnly? Holding_Date { get; set; }

    public DateOnly? RF_Date_Paid { get; set; }

    public string? RF_Holding_Proof { get; set; }

    public decimal? RF_Paid_Amout_To_Unit { get; set; }

    public decimal? RF_Paid_Amount_To_GMTOE { get; set; }

    public decimal? RF_Total { get; set; }

    public DateOnly? RF_Credited { get; set; }

    public string? RF_OR_Number { get; set; }

    public decimal? Price_Per_Square_Meter_Base { get; set; }

    public decimal? Promo_Additional_Discount_Description { get; set; }

    public decimal? Promo_Additional_Discount_Amount { get; set; }

    public decimal? Net_Storage { get; set; }

    public decimal? Net_Parking { get; set; }

    public decimal? Net_Unit { get; set; }

    public decimal? Total_Contract_Price { get; set; }

    public decimal? Transfer_Fee { get; set; }

    public decimal? TCP_With_GMTOE { get; set; }

    public decimal? TCP_Net_Of_CM_With_GMTOE { get; set; }

    public decimal? NET_Per_Square_Meter { get; set; }

    public DateOnly? Price_List_Date { get; set; }

    public string? Payment_Term { get; set; }

    public string? Payment_Percentage { get; set; }

    public DateOnly? Payment_Date_As_Of { get; set; }

    public decimal? TurnoverBalance { get; set; }

    public decimal? TurnoverBalance_Amount { get; set; }

    public decimal? TurnoverBalance_Mode_Of_Payment { get; set; }

    public decimal? Estimated_Bank_MA_At_7_5 { get; set; }

    public string? Seller_BPnumber_0 { get; set; }

    public string? Seller_Level_0 { get; set; }

    public string? Seller_BPnumber_1 { get; set; }

    public string? Seller_Level_1 { get; set; }

    public string? Seller_BPnumber_2 { get; set; }

    public string? Seller_Level_2 { get; set; }

    public string? Seller_BPnumber_3 { get; set; }

    public string? Seller_Level_3 { get; set; }

    public string? Seller_BPnumber_4 { get; set; }

    public string? Seller_Level_4 { get; set; }

    public string? Seller_BPnumber_5 { get; set; }

    public string? Seller_Level_5 { get; set; }

    public string? Status_2 { get; set; }

    public string? Category_Sale { get; set; }

    public string? Point_Of_Sale { get; set; }

    public string? Source_Of_Transaction { get; set; }

    public decimal? Gross_Contract_Price { get; set; }

    public decimal? Gross_Transfer_Fee { get; set; }

    public decimal? Gross_Parking { get; set; }

    public decimal? Gross_Storage { get; set; }

    public string? FF_Packge { get; set; }

    public decimal? Allowable_By_The_Developer { get; set; }

    public DateOnly? MA_Start_Date_First { get; set; }

    public decimal? MA_Unit_Parking { get; set; }

    public decimal? MA_Transfer_fee { get; set; }

    public decimal? MA_Amount_Paid_To_Unit { get; set; }

    public decimal? MA_Amount_Paid_To_TF { get; set; }

    public DateOnly? MA_Date_Paid { get; set; }

    public string? MA_First_OR_Number { get; set; }

    public int? Total_PDCS_Required { get; set; }

    public string? Bank_PDC_issued { get; set; }

    public string? Total_PDCS_or_ADA_Submitted { get; set; }

    public DateOnly? PDC_Completion_Date { get; set; }

    public DateOnly? CTS_To_Date { get; set; }

    public string? CTS_Status { get; set; }

    public string? CTS_Type { get; set; }

    public string? Signed_By_Broker { get; set; }

    public string? CTS_Apostilized_Consultarized_Notarized { get; set; }

    public DateOnly? Date_Recieved_From_Sales_Admin { get; set; }

    public string? Date_Notary { get; set; }

    public int? No_Of_Parking_Slot { get; set; }

    public string? Slot_Asigned { get; set; }

    public string? Parking_Level { get; set; }

    public string? Category1 { get; set; }

    public string? CCA_Status { get; set; }

    public string? DT_Holding_Remarks { get; set; }

    public string? DT_Documents_Remarks { get; set; }

    public string? Collection_Status { get; set; }

    public decimal? Unit_Collection { get; set; }

    public decimal? TF_Collection { get; set; }

    public decimal? Total_Collection { get; set; }

    public decimal? Percentage_Of_Payment_Collection { get; set; }

    public string? Payment_Category_Collection { get; set; }

    public string? AgeingOf_Collection { get; set; }

    public string? Lacking_Docs { get; set; }

    public string? NNC_Email { get; set; }

    public string? NNC_Courier { get; set; }

    public string? DateRecievedAndBy { get; set; }

    public string? Cancelation_Date { get; set; }

    public string? Cancelation_Tagging { get; set; }

    public string? PercentOfPayment { get; set; }

    public string? Holding_RF_Date { get; set; }

    public string? SpecificReasonOfCancellation { get; set; }

    public string? Issued_Cancelled_By { get; set; }

    public string? Cancellation_Remarks { get; set; }

    public string? Category2_For_Declined_CI { get; set; }

    public string? With_Refund_Request { get; set; }

    public string? If_Approved { get; set; }

    public string? Refund_Tagging { get; set; }

    public string? Refund_Remarks { get; set; }

    public DateOnly? SetB_CTS_SPA_and_DOR_OUTDATE { get; set; }

    public DateOnly? SetB_Complaince_Due { get; set; }

    public string? PDC_ADA_StartDate { get; set; }

    public string? PDC_ADA_EndDate { get; set; }

    public string? CTS_PH_OTHR_Address { get; set; }

    public string? Employer_Address { get; set; }

    public string? PB_Age_Bracket { get; set; }

    public DateOnly? Date_Of_Birth { get; set; }

    public int? Age { get; set; }

    public string? Civil_Status { get; set; }

    public string? Citizenship { get; set; }

    public string? Nationality { get; set; }

    public string? Persona_Category { get; set; }

    public string? Immigrant_Or_NonImmigrant { get; set; }

    public string? HighRisk { get; set; }

    public string? HighRisk_Factors { get; set; }
}
