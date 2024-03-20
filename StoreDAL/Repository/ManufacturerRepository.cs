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
    public class ManufacturerRepository : AbstractRepository, IManufacturerRepository
    {
        private readonly DbSet<Manufacturer> dbSet;
        public ManufacturerRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<Manufacturer>();
        }
        public void Add(Manufacturer entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Manufacturer entity)
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

        public IEnumerable<Manufacturer> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<Manufacturer> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Take(rowCount).ToList();
        }

        public Manufacturer GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Manufacturer entity)
        {
            var manufacturer = dbSet.Find(entity.Id);
            if (manufacturer == null)
                Add(manufacturer);
            else
            {
                dbSet.Remove(manufacturer);
                context.SaveChanges();
                manufacturer.Id = entity.Id;
                manufacturer.Name = entity.Name;
                dbSet.Add(manufacturer);
                context.SaveChanges();
            }
        }
    }
}
