using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersDetailsController : ControllerBase
    {
        private readonly EcoPowerSolutionsDBContext _context;

        public OrdersDetailsController(EcoPowerSolutionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Orders/5/Products
        [HttpGet("{orderId}/Products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsForOrder(short orderId)
        {
            // Check if the order exists
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                return NotFound();
            }

            // Retrieve products for the given order
            var products = await _context.OrderDetails
                .Where(od => od.OrderId == orderId)
                .Include(od => od.Product)
                .Select(od => od.Product)
                .ToListAsync();

            if (products.Count == 0)
            {
                return NotFound("No products found for the specified order.");
            }

            return products;
        }


        private bool OrderExists(short id)
        {
            return (_context.Orders?.Any(e => e.OrderId == id)).GetValueOrDefault();
        }
    }
}
