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
    public class ProductService : ICrud
    {
        IProductRepository repository;
        public ProductService(StoreDbContext context)
        {
            repository = new ProductRepository(context);
        }

        public void Add(AbstractModel model)
        {
            var x = (ProductModel)model;
            repository.Add(new Product(x.Id, x.TitleId, x.ManufacturerId, x.Description, x.UnitPrice));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new ProductModel(x.Id, x.TitleId, x.ManufacturerId, x.Description, x.UnitPrice));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new ProductModel(res.Id, res.TitleId, res.ManufacturerId, res.Description, res.UnitPrice);
        }
        public void Update(AbstractModel model)
        {
            var x = (ProductModel)model;
            repository.Update(new Product(x.Id, x.TitleId, x.ManufacturerId, x.Description, x.UnitPrice));
        }
    }
}
