using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParkController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public ParkController(ParkApiContext db)
    {
      _db = db;
    }

    // GET: api/Park
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> Get(string name, string director, string genre, string synopsis, int rottenTom)
    {
      var query = _db.Movies.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (director != null)
      {
        query = query.Where(entry => entry.Director == director);
      }    

      if (genre != null)
      {
        query = query.Where(entry => entry.Genre == genre);
      } 

      if (synopsis != null)
      {
        query = query.Where(entry => entry.Synopsis == synopsis);
      } 

      if (rottenTom != 0)
      {
        query = query.Where(entry => entry.RottenTom == rottenTom);
      }                

      return await query.ToListAsync();
    }

    // POST api/Movies
    [HttpPost]
    public async Task<ActionResult<Movie>> Post(Movie movie)
    {
      _db.Movies.Add(movie);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetMovie), new { id = movie.MovieId }, movie);
    }

    // GET: api/Movie/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovie(int id)
    {
      var movie = await _db.Movies.FindAsync(id);

      if (movie == null)
      {
        return NotFound();
      }

      return movie;
    }

    // PUT: api/Movie/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Movie movie)
      {
      if (id != movie.MovieId)
      {
        return BadRequest();
      }

      _db.Entry(movie).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MovieExists(id))
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
    private bool MovieExists(int id)
    {
      return _db.Movies.Any(e => e.MovieId == id);
    }

    // DELETE: api/Movies/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
      var movie = await _db.Movies.FindAsync(id);
      if (movie == null)
      {
        return NotFound();
      }

      _db.Movies.Remove(movie);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}