using System;
using System.Collections.Generic;

#nullable disable

namespace ApplicationAlexTryout.Models.DB
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
    }
}
