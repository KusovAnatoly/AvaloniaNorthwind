using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaNorthwind.Models;

public partial class OrderDetail
{
    public short OrderId { get; set; }

    public short ProductId { get; set; }

    public float UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    [NotMapped]
    public float Sum => UnitPrice * Quantity - Discount;
}
