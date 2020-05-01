using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace T1809E.SEM3.P102_Team05.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Thumbnail { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public int InStock { get; set; }
        [ForeignKey("OrderDetail")]
        public string OrderDetailID { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public OrderStatus Status { get; set; }

    }

    public enum OrderStatus
    {
        ACTIVE = 0,
        DISABLE = 1,
        OUT_OF_STOCK = -1,
        DELETED = -2
    }
}