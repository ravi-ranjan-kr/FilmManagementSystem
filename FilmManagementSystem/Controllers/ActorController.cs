using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManagementSystem.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private ActorRepository ActorRepository;
        public ActorController()
        {
            ActorRepository = new ActorRepository();
        }
        [HttpGet, Route("GetActor")]
        public IActionResult GetAll() // getting actor data
        {
            return StatusCode(200, ActorRepository.GetActor());
        }
        [HttpGet, Route("GetActorByName/{firstname}")]
        public IActionResult GetActorname(string firstname) // getting actor data by firstname
        {
            return StatusCode(200, ActorRepository.GetActorName(firstname));
        }
        [HttpGet, Route("GetActorById/{id}")]
        public IActionResult GetActorId(string id) //getting data by id
        {
            return StatusCode(200, ActorRepository.GetActorid(id));
        }
        [HttpPost, Route("AddAlldetails")] // adding actor details
        public IActionResult AddActor(Actor actor)
        {
            ActorRepository.AddActor(actor);
            return StatusCode(200, "record added");
        }
        [HttpPut, Route("EditActor")] //updating actor details
        public IActionResult EditActor(Actor actor)
        {
            ActorRepository.EditActor(actor);
            return StatusCode(200, "record modified");
        }
        [HttpDelete, Route("Deleteactorbyid/{actorId}")] //deleting actor details by id
        public IActionResult Deleteactorbyid(string actorId)
        {
            ActorRepository.DeleteActor(actorId);
            return StatusCode(200, "record deleted");
        }

    }
}
