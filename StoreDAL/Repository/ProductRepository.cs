using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Data.InitDataFactory;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository
{
    public class ProductRepository : AbstractRepository, IProductRepository
    {
        private readonly DbSet<Product> dbSet;
        public ProductRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<Product>();
        }
        public void Add(Product entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Product entity)
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

        public IEnumerable<Product> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<Product> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Take(rowCount).ToList();
        }

        public Product GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Product entity)
        {
            var product = dbSet.Find(entity.Id);
            if (product == null)
                Add(product);
            else
            {
                dbSet.Remove(product);
                context.SaveChanges();
                product.Manufacturer = entity.Manufacturer;
                product.ManufacturerId = entity.ManufacturerId;
                product.UnitPrice = entity.UnitPrice;
                product.OrderDetails = entity.OrderDetails;
                product.Description = entity.Description;
                product.Title = entity.Title;
                product.TitleId = entity.TitleId;
                dbSet.Add(product);
                context.SaveChanges();
            }
        }
    }
}