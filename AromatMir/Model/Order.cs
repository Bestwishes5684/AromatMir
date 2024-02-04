using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AromatMir.Model
{
    public partial class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public string TheOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public int OrderPickupPoint { get; set; }
        public string FioClient { get; set; }
        public string CodeGive { get; set; }
        public bool OrderStatus { get; set; }
        public int CountOrder { get; set; }

        public virtual PickupPoint OrderPickupPointNavigation { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
