using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T1809E.SEM3.P102_Team05.Models
{
    public class Order
    {
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
    }
}