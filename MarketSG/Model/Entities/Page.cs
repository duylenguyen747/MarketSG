using System;
using System.Collections.Generic;

namespace MarketSG.Model.Entities;

public partial class Page
{
    public int PageId { get; set; }

    public string? PageName { get; set; }

    public string? Contents { get; set; }

    public string? Thumb { get; set; }

    public bool Published { get; set; }

    public string? Title { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Ordering { get; set; }
}
