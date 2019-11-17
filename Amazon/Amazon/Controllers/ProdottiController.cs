using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace TodoApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottiController : ControllerBase
    {
        public ProdottoContext _context;


        public ProdottiController(ProdottoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prodotto>>> GetProdotti()
        {

            return await _context.Prodotti.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prodotto>> GetProdotto(long id)
        {

            var prodotto = await _context.Prodotti.FindAsync(id);

            if (prodotto == null)
            {
                return NotFound();
            }


            return prodotto;
        }

        // PUT: api/PutTodoItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdotto(long id, [FromBody]Prodotto prodotto)
        {
            if (id != prodotto.Id)
            {
                return BadRequest();
            }

            _context.Entry(prodotto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdottoExists(id))
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

        // POST: api/TodoItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.

        [HttpPost]
        public async Task<ActionResult<Prodotto>> PostProdotto(Prodotto prodotto)
        {
            _context.Prodotti.Add(prodotto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProdotto), new { id = prodotto.Id }, prodotto);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Prodotto>> DeleteProdotto(long id)
        {
            var prodotto = await _context.Prodotti.FindAsync(id);

            if (prodotto == null)
            {
                return NotFound();
            }

            _context.Prodotti.Remove(prodotto);
            await _context.SaveChangesAsync();

            return prodotto;
        }

        private bool ProdottoExists(long id)
        {
            return _context.Prodotti.Any(e => e.Id == id);
        }
    }
}
