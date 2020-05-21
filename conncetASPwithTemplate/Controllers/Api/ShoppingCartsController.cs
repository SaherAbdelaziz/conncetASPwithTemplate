using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShoppingCarts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ShoppingCarts
        public CartItem Post([FromBody]int itemId)
        {
            var shoppingCartId = User.Identity.GetUserId();
            var cartItem = _context.CartItems.SingleOrDefault(
                c => c.CartId == shoppingCartId && c.ItemId == itemId);

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItem
                {
                    ItemId = itemId,
                    CartId = shoppingCartId,
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };

                _context.CartItems.Add(cartItem);
            }
            else
                cartItem.Quantity++;

            _context.SaveChanges();

            return cartItem;
        }

        // PUT: api/ShoppingCarts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShoppingCarts/5
        public void Delete(int id)
        {
        }
    }
}
