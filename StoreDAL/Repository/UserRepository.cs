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
using System.Security.Cryptography;

namespace StoreDAL.Repository
{
    public class UserRepository : AbstractRepository, IUserRepository
    {
        private readonly DbSet<User> dbSet;
        public UserRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<User>();
        }
        public void Add(User entity)
        {
            string hashedPassword = EncryptPassword(entity.Password);
            entity.Password = hashedPassword;

            dbSet.Add(entity);
            context.SaveChanges();
        }
        public void Delete(User entity)
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
        public IEnumerable<User> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<User> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Take(rowCount).ToList();
        }

        public User GetById(int id)
        {
            return dbSet.Find(id);
        }
        public void Update(User entity)
        {
            var user = dbSet.Find(entity.Id);
            if (user == null)
                Add(user);
            else 
            {
                dbSet.Remove(user);
                context.SaveChanges();
                user.Role = entity.Role;
                user.Login = entity.Login;
                user.Name = entity.Name;
                user.LastName = entity.LastName;
                user.Password = EncryptPassword(entity.Password);
                user.Order = entity.Order;
                dbSet.Add(user);
                context.SaveChanges();
            }
        }
        private string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
