using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class CustomerOrderService : ICrud
    {
        ICustomerOrderRepository repository;
        public CustomerOrderService(StoreDbContext context)
        {
            repository = new CustomerOrderRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (CustomerOrderModel)model;
            repository.Add(new CustomerOrder(x.Id, x.OperationTime, x.UserId, x.OrderStateId));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository
                .GetAll()
                .Select(x => new CustomerOrderModel(x.Id, x.UserId, x.OperationTime, x.OrderStateId));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new CustomerOrderModel(res.Id, res.UserId, res.OperationTime,res.OrderStateId);
        }
        public void Update(AbstractModel model)
        {
            var x = (CustomerOrderModel)model;
            repository.Update(new CustomerOrder(x.Id, x.OperationTime, x.UserId, x.OrderStateId));
        }
    }
}
