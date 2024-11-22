using JarvisEnergy.Data;
using JarvisEnergy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JarvisEnergy.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
 
    public class RelatoriosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RelatoriosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Relatorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Relatorio>>> GetRelatorios()
        {
            return await _context.Relatorios.ToListAsync();
        }

        // GET: api/Relatorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Relatorio>> GetRelatorio(int id)
        {
            var relatorio = await _context.Relatorios.FindAsync(id);

            if (relatorio == null)
            {
                return NotFound();
            }

            return relatorio;
        }

        // PUT: api/Relatorios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRelatorio(int id, Relatorio relatorio)
        {
            if (id != relatorio.IdRelatorio)
            {
                return BadRequest();
            }

            _context.Entry(relatorio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RelatorioExists(id))
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

        // POST: api/Relatorios
        [HttpPost]
        public async Task<ActionResult<Relatorio>> PostRelatorio(Relatorio relatorio)
        {
            _context.Relatorios.Add(relatorio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRelatorio", new { id = relatorio.IdRelatorio }, relatorio);
        }

        // DELETE: api/Relatorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRelatorio(int id)
        {
            var relatorio = await _context.Relatorios.FindAsync(id);
            if (relatorio == null)
            {
                return NotFound();
            }

            _context.Relatorios.Remove(relatorio);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool RelatorioExists(int id)
        {
            return _context.Relatorios.Any(e => e.IdRelatorio == id);
        }
    }
}