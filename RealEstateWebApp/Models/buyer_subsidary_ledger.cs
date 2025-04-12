using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class buyer_subsidary_ledger
{
    public string? sales_contract_number { get; set; }

    public string? bp_number { get; set; }

    public string? unit_code { get; set; }

    public string? payment_term_schedule { get; set; }

    public string? payment_number { get; set; }

    public string? amount_due { get; set; }

    public string? when_due { get; set; }

    public string? payment_reference_doc_number { get; set; }

    public string? payment_reference_doc_type { get; set; }

    public string? payment_reference_amount { get; set; }

    public string? payment_reference_date { get; set; }
}
