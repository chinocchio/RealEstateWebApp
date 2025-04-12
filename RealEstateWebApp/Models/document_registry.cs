using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class document_registry
{
    public string document_code { get; set; } = null!;

    public string? document_description { get; set; }

    public string? document_does_expire { get; set; }

    public string? document_duration_in_months { get; set; }
}
