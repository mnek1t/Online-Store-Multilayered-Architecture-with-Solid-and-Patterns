using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Repository;

namespace StoreBLL.Services
{
    public class UserService : ICrud
    {
        IUserRepository repository;
        public UserService(StoreDbContext context)
        {
            repository = new UserRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (UserModel)model;
            repository.Add(new User(x.Id, x.FirstName, x.LastName, x.Login, x.Password, x.RoleId));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository
                .GetAll()
                .Select(x => new UserModel(x.Id, x.Name, x.LastName, x.Login, x.Password, x.RoleId));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new UserModel(res.Id, res.Name, res.LastName, res.Login, res.Password, res.RoleId);
        }
        public void Update(AbstractModel model)
        {
            var x = (UserModel)model;
            repository.Update(new User(x.Id, x.FirstName, x.LastName, x.Login, x.Password, x.RoleId));
        }
    }
}
