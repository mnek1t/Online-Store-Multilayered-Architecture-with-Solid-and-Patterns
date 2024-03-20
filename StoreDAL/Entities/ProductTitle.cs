﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("product_title")]
    public class ProductTitle : BaseEntity
    {
        [Column("product_title")]
        public string Title { get; set; }

        [Column("category_id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual IList<Product> Products { get; set; }

        public ProductTitle() : base() { }
        public ProductTitle(int id, string title, int categoryId) : base(id)
        {
            this.Title = title;
            this.CategoryId = categoryId;
        }
    }
}
