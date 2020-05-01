using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace T1809E.SEM3.P102_Team05.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        [ForeignKey("Order")]
        public string OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}