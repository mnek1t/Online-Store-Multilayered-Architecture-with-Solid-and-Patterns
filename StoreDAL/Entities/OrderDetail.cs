using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("customer_order_details")]
    public class OrderDetail : BaseEntity
    {
        [Column("customer_order_id")]
        [ForeignKey("CustomerOrder")]
        public int OrderId { get; set; }

        [Column("product_id")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("product_amount")]
        public int ProductAmount { get; set; }
        public CustomerOrder Order { get; set; }
        public Product Product { get; set; }

        public OrderDetail() : base() { }
        public OrderDetail(int id, int orderId, int productId, decimal price, int amount) : base(id)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Price = price;
            this.ProductAmount = amount;
        }
    }
}
