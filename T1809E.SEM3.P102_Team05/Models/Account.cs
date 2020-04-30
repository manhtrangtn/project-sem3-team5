using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace T1809E.SEM3.P102_Team05.Models
{
    public class Account: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public AccountStatus Status { get; set; }
    }
    public enum AccountStatus
    {
        ACTIVE = 0,
        DISABLE = 1,
        DELETED = -1
    }
}