using System;
using System.Collections.Generic;

namespace BasicTraining.Api.Models.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public Category Category { get; set; }
    }
}
