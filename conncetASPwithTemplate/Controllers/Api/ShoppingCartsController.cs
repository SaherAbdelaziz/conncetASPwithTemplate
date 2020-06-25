using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using conncetASPwithTemplate.Dtos;
using conncetASPwithTemplate.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
namespace conncetASPwithTemplate.Controllers.Api
{
    [Authorize]
    public class ShoppingCartsController : ApiController
    {

        private ApplicationDbContext _context;

        public ShoppingCartsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: api/ShoppingCarts
        public IEnumerable<MyCartItem> Get()
        {
            var userId = User.Identity.GetUserId();


            var items = _context.MyCartItems
                .Where(c => c.CartId == userId && !c.Removed)
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
        //[Route("api/ShoppingCarts/{id1}/{id2}")]
        public MyCartItem Post(CartItemDto cartItemDto)
        {
            var shoppingCartId = User.Identity.GetUserId();
            //var userId = string userId = SignInManager
            //    .AuthenticationManager
            //    .AuthenticationResponseGrant.Identity.GetUserId();
            //var user = SignInManager.UserManager.Users.FirstOrDefault(x => x.Id.Equals(userId));
            //var shoppingCartId = userId;
            var cartItem = _context.MyCartItems.SingleOrDefault(
                c => c.CartId == shoppingCartId && c.EldahanItemId == cartItemDto.ItemId && !c.Removed);
            if (cartItemDto.ItemsId[0] == -1)
            {
                //var item = _context.Items.FirstOrDefault(i => i.Id == cartItemDto.ItemsId);
                if (cartItem == null)
                {
                    // Create a new cart item if no cart item exists.                 
                    cartItem = new MyCartItem()
                    {
                        EldahanItemId = cartItemDto.ItemId,
                        CartId = shoppingCartId,
                        Quantity = 1,
                        DateCreated = DateTime.Now,
                        Details = cartItemDto.Details,
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
                        CartId = shoppingCartId,
                        Quantity = 1,
                        DateCreated = DateTime.Now,
                        HasModifiers = true,
                        //OrderId = 1
                    };

                    var selectedModifiers =
                        new SelectedModifiers(cartItemDto.ItemId, 
                            shoppingCartId, cartItemDto.ItemsId[0]);
                    

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

        public void Put()
        {
            var cartItmes = _context.MyCartItems.ToList();
            var order = _context.Orders.OrderByDescending(o => o.Id).FirstOrDefault();
            var userId = User.Identity.GetUserId();
            foreach (var cartItme in cartItmes)
            {
                if(cartItme.CartId == userId && !cartItme.Removed)
                {
                    cartItme.OrderId = order.Id;
                    cartItme.Removed = true;
                }
            }

            _context.SaveChanges();
        }

        // DELETE: api/ShoppingCarts/5
        public IHttpActionResult Delete(int id)
        {
            var userId = User.Identity.GetUserId();
            var cartItem = _context.CartItems
                .Single(c => c.Id == id && c.CartId == userId);

            if (cartItem.Removed)
                return Ok();

            cartItem.Removed = true;
            _context.CartItems.Remove(cartItem);

            _context.SaveChanges();

            return Ok();
        }
    }
}
