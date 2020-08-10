using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using conncetASPwithTemplate.Dtos;
using conncetASPwithTemplate.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
namespace conncetASPwithTemplate.Controllers.Api
{
    [Authorize]
    public class ShoppingCartsController : ApiController
    {
        public string UserId;
        private ApplicationDbContext _context;
        public Cart Cart { get; set; }

        public ShoppingCartsController()
        {
           _context = new ApplicationDbContext();
           UserId = User.Identity.GetUserId();
           Cart =  _context.Carts
                .SingleOrDefault(c => c.ApplicationUserId == UserId);
           if (Cart == null)
           {
               Cart = new Cart()
               {
                   ApplicationUserId = UserId
               };
               _context.Carts.Add(Cart);
                _context.SaveChanges();
           }
        }

        // GET: api/ShoppingCarts
        public IEnumerable<MyCartItem> Get()
        {
          var items = _context.MyCartItems
            .Where(c => c.ShoppingCartId == Cart.Id && !c.Removed && !c.Ordered)
            .Include(c => c.EldahanItem).ToList();


          return items;
        }

        // GET: api/ShoppingCarts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ShoppingCarts
        [HttpPost]
        public MyCartItem Post(CartItemDto cartItemDto)
        {


            var userId = User.Identity.GetUserId();
            var outLetId = User.Identity.GetUserOutletId();
            var hdAreasId = User.Identity.GetUserAreaId();
            double? delivery = _context.HdAreasServices
                .SingleOrDefault(h => h.AreaId == hdAreasId && h.OutLetId == outLetId).Services;

           

            var check = _context.Checks
                .SingleOrDefault(c => c.Cust_ID == userId && c.MyStatus=="Open");

            if (check == null)
            {
                // create new check with custom id 
                var modelCheck = _context.Checks.OrderByDescending(c => c.ID).FirstOrDefault();
                long checkId;
                var modelCheckIdArea = 1 * 100000000000;
                var modelCheckIdOutlet = outLetId * 100000000;
                var modelCheckIdOutletStation = 88000000;
                var modelCheckId = 0;
                if (modelCheck != null)
                {
                    modelCheckId = (int)(modelCheck.ID % 1000000);
                    checkId = modelCheckIdArea + modelCheckIdOutlet + modelCheckId + modelCheckIdOutletStation + 1;
                }
                else
                {
                    checkId = modelCheckIdArea + modelCheckIdOutlet + modelCheckIdOutletStation + 1;

                }
                check = new Check(
                    checkId, (int)(modelCheckId + 1), (modelCheckId + 1).ToString(),
                    "web", 0, "0", "Open", false, 0, DateTime.Now, DateTime.Now, null, userId, 0, 0,
                    0, outLetId, 0, 88, DateTime.Now, null, 0, 0, false, null, 0, 0, false,
                    0, 0, 0, 0, false, 0, 0, false, null, 0, 0, 0, 0, false, null, false, 0,
                    "", false, false, ""
                );



                _context.Checks.Add(check);
            }

            else
            {
                
            }


            MyCartItem cartItem;
            var ch = _context.ChecksItems
                .Where(ce => ce.Check_ID == check.ID)
                .OrderByDescending(ce => ce.Serial)
                .FirstOrDefault();
            var serial = 1;
            if (ch != null)
                serial = ch.Serial+1;


            if (cartItemDto.ItemsId[0] == -1)
            {
                // Create a new cart item                
                cartItem = new MyCartItem()
                {
                    EldahanItemId = cartItemDto.ItemId,
                    ShoppingCartId = Cart.Id,
                    Quantity = cartItemDto.Quantity,
                    DateCreated = DateTime.Now,
                    Details = cartItemDto.Details,
                    Delivery = (double)delivery
                };

                var item = _context.EldahanItems
                    .SingleOrDefault(e => e.Id == cartItemDto.ItemId);
                var total = item.StaticPrice + cartItem.Delivery;

                var checkItem = new ChecksItem(check.ID, cartItemDto.ItemId, cartItemDto.Quantity,
                    item.StaticPrice, total, 0, 0,
                    0, total, serial,"Opend", false);

                _context.MyCartItems.Add(cartItem);
                

                _context.ChecksItems.Add(checkItem);

            }

            else
            {
                // Create a new cart item                  
                cartItem = new MyCartItem()
                {
                    EldahanItemId = cartItemDto.ItemId,
                    ShoppingCartId = Cart.Id,
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    Details = cartItemDto.Details,
                    Delivery = (double)delivery,
                    HasModifiers = true,
                };
              

                ChecksItem checkItem = null;
                //add basic item
                var item = _context.EldahanItems
                    .SingleOrDefault(e => e.Id == cartItemDto.ItemId);
                var total = item.StaticPrice + cartItem.Delivery;

                checkItem = new ChecksItem(check.ID, cartItemDto.ItemId, cartItemDto.Quantity,
                    item.StaticPrice, total, 0, 0,
                    0, total, serial, "Opend", false);
                _context.ChecksItems.Add(checkItem);
                //add modified items
                for (var index = 0; index < cartItemDto.ItemsId.Count; index++)
                {
                    serial++;
                    var id = cartItemDto.ItemsId[index];
                    if (id == -1)
                        continue;
                    
                    //item = _context.EldahanItems
                        //.SingleOrDefault(e => e.Id == id);
                   // total = item.StaticPrice + cartItem.Delivery;


                    checkItem = new ChecksItem(check.ID, id, cartItemDto.Quantity,
                        0, 0, 0, 0,
                        0, 0, serial , "Opend", true);
                    _context.ChecksItems.Add(checkItem);
                }


                _context.MyCartItems.Add(cartItem);
                


            }

            _context.SaveChanges();
            return cartItem;
        }
       
        // PUT: api/ShoppingCarts/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // here we get all cart items and set its order id to orderId
        //public void Put()
        //{

        //    var cartItmes = _context.MyCartItems.ToList();
        //    var order = _context.Orders.OrderByDescending(o => o.Id).FirstOrDefault();

        //    foreach (var cartItme in cartItmes)
        //    {
        //        if(cartItme.ShoppingCartId == Cart.Id && !cartItme.Removed)
        //        {
        //            cartItme.OrderId = order.Id;
        //            cartItme.Ordered = true;
        //            cartItme.Removed = true;
        //        }
        //    }

        //    _context.SaveChanges();
        //}

        // DELETE: api/ShoppingCarts/5
        public IHttpActionResult Delete(int id)
        {
            var cartItem = _context.MyCartItems
                .Single(c => c.Id == id && c.ShoppingCartId == Cart.Id);

            if (cartItem.Removed)
                return Ok();

            cartItem.Removed = true;
            _context.MyCartItems.Remove(cartItem);

            _context.SaveChanges();

            return Ok();
        }
    }
}
