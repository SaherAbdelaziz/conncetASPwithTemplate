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
        public IEnumerable<CartItem> Get()
        {
            var userId = User.Identity.GetUserId();


            var items = _context.CartItems
                .Where(c => c.CartId == userId && !c.Removed)
                .Include(c => c.Item).ToList();

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
        public CartItem PostModefiers(CartItemDto cartItemDto)
        {
            var shoppingCartId = User.Identity.GetUserId();
            var cartItem = _context.CartItems.SingleOrDefault(
                c => c.CartId == shoppingCartId && c.ItemId == cartItemDto.ItemId);
            if (cartItemDto.ItemsId != -1)
            {
                var item = _context.Items.FirstOrDefault(i => i.Id == cartItemDto.ItemsId);
                if (cartItem == null)
                {
                    // Create a new cart item if no cart item exists.                 
                    cartItem = new CartItem
                    {
                        ItemId = cartItemDto.ItemId,
                        CartId = shoppingCartId,
                        Quantity = 1,
                        DateCreated = DateTime.Now,
                        Details = cartItemDto.Details,
                        Items = { cartItemDto.ItemsId }
                    };

                    _context.CartItems.Add(cartItem);
                }
                else
                    cartItem.Quantity++;

            }

            else
            {

                if (cartItem == null)
                {
                    // Create a new cart item if no cart item exists.                 
                    cartItem = new CartItem
                    {
                        ItemId = cartItemDto.ItemId,
                        CartId = shoppingCartId,
                        Quantity = 1,
                        DateCreated = DateTime.Now
                    };

                    _context.CartItems.Add(cartItem);
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
