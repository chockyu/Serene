﻿
namespace Serene.Northwind
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty("OrderID"), NameProperty("CustomerID"), Flexify, Maximizable]
    [FormKey("Northwind.Order"), LocalTextPrefix("Northwind.Order"), Service("Northwind/Order")]
    public class OrderDialog : EntityDialog<OrderRow>
    {
    }
}