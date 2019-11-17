using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Amazon.Models;

namespace Amazon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentiController : ControllerBase
    {
        public CommentoContext _context;



        public CommentiController(CommentoContext context)
        {
            _context = context;
        }

        // GET: api/Commenti
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commento>>> GetCommento()
        {

            return await _context.Commenti.ToListAsync();
        }

        // POST: api/Commenti
        [HttpPost]

        public async Task<ActionResult<Commento>> Post(Commento commento)
        {
            _context.Commenti.Add(commento);
            await _context.SaveChangesAsync();


            return CreatedAtAction(nameof(GetCommento), new { id = commento.id }, commento);
        }



        /*public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }*/




        // PUT: api/Commenti/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        /*[HttpDelete("{id}")]
        public async Task<ActionResult<Commento>> DeleteCommento(long id)
        {
            var commento = await _context.Commenti.FindAsync(id);

            if (commento == null)
            {
                return NotFound();
            }

            _context.Commenti.Remove(commento);
            await _context.SaveChangesAsync();

            return commento;
        }*/
    }
}
