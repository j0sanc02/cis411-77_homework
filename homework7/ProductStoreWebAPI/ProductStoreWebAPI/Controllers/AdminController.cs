using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ProductStoreWebAPI.Models;

namespace ProductStoreWebAPI.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : ApiController
    {
        private OrdersWebAPIContext db = new OrdersWebAPIContext();

        // GET api/Admin
        public IEnumerable<ProductWebAPI> GetProductWebAPIs()
        {
            return db.ProductWebAPIs.AsEnumerable();
        }

        // GET api/Admin/5
        public ProductWebAPI GetProductWebAPI(int id)
        {
            ProductWebAPI productwebapi = db.ProductWebAPIs.Find(id);
            if (productwebapi == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return productwebapi;
        }

        // PUT api/Admin/5
        public HttpResponseMessage PutProductWebAPI(int id, ProductWebAPI productwebapi)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != productwebapi.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(productwebapi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Admin
        public HttpResponseMessage PostProductWebAPI(ProductWebAPI productwebapi)
        {
            if (ModelState.IsValid)
            {
                db.ProductWebAPIs.Add(productwebapi);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, productwebapi);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = productwebapi.Id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Admin/5
        public HttpResponseMessage DeleteProductWebAPI(int id)
        {
            ProductWebAPI productwebapi = db.ProductWebAPIs.Find(id);
            if (productwebapi == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.ProductWebAPIs.Remove(productwebapi);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, productwebapi);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}