using Domain.Entities.Common;

namespace Domain.Entities.OrderAggregate
{
    public class OrderLine : EntityBase
    {
        public int Quantity { get; set; }
        public decimal  Price { get; set; }
        public MovieOrdered Movie { get; set; }
    }
}