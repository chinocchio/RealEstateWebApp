using System;
using System.Collections.Generic;

namespace RealEstateWebApp.Models;

public partial class Property
{
    public string? Property_type { get; set; }

    public string? Project { get; set; }

    public string? Building_Phase { get; set; }

    public string? Floor_Block { get; set; }

    public string? Unit_Code { get; set; }

    public string? View { get; set; }

    public string? Unit_Type { get; set; }

    public decimal? Unit_Area { get; set; }

    public decimal? Balcony_Area { get; set; }

    public decimal? Total_Unit_Area { get; set; }

    public string? Status_In_General { get; set; }

    public string? Milestone { get; set; }

    public string? Status_Color { get; set; }
}
