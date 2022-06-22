using FilmManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace FilmManagementSystem.Repositories
{
    public class ActorRepository
    {
        private readonly FilmManagementSystemContext context;
        public ActorRepository(FilmManagementSystemContext DbContext)
        {
            context = DbContext;
        }
        public void AddActor(Actor actor)   //Add row details to actor table
        {
            context.Actors.Add(actor);
            context.SaveChanges();
        }
        public List<Actor> GetActor() //Get the actor details
        {
            return context.Actors.ToList();
        }
        public Actor GetActorName(string firstname) // Get actor details by firstname
        {
            Actor actor = context.Actors.SingleOrDefault(s => s.FirstName == firstname);
            return actor;
        }
        public Actor GetActorid(string id) //Get Actor details by id
        {
            Actor actor = context.Actors.Find(id);
            return actor;
        }

        public void EditActor(Actor actor) // Edit Actor details 
        {
            context.Actors.Update(actor);
            context.SaveChanges();

        }
        public void DeleteActor(string id) // Delete Actor details by id
        {
            Actor actor = context.Actors.Find(id);
            context.Actors.Remove(actor);
            context.SaveChanges();

        }

    }
}
