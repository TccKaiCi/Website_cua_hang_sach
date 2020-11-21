using System;
using System.Collections.Generic;
using Domain.Entities.Common;
using Domain.Entities.CustomerAggregate;
using Domain.ValueObjects;

namespace Domain.Entities.OrderAggregate
{
    public class Order : EntityBase, IAggregateRoot
    {
        public string Number { get; set; }
        public DateTime DateReceived { get; set; }
        public decimal Price { get; set; }
        public Address ShipToAddress { get; set; }
        public Customer Customer { get; set; }
        public IList<OrderLine> LineItems { get; } = new List<OrderLine>();
    }
}