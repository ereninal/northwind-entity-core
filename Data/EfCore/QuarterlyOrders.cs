using System;
using System.Collections.Generic;

namespace database_existing_entity.Data.EfCore
{
    public partial class QuarterlyOrders
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
