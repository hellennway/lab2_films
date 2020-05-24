using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using films.Models;

namespace films
{
    public class Validations
    {

    }
    public class CountryValid
    {
        FilmsContext _context;
        Country country;
        public CountryValid(FilmsContext _context, Country country)
        {
            this._context = _context;
            this.country = country;
        }
        public bool Valid()
        {
            var countries = _context.Country.Where(c => c.Name == country.Name).ToList();
            if (countries.Count != 0) if (countries.Count == 1)
                {
                    if (countries[0].CountryId == country.CountryId) return true;
                    else return false;
                }
                else return false;
            else return true;
        }
    }
    public class GenreValid
    {
        FilmsContext _context;
        Genre genre;
        public GenreValid(FilmsContext _context, Genre genre)
        {
            this._context = _context;
            this.genre = genre;
        }
        public bool Valid()
        {
            var genres = _context.Genre.Where(g => g.Name == genre.Name).ToList();
            if (genres.Count != 0) if (genres.Count == 1)
                {
                    if (genres[0].GenreId == genre.GenreId) return true;
                    else return false;
                }
                else return false;
            else return true;
        }
    }
    public class CompanyValid
    {
        FilmsContext _context;
        Company company;
        public CompanyValid(FilmsContext _context, Company company)
        {
            this._context = _context;
            this.company=company;
        }
        public bool Valid()
        {
            var companies = _context.Company.Where(c => c.Name == company.Name).ToList();
            if (companies.Count != 0) if (companies.Count == 1)
                {
                    if (companies[0].CompanyId == company.CompanyId) return true;
                    else return false;
                }
                else return false;
            else return true;
        }
    }
    public class DirectorValid
    {
        FilmsContext _context;
        Director director;
        public DirectorValid(FilmsContext _context, Director director)
        {
            this._context = _context;
            this.director=director;
        }
        public bool Valid()
        {
            var directors = _context.Director.Where(d => d.Name == director.Name).ToList();
            if (directors.Count != 0) if (directors.Count == 1)
                {
                    if (directors[0].DirectorId == director.DirectorId) return true;
                    else return false;
                }
                else return false;
            else return true;
        }
    }
    public class FilmValid
    {
        FilmsContext _context;
        Film film;
        public FilmValid(FilmsContext _context, Film film)
        {
            this._context = _context;
            this.film = film;
        }
        public bool Valid()
        {
            var films = _context.Film.Where(f => f.Name == film.Name &&( f.Year==film.Year || f.DirectorId==film.DirectorId)).ToList();
            if (films.Count != 0) if (films.Count == 1)
                {
                    if (films[0].FilmId == film.FilmId) return true;
                    else return false;
                }
                else return false;
            else return true;
        }
    }
    public class FilmGenreValid
    {
        FilmsContext _context;
        FilmGenre filmgenre;
        public FilmGenreValid(FilmsContext _context, FilmGenre filmgenre)
        {
            this._context = _context;
            this.filmgenre = filmgenre;
        }
       public bool Valid()
        {
            var filmgenres = _context.FilmGenre.Where(fg => fg.FilmId == filmgenre.FilmId &&
             fg.GenreId==filmgenre.GenreId).ToList();
            if (filmgenres.Count != 0) if (filmgenres.Count == 1)
                {
                    if (filmgenres[0].Id == filmgenre.Id) return true;
                    else return false;
                }
                else return false;
            else return true;
        }
    }

}
