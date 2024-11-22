using JarvisEnergy.Data;
using JarvisEnergy.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JarvisEnergy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EnderecosUsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EnderecosUsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/EnderecosUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnderecoUsuario>>> GetEnderecosUsuarios()
        {
            return await _context.EnderecosUsuarios.ToListAsync();
        }

        // GET: api/EnderecosUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnderecoUsuario>> GetEnderecoUsuario(int id)
        {
            var enderecoUsuario = await _context.EnderecosUsuarios.FindAsync(id);

            if (enderecoUsuario == null)
            {
                return NotFound();
            }

            return enderecoUsuario;
        }

        // PUT: api/EnderecosUsuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnderecoUsuario(int id, EnderecoUsuario enderecoUsuario)
        {
            if (id != enderecoUsuario.IdEndereco)
            
            {
                return BadRequest();
            }

            _context.Entry(enderecoUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoUsuarioExists(id))
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

        // POST: api/EnderecosUsuarios
        [HttpPost]
        public async Task<ActionResult<EnderecoUsuario>> PostEnderecoUsuario(EnderecoUsuario enderecoUsuario)
        {
            _context.EnderecosUsuarios.Add(enderecoUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnderecoUsuario", new { id = enderecoUsuario.IdEndereco}, enderecoUsuario);
        }

        // DELETE: api/EnderecosUsuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnderecoUsuario(int id)
        {
            var enderecoUsuario = await _context.EnderecosUsuarios.FindAsync(id);
            if (enderecoUsuario == null)
            {
                return NotFound();
            }

            _context.EnderecosUsuarios.Remove(enderecoUsuario);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool EnderecoUsuarioExists(int id)
        {
            return _context.EnderecosUsuarios.Any(e => e.IdEndereco == id);
        }
    }
}