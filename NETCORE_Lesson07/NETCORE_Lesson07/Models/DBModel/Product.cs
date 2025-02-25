using System;
using System.Collections.Generic;

namespace NETCORE_Lesson07.Models.DBModel;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public double? Price { get; set; }

    public string? Images { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrdersDetail> OrdersDetails { get; set; } = new List<OrdersDetail>();
}
