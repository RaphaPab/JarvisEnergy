using JarvisEnergy.Data;
using JarvisEnergy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JarvisEnergy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UsuariosDispositivosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosDispositivosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/UsuariosDispositivos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDispositivo>>> GetUsuariosDispositivos()
        {
            return await _context.UsuariosDispositivos.ToListAsync();
        }

        // GET: api/UsuariosDispositivos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDispositivo>> GetUsuarioDispositivo(int id)
        {
            var usuarioDispositivo = await _context.UsuariosDispositivos.FindAsync(id);

            if (usuarioDispositivo == null)
            {
                return NotFound();
            }

            return usuarioDispositivo;
        }

        // PUT: api/UsuariosDispositivos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarioDispositivo(int id, UsuarioDispositivo usuarioDispositivo)
        {
            if (id != usuarioDispositivo.IdUsuarioDispositivo)
            {
                return BadRequest();
            }

            _context.Entry(usuarioDispositivo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioDispositivoExists(id))
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

        // POST: api/UsuariosDispositivos
        [HttpPost]
        public async Task<ActionResult<UsuarioDispositivo>> PostUsuarioDispositivo(UsuarioDispositivo usuarioDispositivo)
        {
            _context.UsuariosDispositivos.Add(usuarioDispositivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuarioDispositivo", new { id = usuarioDispositivo.IdUsuarioDispositivo }, usuarioDispositivo);
        }

        // DELETE: api/UsuariosDispositivos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarioDispositivo(int id)
        {
            var usuarioDispositivo = await _context.UsuariosDispositivos.FindAsync(id);
            if (usuarioDispositivo == null)
            {
                return NotFound();
            }

            _context.UsuariosDispositivos.Remove(usuarioDispositivo);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool UsuarioDispositivoExists(int id)
        {
            return _context.UsuariosDispositivos.Any(e => e.IdUsuarioDispositivo == id);
        }
    }
}