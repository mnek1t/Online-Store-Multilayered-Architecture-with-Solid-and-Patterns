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
    public class ProductTitleService : ICrud
    {
        IProductTitleRepository repository;
        public ProductTitleService(StoreDbContext context)
        {
            repository = new ProductTitleRepository(context);
        }

        public void Add(AbstractModel model)
        {
            var x = (ProductTitleModel)model;
            repository.Add(new ProductTitle(x.Id, x.Title, x.CategoryId));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new ProductTitleModel(x.Id, x.Title, x.CategoryId));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new ProductTitleModel(res.Id, res.Title, res.CategoryId);
        }
        public void Update(AbstractModel model)
        {
            var x = (ProductTitleModel)model;
            repository.Update(new ProductTitle(x.Id, x.Title, x.CategoryId));
        }
    }
}
