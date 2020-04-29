using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace T1809E.SEM3.P102_Team05.Models
{
    public class Role:IdentityRole
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int CreateAt {get; set;}    
        public int UpdateAt {get; set;}
        public int DeleteAt {get; set;}

        enum RollStatus

        {
            ACTIVE = 0, DISABLED = 1, DELETED = -1
        }
    }
}