﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("products")]
    public class Product:BaseEntity
    {
        [Column("product_title_id")]
        [ForeignKey("ProductTitle")]
        public int TitleId { get; set; }

        [Column("manufacturer_id")]
        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Column("column")]
        public string Description { get; set; }
        public ProductTitle Title { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public virtual IList<OrderDetail> OrderDetails { get; set; }
        public Product() : base() { }
        public Product(int id, int titleId, int manufacturerId, string description, decimal price) : base(id)
        {
            this.TitleId = titleId;
            this.ManufacturerId = manufacturerId;
            this.Description = description;
            this.UnitPrice=price;
        }
    }
}
