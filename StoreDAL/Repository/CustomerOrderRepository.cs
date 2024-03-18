using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository
{
    public class CustomerOrderRepository : AbstractRepository, ICustomerOrderRepository
    {
        private readonly DbSet<CustomerOrder> dbSet;
        public CustomerOrderRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<CustomerOrder>();
        }
        public void Add(CustomerOrder entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(CustomerOrder entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<CustomerOrder> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<CustomerOrder> GetAll(int pageNumber, int rowCount)
        {
            throw new NotImplementedException();
        }

        public CustomerOrder GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(CustomerOrder entity)
        {
            var customer_order = dbSet.Find(entity.Id);
            if (customer_order == null)
                Add(customer_order);
            else
            {
                dbSet.Remove(customer_order);
                context.SaveChanges();
                customer_order.State = entity.State;
                customer_order.User = entity.User;
                customer_order.Details = entity.Details;
                customer_order.OrderStateId = entity.OrderStateId;
                dbSet.Add(customer_order);
                context.SaveChanges();
            }
        }
    }
}
