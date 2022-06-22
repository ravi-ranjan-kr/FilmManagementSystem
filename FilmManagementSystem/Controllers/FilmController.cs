using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private FilmRepository FilmRepository;
        private readonly ILogger<FilmController> _Logger;
        public FilmController(FilmRepository filmRepository, ILogger<FilmController> Logger)
        {
            FilmRepository = filmRepository;
            _Logger = Logger;
        }
        [HttpGet] //get all film data , Route("GetAllFilm")
        public IActionResult Get()
        {
            try
            {
                var films = FilmRepository.GetAllFilm();
                return Ok(films);
            }
            catch (Exception ex)
            {
                _Logger.LogError("exception occured;ExceptionDetail:" + ex.Message);
                _Logger.LogError("exception occured;ExceptionDetail:" + ex.InnerException);
                _Logger.LogError("exception occured;ExceptionDetail:" + ex);
                return BadRequest();
            }
        }
        [HttpGet, Route("GetFilmTitle/{title}")] //get all film data by title
        public IActionResult GetTitle(string title)
        {
            return StatusCode(200, FilmRepository.GetFilmTitle(title));
        }
        [HttpGet, Route("GetFilmByReleaseYear/{releaseYear}")] //get all film data by releaseyear
        public IActionResult GetreleaseYear(int releaseYear)
        {
            return StatusCode(200, FilmRepository.GetFilmByReleaseYear(releaseYear));
        }
        [HttpGet, Route("GetFilmByRating/{rating}")] //get all film data by rating
        public IActionResult GetFilmrating(decimal rating)
        {
            return StatusCode(200, FilmRepository.GetFilmByRating(rating));
        }
        [HttpGet, Route("GetFilmActorId/{actorId}")] //get all film data by actionid
        public IActionResult GetActorId(string actorId)
        {
            return StatusCode(200, FilmRepository.GetFilmActorId(actorId));
        }
        [HttpGet, Route("GetFilmCategoryId/{categoryId}")] //get all film data by categoryid
        public IActionResult GetCategoryId(string categoryId)
        {
            return StatusCode(200, FilmRepository.GetFilmCategoryId(categoryId));
        }
        [HttpGet, Route("GetFilmLanguageId/{languageId}")] //get all film data by languageid
        public IActionResult GetLanguageId(string languageId)
        {
            return StatusCode(200, FilmRepository.GetFilmLanguageId(languageId));
        }


        [HttpPost, Route("AddFilm")] // add film data
        public IActionResult Add(Film film)
        {
            FilmRepository.AddFilm(film);
            return StatusCode(200, "Record Added");
        }
        [HttpPut, Route("EditFilm")] //update film data
        public IActionResult Edit(Film film)
        {
            FilmRepository.EditFilm(film);
            return StatusCode(200, "Modified");
        }

        [HttpDelete, Route("DeleteFilmTitle/{title}")]  //delete film data by title
        public IActionResult DeletebyTitle(string title)
        {
            FilmRepository.DeleteFilmTitle(title);
            return StatusCode(200, "record deleted");
        }
        [HttpDelete, Route("DeleteFilmReleaseYear/{releaseYear}")]  //delete film data by releaseyear
        public IActionResult DeletebyReleaseYear(int releaseYear)
        {
            FilmRepository.DeleteFilmReleaseYear(releaseYear);
            return StatusCode(200, "record deleted");
        }
        [HttpDelete, Route("DeleteFilmRating/{rating}")]  //delete film data by rating
        public IActionResult DeletebyRating(decimal rating)
        {
            FilmRepository.DeleteFilmRating(rating);
            return StatusCode(200, "record deleted");
        }
    }
}
