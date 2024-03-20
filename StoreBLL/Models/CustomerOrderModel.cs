using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class CustomerOrderModel : AbstractModel
    {

        public CustomerOrderModel(int id, int userId, string operationTime, int otrderStateId) : base(id)
        {
            this.Id = id;
            this.UserId = userId;
            this.OperationTime = operationTime;
            this.OrderStateId= otrderStateId;
        }
        public int UserId { get; set; }
        public string OperationTime { get; set; }
        public int OrderStateId { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} {UserId} {OperationTime} {OrderStateId}";
        }
    }
}
