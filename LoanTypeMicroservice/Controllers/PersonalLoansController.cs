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
    public class PersonalLoansController : ControllerBase
    {
        private readonly LoanTypeDbContext _context;

        public PersonalLoansController(LoanTypeDbContext context)
        {
            _context = context;
        }

        // GET: api/PersonalLoans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalLoan>>> GetPersonalLoans()
        {
            return await _context.PersonalLoans.ToListAsync();
        }

        // GET: api/PersonalLoans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalLoan>> GetPersonalLoan(int id)
        {
            var personalLoan = await _context.PersonalLoans.FindAsync(id);

            if (personalLoan == null)
            {
                return NotFound();
            }

            return personalLoan;
        }

        // PUT: api/PersonalLoans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalLoan(int id, PersonalLoan personalLoan)
        {
            if (id != personalLoan.UserId)
            {
                return BadRequest();
            }

            _context.Entry(personalLoan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalLoanExists(id))
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

        // POST: api/PersonalLoans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonalLoan>> PostPersonalLoan(PersonalLoan personalLoan)
        {
            _context.PersonalLoans.Add(personalLoan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalLoan", new { id = personalLoan.UserId }, personalLoan);
        }

        // DELETE: api/PersonalLoans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalLoan(int id)
        {
            var personalLoan = await _context.PersonalLoans.FindAsync(id);
            if (personalLoan == null)
            {
                return NotFound();
            }

            _context.PersonalLoans.Remove(personalLoan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonalLoanExists(int id)
        {
            return _context.PersonalLoans.Any(e => e.UserId == id);
        }
    }
}
