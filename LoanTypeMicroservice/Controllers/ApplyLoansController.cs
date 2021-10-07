using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoanTypeMicroservice.Models;

namespace LoanTypeMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplyLoansController : ControllerBase
    {
        private readonly LoanTypeDbContext _context;

        public ApplyLoansController(LoanTypeDbContext context)
        {
            _context = context;
        }

        // GET: api/ApplyLoans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplyLoan>>> GetApplyLoans()
        {
            return await _context.ApplyLoans.ToListAsync();
        }

        // GET: api/ApplyLoans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplyLoan>> GetApplyLoan(int id)
        {
            var applyLoan = await _context.ApplyLoans.FindAsync(id);

            if (applyLoan == null)
            {
                return NotFound();
            }

            return applyLoan;
        }

        // PUT: api/ApplyLoans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplyLoan(int id, ApplyLoan applyLoan)
        {
            if (id != applyLoan.Id)
            {
                return BadRequest();
            }

            _context.Entry(applyLoan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplyLoanExists(id))
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

        // POST: api/ApplyLoans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplyLoan>> PostApplyLoan(ApplyLoan applyLoan)
        {
            _context.ApplyLoans.Add(applyLoan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplyLoan", new { id = applyLoan.Id }, applyLoan);
        }

        // DELETE: api/ApplyLoans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplyLoan(int id)
        {
            var applyLoan = await _context.ApplyLoans.FindAsync(id);
            if (applyLoan == null)
            {
                return NotFound();
            }

            _context.ApplyLoans.Remove(applyLoan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplyLoanExists(int id)
        {
            return _context.ApplyLoans.Any(e => e.Id == id);
        }
    }
}
