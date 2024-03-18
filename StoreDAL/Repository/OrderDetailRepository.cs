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
    public class OrderDetailRepository : AbstractRepository, IOrderDetailRepository
    {
        private readonly DbSet<OrderDetail> dbSet;
        public OrderDetailRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<OrderDetail>();
        }
        public void Add(OrderDetail entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(OrderDetail entity)
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

        public IEnumerable<OrderDetail> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<OrderDetail> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Take(rowCount).ToList();
        }

        public OrderDetail GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(OrderDetail entity)
        {
            var orderDetail = dbSet.Find(entity.Id);
            if (orderDetail == null)
                Add(orderDetail);
            else
            {
                dbSet.Remove(orderDetail);
                context.SaveChanges();
                orderDetail.Order = entity.Order;
                orderDetail.Price = entity.Price;
                orderDetail.ProductId = entity.ProductId;
                orderDetail.ProductAmount = entity.ProductAmount;
                orderDetail.Product = entity.Product;
                orderDetail.OrderId = entity.OrderId;
                dbSet.Add(orderDetail);
                context.SaveChanges();
            }
        }
    }
}
