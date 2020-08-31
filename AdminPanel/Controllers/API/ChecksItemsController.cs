using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AdminPanel.Dtos;
using AdminPanel.Models;
using AdminPanel.ViewModels;

namespace AdminPanel.Controllers.API
{
    public class ChecksItemsController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/ChecksItems
        public IQueryable<ChecksItem> GetChecksItems()
        {
            return _context.ChecksItems;
        }

        // GET: api/ChecksItems/5
        //[ResponseType(typeof(ChecksItem))]
        public OrderViewModel GetChecksItem(long id) // this id is for order
        {
            //get chekItems based on order id
            var order = _context.Orders
                .Include(o => o.User)
                .Include(o => o.User.Outlet)
                .Include(o => o.User.Area)
                .SingleOrDefault(o => o.Id == id);

            if (order == null)
            {
                //return NotFound();
            }

            var checkItems = _context.ChecksItems
                .Include(ch=>ch.Item)
                .Where(ch => ch.Check_ID == order.CheckId &&ch.Fired==true &&
                             ch.Status!= "Aborted").ToList();

            var orderViewModel = new OrderViewModel(order , checkItems);
            return orderViewModel;
        }

        // PUT: api/ChecksItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChecksItem(long id, ChecksItem checksItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != checksItem.Check_ID)
            {
                return BadRequest();
            }

            _context.Entry(checksItem).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChecksItemExists(id))
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

        // POST: api/ChecksItems
        [ResponseType(typeof(ChecksItem))]
        public IHttpActionResult PostChecksItem(CartItemDto cartItemDto)//(ChecksItem checksItem)
        {
            var ch = _context.ChecksItems
                .Where(ce => ce.Check_ID == cartItemDto.CheckId)
                .OrderByDescending(ce => ce.Serial)
                .FirstOrDefault();
            var serial = 1;
            var serialFirstItem = 1;
            if (ch != null)
            {
                serial = ch.Serial + 1;
                serialFirstItem = serial;
            }

            var item = _context.Items
                .SingleOrDefault(e => e.Id == cartItemDto.ItemId);
            var price = item.StaticPrice ;
            var tPrice = price * cartItemDto.Quantity;

            // main item
            var checkItem = new ChecksItem(cartItemDto.CheckId, cartItemDto.ItemId, cartItemDto.Quantity,
                price, tPrice, 0, 0,
                0, tPrice, serial, true, false,
                "Preparing", false, 0);

            _context.ChecksItems.Add(checkItem);
            _context.SaveChanges();

            double? totalPrice = _context.ChecksItems
                .Where(c => c.Check_ID == cartItemDto.CheckId)
                .Sum(c => c.TotalPrice);


            // here we need to update order based on new add item
            var order = _context.Orders
                .SingleOrDefault(o => o.CheckId == checkItem.Check_ID);
            order.Update(totalPrice);

            //special message from customer
            if (cartItemDto.Details != "")
            {
                var checkItem2 = new ChecksItem(cartItemDto.CheckId, cartItemDto.ItemId, 0,
                    0, 0, 0, 0,
                    0, 0, serial + 1, true, false,
                    cartItemDto.Details, true, serialFirstItem);
                serial++;
                _context.ChecksItems.Add(checkItem2);
            }



            if (cartItemDto.ItemsId[0] != -1)
            {
                //add modified items
                foreach (var id in cartItemDto.ItemsId)
                {
                    if (id == -1)
                        continue;
                    serial++;
                    checkItem = new ChecksItem(cartItemDto.CheckId, id, cartItemDto.Quantity,
                        0, 0, 0, 0,
                        0, 0, serial, true, false,
                        "Preparing", true, serialFirstItem);
                    _context.ChecksItems.Add(checkItem);
                }
            }



            // we should update order price based on new added check item

            _context.ChecksItems.Add(checkItem);
            _context.SaveChanges();


            return Ok(checkItem);
        }

        // DELETE: api/ChecksItems/5
        //[ResponseType(typeof(ChecksItem))]
        [Route("api/ChecksItems/{id:long}/{serial:int}")]
        public IHttpActionResult DeleteChecksItem(long id , int serial)
        {
            //var checksItems = _context.ChecksItems
            //    .Where(ch => ch.Check_ID == id).ToList();

            var checkItems = _context.ChecksItems
                .Where(ch => ch.Check_ID == id && 
                             (ch.Serial == serial || ch.Ref_Mod_Item == serial))
                .ToList();

            //ChecksItem checksItem = _context.ChecksItems
            //    .SingleOrDefault(ch => ch.Check_ID == id && ch.Serial == serial);

            //if (checksItem == null)
            //{
            //    return NotFound();
            //}



            foreach (var checksItem in checkItems)
            {
                _context.ChecksItems.Remove(checksItem);

            }

            _context.SaveChanges();

            double? totalPrice = _context.ChecksItems
                .Where(c => c.Check_ID == id)
                .Sum(c => c.TotalPrice);


            // here we need to update order based on new add item
            var order = _context.Orders
                .SingleOrDefault(o => o.CheckId == id);
            order.Update(totalPrice);
            _context.SaveChanges();
            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChecksItemExists(long id)
        {
            return _context.ChecksItems.Count(e => e.Check_ID == id) > 0;
        }
    }
}