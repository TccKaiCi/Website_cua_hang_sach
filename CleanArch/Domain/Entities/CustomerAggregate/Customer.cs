using System.Collections.Generic;
using Domain.Entities.Common;

namespace Domain.Entities.CustomerAggregate
{
    public class Customer : EntityBase, IAggregateRoot
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
    }
}