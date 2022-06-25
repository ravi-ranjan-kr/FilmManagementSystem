using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading;
using FMS.DataOperation_fa.Models;

namespace FMS.DataOperation_fa
{
    public class FMSDataoperation
    {
        private readonly FMSDataOperation_faContext _context;
        public FMSDataoperation(FMSDataOperation_faContext context)
        {
            _context = context;
        }
        [FunctionName("PostFMS")]
        public async Task<IActionResult> PostFilmAsync(
    [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "Film/Add")] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP POST/post trigger function processed a request.");
            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                Film data = JsonConvert.DeserializeObject<Film>(requestBody);

                Film film = new Film
                {
                    FilmId = data.FilmId,
                    Description = data.Description,
                    Title = data.Title,
                    ReleaseYear = data.ReleaseYear,
                    LanguageId = data.LanguageId,
                    RentalDurationDays = data.RentalDurationDays,
                    LengthMins = data.LengthMins,
                    ReplacementCostCrores = data.ReplacementCostCrores,
                    Rating = data.Rating,
                    SpecialFeatures = data.SpecialFeatures,
                    ActorId = data.ActorId,
                    CategoryId = data.CategoryId
                };
                var entity = await _context.Films.AddAsync(film);
                await _context.SaveChangesAsync();
                return new OkObjectResult(JsonConvert.SerializeObject(entity.Entity));
            }
            catch (Exception ex)
            {
                log.LogError("exception occured;ExceptionDetail:" + ex.Message);
                log.LogError("exception occured;ExceptionDetail:" + ex.InnerException);
                log.LogError("exception occured;ExceptionDetail:" + ex);
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
