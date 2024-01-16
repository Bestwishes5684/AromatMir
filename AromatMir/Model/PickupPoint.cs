using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AromatMir.Model
{
    public partial class PickupPoint
    {
        public PickupPoint()
        {
            Order = new HashSet<Order>();
        }

        public int IdPickupPoint { get; set; }
        public string MailIndexPickupPoint { get; set; }
        public string CityPickupPoint { get; set; }
        public string StreetPickupPoint { get; set; }
        public string NumberHousePickupPoint { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
