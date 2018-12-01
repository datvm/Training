using System;
using System.Collections.Generic;

namespace BasicTraining.Api.Models.Entities
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
