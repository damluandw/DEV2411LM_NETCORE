using System;
using System.Collections.Generic;

namespace NETCORE_Lesson07.Models.DBModel;

public partial class Order
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public double? TotalPrice { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<OrdersDetail> OrdersDetails { get; set; } = new List<OrdersDetail>();
}
