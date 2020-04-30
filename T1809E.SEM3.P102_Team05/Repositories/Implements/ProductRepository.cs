using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using T1809E.SEM3.P102_Team05.Data;
using T1809E.SEM3.P102_Team05.Models;

namespace T1809E.SEM3.P102_Team05.Repositories
{
    public class ProductRepository : CommonRepository<Product>
    {
        private AppDatabaseContext db;
        public ProductRepository(AppDatabaseContext db) : base(db)
        {
           this.db = db;
        }


        public IQueryable<Product> QueryOrder(Expression<Func<Product, bool>> filter, string columName, bool isAscending)
        {
            IQueryable<Product> resetSet = filter != null ? db.Set<Product>().Where<Product>(filter).AsQueryable() : db.Set<Product>().AsQueryable();

            switch (columName)
            {
                case "Name":
                    resetSet = isAscending ? resetSet.OrderBy(x => x.Name).AsQueryable() : resetSet.OrderByDescending(x => x.Name).AsQueryable();
                    break;
                case "Price":
                    resetSet = isAscending ? resetSet.OrderBy(x => x.Price).AsQueryable() : resetSet.OrderByDescending(x => x.Price).AsQueryable();
                    break;
                case "CreateAt":
                    resetSet = isAscending ? resetSet.OrderBy(x => x.CreateAt).AsQueryable() : resetSet.OrderByDescending(x => x.CreateAt).AsQueryable();
                    break;
                default:
                  break;
            }
            return resetSet;
        }

    }
}