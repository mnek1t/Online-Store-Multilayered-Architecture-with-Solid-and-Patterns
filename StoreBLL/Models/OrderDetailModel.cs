using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class OrderDetailModel : AbstractModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int ProductAmount { get; set; }
        public OrderDetailModel(int id, int orderId, int productId, decimal price, int amount ) : base(id)
        {
            this.Id = id;
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Price = price;
        }
    }
}
