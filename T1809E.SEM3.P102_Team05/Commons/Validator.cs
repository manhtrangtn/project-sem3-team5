using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T1809E.SEM3.P102_Team05.Commons
{
    public class Validator
    {
      public static bool ValidatePageArgs(string keyword, string sortType, string sortBy, int pageNumber, int pageSize)
      {
        if (!string.IsNullOrEmpty(sortType))
        {
          if (!sortType.Equals("asc") && !sortType.Equals("desc"))
          {
            return false;
          }
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
          if (!sortBy.Equals("name") && !sortBy.Equals("price") && !sortBy.Equals("createdDate"))
          {
            return false;
          }
        }

        else if (pageSize <= 0 || pageNumber <= 0)
        {
          return false;
        }

        return true;
      }

    }
}