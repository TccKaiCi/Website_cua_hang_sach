using Domain.Entities.Common;

namespace Domain.Entities.CustomerAggregate
{
    public class PaymentMethod : EntityBase
    {
        public string Alias { get; set; }
        public string CardId { get; set; }
        public string Last4 { get; set; }
    }
}