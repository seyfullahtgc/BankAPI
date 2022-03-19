using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankAPI.Data;
using BankAPI.Model;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        private readonly BankAPIDBContext _context;

        public CustomerOrderController(BankAPIDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerOrder>>> GetCustumerOrders()
        {
            return await _context.CustumerOrders.Include(a=>a.Customer).ThenInclude(a=>a.Addresses).Include(a=>a.Product).ToListAsync();
        }

        
        [HttpDelete("{CustomerID}/{ProductID}")]
        public async Task<IActionResult> DeleteCustomerOrder(int CustomerID, int ProductID)
        {
            CustomerOrder customerOrder = await _context.CustumerOrders.FirstOrDefaultAsync(a => a.CustomerID == CustomerID && a.ProductID == ProductID);
            if (customerOrder == null)
            {
                return NotFound();
            }

            _context.CustumerOrders.Remove(customerOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

      
        [HttpPost]
        public async Task<ActionResult<CustomerOrder>> PostCustomerOrder(CustomerOrder customerOrder)
        {
            _context.CustumerOrders.Add(customerOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerOrder", new { id = customerOrder.CustomerOrderId }, customerOrder);
        }
       

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerOrder(int id, CustomerOrder customerOrder)
        {
            if (id != customerOrder.CustomerOrderId)
            {
                return BadRequest();
            }

            _context.Entry(customerOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerOrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool CustomerOrderExists(int id)
        {
            return _context.CustumerOrders.Any(e => e.CustomerOrderId == id);
        }


    }
}
