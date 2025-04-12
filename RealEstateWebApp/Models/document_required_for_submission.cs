using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class document_required_for_submission
{
    public string? document_finance_type { get; set; }

    public string? document_location { get; set; }

    public string? document_source_of_income { get; set; }

    public string? document_group { get; set; }

    public string document_code { get; set; } = null!;
}
