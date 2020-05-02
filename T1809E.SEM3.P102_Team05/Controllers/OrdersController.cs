using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PagedList;
using T1809E.SEM3.P102_Team05.Commons;
using T1809E.SEM3.P102_Team05.Data;
using T1809E.SEM3.P102_Team05.Models;
using T1809E.SEM3.P102_Team05.Models.ModelRequires;

namespace T1809E.SEM3.P102_Team05.Controllers
{
    public class OrdersController : ApiController
    {
        private AppDatabaseContext db = new AppDatabaseContext();

        // GET: api/Orders
        public IHttpActionResult GetOrders(string keyword, string sortType, string sortBy, int? pageNumber, int? pageSize)
        {
          var orders = db.Orders.ToList();
          if (Validator.ValidatePageArgs(keyword, sortType, sortBy, pageNumber.Value, pageSize.Value))
          {
            if (sortType.Equals("desc"))
            {
              switch (sortBy)
              {
                case "customerId":
                  orders = orders.OrderByDescending(o => o.CustomerId).ToList();
                  break;
                case "total":
                  orders = orders.OrderByDescending(o => o.Total).ToList();
                  break;
                case "createdAt":
                  orders = orders.OrderByDescending(o => o.CreatedAt).ToList();
                  break;
                default:
                  break;
              }
            }
            else
            {
              switch (sortBy)
              {
                case "customerId":
                  orders = orders.OrderBy(o => o.CustomerId).ToList();
                  break;
                case "total":
                  orders = orders.OrderBy(o => o.Total).ToList();
                  break;
                case "createdAt":
                  orders = orders.OrderBy(o => o.CreatedAt).ToList();
                  break;
                default:
                  break;
              }
            }
          }
          orders = orders.Where(o => o.ShippingAddress.Contains(keyword)).ToList();
          var responseModel = new ResponseModel<Order>()
          {
            Items = orders.ToPagedList(pageNumber.Value, pageSize.Value).AsQueryable(),
            TotalItems = orders.Count()
          };
          return Ok(responseModel);
        }


        // GET: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> GetOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // GET: api/Orders
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrderByCustomerId(int customerId)
        {
          var order = db.Orders.Where(o =>  o.CustomerId==customerId).ToList();
          if (order.Count==0)
          {
            return NotFound();
          }

          return Ok(order);
        }

        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderId)
            {
                return BadRequest();
            }

            db.Entry(order).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = order.OrderId }, order);
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> DeleteOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.OrderId == id) > 0;
        }
    }
}