using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class business_partner
{
    public string? role { get; set; }

    public string? bp_number { get; set; }

    public string? fullname { get; set; }

    public string? principal_buyer_reference { get; set; }

    public DateOnly? birthdate { get; set; }

    public int? age { get; set; }

    public string? age_category { get; set; }

    public string? gender { get; set; }

    public string? civil_status { get; set; }

    public string? email { get; set; }

    public string? contact_number { get; set; }

    public string? client_base { get; set; }

    public string? citizenship { get; set; }

    public string? nationality { get; set; }

    public string? job_title { get; set; }

    public string? demographic_by_market { get; set; }

    public string? employment_category { get; set; }

    public string? company_name { get; set; }

    public string? industry_type { get; set; }

    public string? employment_country { get; set; }

    public string? reason_for_purchase { get; set; }

    public int? number_of_homes_in_ph { get; set; }

    public string? with_other_cpgi_units { get; set; }

    public string? cpgi_unit_no { get; set; }

    public string? with_dependents { get; set; }

    public string? no_of_dependents { get; set; }

    public decimal? income_declared_pb { get; set; }

    public decimal? income_declared_cb { get; set; }

    public decimal? total_income { get; set; }
}
