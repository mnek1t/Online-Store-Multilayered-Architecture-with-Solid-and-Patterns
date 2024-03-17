using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class ProductModel : AbstractModel
    {
        public ProductModel(int id, int titleId, int manufacturerId, string description, decimal price) : base(id)
        {
            this.TitleId = titleId;
            this.ManufacturerId = manufacturerId;
            this.Description = description;
            this.UnitPrice = price;
        }
        public int TitleId { get; set; }
        public int ManufacturerId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} {Description} {TitleId} {UnitPrice} {ManufacturerId}";
        }
    }
}
