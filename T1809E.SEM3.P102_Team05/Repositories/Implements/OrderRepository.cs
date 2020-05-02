using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T1809E.SEM3.P102_Team05.Data;
using T1809E.SEM3.P102_Team05.Models;

namespace T1809E.SEM3.P102_Team05.Repositories.Implements
{
    public class OrderRepository : CommonRepository<Order>
    {
      private AppDatabaseContext db;

      protected OrderRepository(AppDatabaseContext db):base(db)
      {
        this.db = db;
      }


    }
}