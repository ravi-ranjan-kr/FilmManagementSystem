using FilmManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmManagementSystem.Repositories
{
    public class FilmRepository
    {
        private readonly FilmManagementSystemContext context;
        public FilmRepository(FilmManagementSystemContext DbContext)
        {
            context = DbContext;
        }
        public void AddFilm(Film film) //Add new row details to film table
        {
            context.Films.Add(film);
            context.SaveChanges();
        }

        public List<Film> GetAllFilm() // return list of Film
        {
            return context.Films.ToList();
        }
        public Film GetFilmTitle(string title) //Get Film details using title
        {
            Film film = context.Films.SingleOrDefault(s => s.Title == title);
            return film;
        }
        public List<Film> GetFilmByReleaseYear(int releaseYear) //Get Film by using releaseyear
        {
            List<Film> films = context.Films.Where(i => i.ReleaseYear == releaseYear).ToList();
            return films;

        }
        public List<Film> GetFilmByRating(decimal rating) //Get Film by using Rating
        {

            List<Film> films = context.Films.Where(f => f.Rating == rating).ToList();
            return films;
        }
        public List<Film> GetFilmActorId(string actorId) // get film actorid
        {
            List<Film> films = context.Films.Where(s => s.ActorId == actorId).ToList();
            return films;
        }
        public List<Film> GetFilmCategoryId(string categoryId) //get film by categoryid
        {
            List<Film> films = context.Films.Where(s => s.CategoryId == categoryId).ToList();
            return films;
        }
        public List<Film> GetFilmLanguageId(string languageId) //get film by languageid
        {
            List<Film> films = context.Films.Where(s => s.LanguageId == languageId).ToList();
            return films;
        }
        public void EditFilm(Film film)  // modifying film data 
        {
            context.Films.Update(film);
            context.SaveChanges();
        }

        public void DeleteFilmTitle(string title) //deleting film data by title
        {
            Film film = context.Films.SingleOrDefault(s => s.Title == title);
            context.Remove(film);
            context.SaveChanges();

        }
        public void DeleteFilmReleaseYear(int releaseYear) //deleting film data by releaseyear
        {

            List<Film> films = context.Films.Where(s => s.ReleaseYear == releaseYear).ToList();
            context.RemoveRange(films);
            context.SaveChanges();



        }
        public void DeleteFilmRating(decimal rating) //deleting film data by rating
        {
            List<Film> films = context.Films.Where(i => i.Rating == rating).ToList();
            context.RemoveRange(films);
            context.SaveChanges();


        }


    }
}