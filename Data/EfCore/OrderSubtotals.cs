using System;
using System.Collections.Generic;

namespace database_existing_entity.Data.EfCore
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
