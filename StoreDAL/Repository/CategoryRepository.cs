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
    public class CategoryRepository : AbstractRepository, ICategoryRepository
    {
        private readonly DbSet<Category> dbSet;
        public CategoryRepository(StoreDbContext context) : base(context) 
        {
            dbSet = context.Set<Category>();
        }
        public void Add(Category entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Category entity)
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

        public IEnumerable<Category> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<Category> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Take(rowCount).ToList();
        }

        public Category GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Category entity)
        {
            var category = dbSet.Find(entity.Id);
            if (category == null)
                Add(category);
            else
            {
                dbSet.Remove(category);
                context.SaveChanges();
                category.Id = entity.Id;
                category.Name = entity.Name;
                category.Titles = entity.Titles;
                dbSet.Add(category);
                context.SaveChanges();
            }
        }
    }
}
