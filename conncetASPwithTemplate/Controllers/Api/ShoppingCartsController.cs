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

            var OutLetId = User.Identity.GetUserOutletId();
            var HdAreasId = User.Identity.GetUserAreaId();
            double? delivery = _context.HdAreasServices
                .SingleOrDefault(h => h.AreaId == HdAreasId && h.OutLetId == OutLetId).Services;


            
                var cartItem = _context.MyCartItems.SingleOrDefault(
                c => c.ShoppingCartId == Cart.Id && c.EldahanItemId 
                    == cartItemDto.ItemId && !c.Removed);

                if (cartItemDto.ItemsId[0] == -1)
                {
                    //var item = _context.Items.FirstOrDefault(i => i.Id == cartItemDto.ItemsId);
                    if (cartItem == null)
                    {
                        // Create a new cart item if no cart item exists.                 
                        cartItem = new MyCartItem()
                        {
                            EldahanItemId = cartItemDto.ItemId,
                            ShoppingCartId = Cart.Id,
                            Quantity = cartItemDto.Quantity,
                            DateCreated = DateTime.Now,
                            Details = cartItemDto.Details,
                            Delivery = (double)delivery
                        };

                        _context.MyCartItems.Add(cartItem);
                    }
                    else
                        cartItem.Quantity++;

                }

                else
                {
                    if (cartItem == null)
                    {
                        // Create a new cart item if no cart item exists.                 
                        cartItem = new MyCartItem()
                        {
                            EldahanItemId = cartItemDto.ItemId,
                            ShoppingCartId = Cart.Id,
                            Quantity = 1,
                            DateCreated = DateTime.Now,
                            Details = cartItemDto.Details,
                            Delivery = (double)delivery,
                            HasModifiers = true,
                            //OrderId = 1
                        };

                        var selectedModifiers =
                            new SelectedModifiers(cartItemDto.ItemId,
                                Cart.ApplicationUserId, cartItemDto.ItemsId[0]);


                        _context.MyCartItems.Add(cartItem);
                        _context.SelectedModifiers.Add(selectedModifiers);
                    }
                    else
                        cartItem.Quantity++;
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
