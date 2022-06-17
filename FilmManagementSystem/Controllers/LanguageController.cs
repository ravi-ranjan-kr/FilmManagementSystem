using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManagementSystem.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private LanguageRepository LanguageRepository;
        public LanguageController()
        {
            LanguageRepository = new LanguageRepository();
        }
        [HttpGet, Route("GetLanguage")]  // getting language details
        public IActionResult GetLanguage()
        {
            return StatusCode(200, LanguageRepository.GetLanguage());
        }
        [HttpGet, Route("GetLanguageByName/{languagename}")] //getting language details by language name
        public IActionResult GetId(string languageName)
        {
            return StatusCode(200, LanguageRepository.GetLanguagebyName(languageName));
        }
        [HttpPost, Route("AddLanguage")] //adding language details
        public IActionResult AddLanguage(Language language)
        {
            LanguageRepository.AddLanguage(language);
            return StatusCode(200, "record added");
        }
        [HttpPut, Route("EditLanguage")] //updating language details
        public IActionResult EditLanguage(Language language)
        {
            LanguageRepository.EditLanguage(language);
            return StatusCode(200, "record modified");
        }
        [HttpDelete, Route("DeleteLanguage/{languageId}")] //deleting language details by using id
        public IActionResult DeleteCategory(string languageId)
        {
            LanguageRepository.DeleteLanguage(languageId);
            return StatusCode(200, "record deleted");
        }
    }
}
