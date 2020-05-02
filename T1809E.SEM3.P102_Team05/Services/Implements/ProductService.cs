using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T1809E.SEM3.P102_Team05.Commons;
using T1809E.SEM3.P102_Team05.Data;
using T1809E.SEM3.P102_Team05.Models;
using T1809E.SEM3.P102_Team05.Repositories;

namespace T1809E.SEM3.P102_Team05.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepo;
        private readonly AppDatabaseContext _db;

        public ProductService(ProductRepository repo)
        {
            this._productRepo = repo;
            this._db = new AppDatabaseContext();
        }

        public Product Add(Product entity)
        {
            return _productRepo.Add(entity);
        }

        public Product Delete(Product entity)
        {
            return _productRepo.Delete(entity);
        }

        public Product Delete(int id)
        {
            return _productRepo.Delete(id);
        }

        public void Update(Product entity)
        {
            _productRepo.Update(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepo.GetAll();
        }

        public async Task<Product> FindById(int id)
        {
            return await _productRepo.FindById(id);
        }

        public IEnumerable<Product> GetListWithSearchAndPaging(string keyword, string sortType, string sortBy,
          int pageNumber, int pageSize)
        {
          bool isAscending;
          string columnName;
          IEnumerable<Product> products;
          Validator.ValidatePageArgs(keyword, sortType, sortBy, pageNumber, pageSize);

          isAscending = sortType.Equals("asc") ? true : false;

          columnName = sortBy.Equals("name") ? "Name" : sortBy.Equals("price") ? "Price" : "CreatedAt";

          if (string.IsNullOrEmpty(keyword))
          {
            products = _productRepo.GetMultiPaging(_productRepo
              .QueryOrder(null, columnName, isAscending), sortBy, pageNumber, pageSize);
          }
          else
          {
            products = _productRepo.GetMultiPaging(_productRepo
              .QueryOrder(x => x.Name.Contains(keyword), columnName, isAscending), sortBy, pageNumber, pageSize);
          }

          return products;
        }

        public int GetTotalItem(string keyword)
        {
          if (string.IsNullOrEmpty(keyword))
          {
            return _db.Products.Count();
          }
          else
          {
            return _db.Products.Where(p => p.Name.Contains(keyword)).ToList().Count();
          }

        }

    }
}