using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using films.Models;

namespace films.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmGenresController : ControllerBase
    {
        private readonly FilmsContext _context;

        public FilmGenresController(FilmsContext context)
        {
            _context = context;
        }

        // GET: api/FilmGenres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmGenre>>> GetFilmGenre()
        {
            return await _context.FilmGenre.ToListAsync();
        }

        // GET: api/FilmGenres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmGenre>> GetFilmGenre(int id)
        {
            var filmGenre = await _context.FilmGenre.FindAsync(id);

            if (filmGenre == null)
            {
                return NotFound();
            }

            return filmGenre;
        }

        // PUT: api/FilmGenres/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmGenre(int id, FilmGenre filmGenre)
        {
            if (id != filmGenre.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmGenre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmGenreExists(id))
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

        // POST: api/FilmGenres
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FilmGenre>> PostFilmGenre(FilmGenre filmGenre)
        {
            _context.FilmGenre.Add(filmGenre);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmGenre", new { id = filmGenre.Id }, filmGenre);
        }

        // DELETE: api/FilmGenres/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FilmGenre>> DeleteFilmGenre(int id)
        {
            var filmGenre = await _context.FilmGenre.FindAsync(id);
            if (filmGenre == null)
            {
                return NotFound();
            }

            _context.FilmGenre.Remove(filmGenre);
            await _context.SaveChangesAsync();

            return filmGenre;
        }

        private bool FilmGenreExists(int id)
        {
            return _context.FilmGenre.Any(e => e.Id == id);
        }
    }
}
