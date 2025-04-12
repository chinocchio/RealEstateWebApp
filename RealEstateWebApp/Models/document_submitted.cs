using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class document_submitted
{
    public string? sales_contract_number { get; set; }

    public string? bp_number { get; set; }

    public string? unit_code { get; set; }

    public string? document_code { get; set; }

    public string? document_date_submitted { get; set; }

    public string? yes_or_no { get; set; }
}
