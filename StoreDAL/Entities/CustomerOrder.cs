using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("customer_orders")]
    public class CustomerOrder:BaseEntity
    {
        [Column("cutomer_id")]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Column("operation_time")]
        public string OperationTime { get; set; }

        [Column("order_state_id")]
        [ForeignKey("OrderState")]
        public int OrderStateId { get; set; }

        public User User { get; set; }
        public OrderState State { get; set; }
        public virtual IList<OrderDetail> Details { get; set; }

        public CustomerOrder():base() { }
        public CustomerOrder(int id, string operationTime, int userId, int orderStateId) : base(id)
        {
            this.OperationTime = operationTime;
            this.UserId = userId;
            this.OrderStateId = orderStateId;
        }
    }
}
