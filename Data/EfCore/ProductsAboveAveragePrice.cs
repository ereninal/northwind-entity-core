using System;
using System.Collections.Generic;

namespace database_existing_entity.Data.EfCore
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
