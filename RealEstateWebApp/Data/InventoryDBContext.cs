using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApp.Models;

namespace RealEstateWebApp.Data;

public partial class InventoryDBContext : DbContext
{
    public InventoryDBContext()
    {
    }

    public InventoryDBContext(DbContextOptions<InventoryDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Credit_Review> Credit_Reviews { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<Sales_Transaction> Sales_Transactions { get; set; }

    public virtual DbSet<business_partner> business_partners { get; set; }

    public virtual DbSet<buyer_subsidary_ledger> buyer_subsidary_ledgers { get; set; }

    public virtual DbSet<dependent> dependents { get; set; }

    public virtual DbSet<document_registry> document_registries { get; set; }

    public virtual DbSet<document_required_for_submission> document_required_for_submissions { get; set; }

    public virtual DbSet<document_submitted> document_submitteds { get; set; }

    public virtual DbSet<seller> sellers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Credit_Review>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Credit_Review");

            entity.Property(e => e.bp_number).HasMaxLength(50);
            entity.Property(e => e.building_phase).HasMaxLength(50);
            entity.Property(e => e.cI_result).HasMaxLength(50);
            entity.Property(e => e.ci_remarks).HasColumnType("text");
            entity.Property(e => e.cmap_result).HasMaxLength(50);
            entity.Property(e => e.extimated_max_term)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.floor_block).HasMaxLength(50);
            entity.Property(e => e.is_bank_approvable).HasMaxLength(50);
            entity.Property(e => e.ndi_category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ndi_rate).HasMaxLength(50);
            entity.Property(e => e.ndi_status).HasMaxLength(50);
            entity.Property(e => e.percent_of_ndi_vs_ma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.project).HasMaxLength(50);
            entity.Property(e => e.red_tag).HasMaxLength(50);
            entity.Property(e => e.red_tag_reason).HasMaxLength(50);
            entity.Property(e => e.sales_contract_number).HasMaxLength(50);
            entity.Property(e => e.type_of_income).HasMaxLength(50);
            entity.Property(e => e.unit_code).HasMaxLength(50);
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Balcony_Area).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Building_Phase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Floor_Block)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Milestone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Project)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Property_type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status_Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status_In_General)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Total_Unit_Area).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Unit_Area).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Unit_Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unit_Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.View)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sales_Transaction>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AIF_SPA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgeingOf_Collection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Allowable_By_The_Developer).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Bank_PDC_issued)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bp_Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Building_Phase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CCA_Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CPGI_Unit_Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CTS_Apostilized_Consultarized_Notarized)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CTS_PH_OTHR_Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CTS_Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CTS_Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cancelation_Date)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cancelation_Tagging)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cancellation_Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category2_For_Declined_CI)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category_Sale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Citizenship)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Civil_Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Co_Buyer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Collection_Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DT_Documents_Remarks).HasColumnType("text");
            entity.Property(e => e.DT_Holding_Remarks).HasColumnType("text");
            entity.Property(e => e.DateRecievedAndBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date_Notary)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Demographic_By_Market)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Employer_Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Employment_Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estimated_Bank_MA_At_7_5)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Estimated_Bank_MA_At_7.5");
            entity.Property(e => e.FF_Packge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Floor_Block)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gross_Contract_Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Gross_Parking).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Gross_Storage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Gross_Transfer_Fee).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.HighRisk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HighRisk_Factors)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Holding_RF_Date)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.If_Approved)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Immigrant_Or_NonImmigrant)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Income_Declared_Of_CB).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Income_Declared_Of_PB).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Issued_Cancelled_By)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Job_Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lacking_Docs).HasColumnType("text");
            entity.Property(e => e.MA_Amount_Paid_To_TF).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MA_Amount_Paid_To_Unit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MA_First_OR_Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MA_Transfer_fee).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MA_Unit_Parking).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NET_Per_Square_Meter).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NNC_Courier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NNC_Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Net_Parking).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Net_Storage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Net_Unit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.No_Of_Dependents)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Number_Of_Homes_In_PH)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PB_Age_Bracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PDC_ADA_EndDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PDC_ADA_StartDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Parking_Level)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Payment_Category_Collection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Payment_Percentage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Payment_Term)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PercentOfPayment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Percentage_Of_Payment_Collection).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Persona_Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Point_Of_Sale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price_Per_Square_Meter_Base).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Principal_Buyer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Project)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Promo_Additional_Discount_Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Promo_Additional_Discount_Description).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Property_Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RF_Holding_Proof)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RF_OR_Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RF_Paid_Amount_To_GMTOE).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RF_Paid_Amout_To_Unit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RF_Total).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Reason_For_Purchase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Refund_Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Refund_Tagging)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sale_Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sales_Contract_Number)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Seller_BPnumber_0)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_BPnumber_1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_BPnumber_2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_BPnumber_3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_BPnumber_4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_BPnumber_5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_Level_0)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_Level_1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_Level_2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_Level_3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_Level_4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seller_Level_5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Selling_Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Signed_By_Broker)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Slot_Asigned)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Source_Of_Transaction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecificReasonOfCancellation).HasColumnType("text");
            entity.Property(e => e.Spouse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status_2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TCP_Net_Of_CM_With_GMTOE).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TCP_With_GMTOE).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TF_Collection).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total_Collection).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total_Contract_Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total_Income).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total_PDCS_or_ADA_Submitted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Transaction_Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Transfer_Fee).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TurnoverBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TurnoverBalance_Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TurnoverBalance_Mode_Of_Payment).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Type_Of_Sale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unit_Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unit_Collection).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.With_Dependents)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.With_Refund_Request)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<business_partner>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.age_category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.bp_number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.citizenship)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.civil_status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.client_base)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.company_name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.contact_number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.cpgi_unit_no)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.demographic_by_market)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.employment_category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.employment_country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fullname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.income_declared_cb).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.income_declared_pb).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.industry_type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.job_title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.no_of_dependents)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.principal_buyer_reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.reason_for_purchase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.total_income).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.with_dependents)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.with_other_cpgi_units)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<buyer_subsidary_ledger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("buyer_subsidary_ledger");

            entity.Property(e => e.amount_due).HasMaxLength(100);
            entity.Property(e => e.bp_number).HasMaxLength(100);
            entity.Property(e => e.payment_number).HasMaxLength(100);
            entity.Property(e => e.payment_reference_amount).HasMaxLength(100);
            entity.Property(e => e.payment_reference_date).HasMaxLength(100);
            entity.Property(e => e.payment_reference_doc_number).HasMaxLength(100);
            entity.Property(e => e.payment_reference_doc_type).HasMaxLength(100);
            entity.Property(e => e.payment_term_schedule).HasMaxLength(100);
            entity.Property(e => e.sales_contract_number).HasMaxLength(100);
            entity.Property(e => e.unit_code).HasMaxLength(100);
            entity.Property(e => e.when_due).HasMaxLength(100);
        });

        modelBuilder.Entity<dependent>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.bp_number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fullname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.relationship)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<document_registry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("document_registry");

            entity.Property(e => e.document_code).HasMaxLength(100);
            entity.Property(e => e.document_description).HasMaxLength(100);
            entity.Property(e => e.document_does_expire).HasMaxLength(100);
            entity.Property(e => e.document_duration_in_months).HasMaxLength(100);
        });

        modelBuilder.Entity<document_required_for_submission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("document_required_for_submission");

            entity.Property(e => e.document_code).HasMaxLength(100);
            entity.Property(e => e.document_finance_type).HasMaxLength(100);
            entity.Property(e => e.document_group).HasMaxLength(100);
            entity.Property(e => e.document_location).HasMaxLength(100);
            entity.Property(e => e.document_source_of_income).HasMaxLength(100);
        });

        modelBuilder.Entity<document_submitted>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("document_submitted");

            entity.Property(e => e.bp_number).HasMaxLength(100);
            entity.Property(e => e.document_code).HasMaxLength(100);
            entity.Property(e => e.document_date_submitted).HasMaxLength(100);
            entity.Property(e => e.sales_contract_number).HasMaxLength(100);
            entity.Property(e => e.unit_code).HasMaxLength(100);
            entity.Property(e => e.yes_or_no).HasMaxLength(100);
        });

        modelBuilder.Entity<seller>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.fullname).HasMaxLength(100);
            entity.Property(e => e.reporting_to).HasMaxLength(100);
            entity.Property(e => e.seller_level).HasMaxLength(100);
            entity.Property(e => e.seller_type_roles).HasMaxLength(100);
            entity.Property(e => e.sellerbp).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
