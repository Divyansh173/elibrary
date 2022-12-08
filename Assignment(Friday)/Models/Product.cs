﻿using System;
using System.Collections.Generic;

namespace Assignment_Friday_.Models
{
    public partial class Product
    {
        public int ProductUniqueId { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int SubCategoryId { get; set; }
        public int? ManufacturerId { get; set; }
        public string? Seller { get; set; }

        public virtual Manufacturer? Manufacturer { get; set; }
        public virtual SubCategory SubCategory { get; set; } = null!;
    }
}
