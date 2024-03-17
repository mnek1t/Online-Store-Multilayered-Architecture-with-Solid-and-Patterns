using StoreDAL.Data.InitDataFactory;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repository
{
    public class ProductTitleRepository : AbstractRepository, IProductTitleRepository
    {
        private readonly DbSet<ProductTitle> dbSet;
        public ProductTitleRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<ProductTitle>();
        }
        public void Add(ProductTitle entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(ProductTitle entity)
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

        public IEnumerable<ProductTitle> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<ProductTitle> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Take(rowCount).ToList();
        }

        public ProductTitle GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(ProductTitle entity)
        {
            var product_title = dbSet.Find(entity.Id);
            if (product_title == null)
                Add(product_title);
            else
            {
                dbSet.Remove(product_title);
                context.SaveChanges();
                product_title.Products = entity.Products;
                product_title.Category = entity.Category;
                product_title.CategoryId = entity.CategoryId;
                product_title.Title = entity.Title;
                dbSet.Add(product_title);
                context.SaveChanges();
            }
        }
    }
}
