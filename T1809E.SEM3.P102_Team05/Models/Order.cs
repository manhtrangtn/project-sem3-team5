using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> Stashed changes
using System.Linq;
using System.Web;

namespace T1809E.SEM3.P102_Team05.Models
{
    public class Order
    {
<<<<<<< Updated upstream
        [Key]
        public int OrderId { get; set; }
        public int CustomerID { get; set; }
        public double OrderNumber { get; set; }
        public string ShippingAddress { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public OrderStatus1 Status { get; set; }
    }
    public enum OrderStatus1
    {
        ACTIVE = 0,
        DISABLE = 1,
        DELETED = -1
=======
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public string ShipAddress { get; set; }
        public double Total { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        
    }
    public enum OrderStatus1
    {
        UNPAID = 0,
        CANCELED = 1,
        DELETED = 2,
        DONE =  3,
        PAID = 4,
        SHIPPING=5,
>>>>>>> Stashed changes
    }
}