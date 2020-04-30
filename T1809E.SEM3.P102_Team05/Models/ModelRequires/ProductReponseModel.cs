using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T1809E.SEM3.P102_Team05.Models.ModelRequires
{
    public class ProductReponseModel
    {
      public IQueryable<Product> Products { get; set; }
      public int TotalItems { get; set; }
    }
}