using System;
using System.Collections.Generic;

namespace MarketSG.Model.Entities;

public partial class Attributes
{
    public int AttrubutesId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<AttributesPrice> AttributesPrices { get; set; } = new List<AttributesPrice>();
}
