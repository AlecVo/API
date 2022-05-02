using EncryptieAPI.Data;
using EncryptieAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EncryptieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptieController : ControllerBase
    {
        private readonly EncryptieDbContext dbContext;
        public EncryptieController(EncryptieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("Ophalen bericht")]

        public ActionResult<Berichten> OphalenEncryptedMessage(Guid Id)
        {
            Berichten berichten;
            //Ophalen bericht
            //Gegevens van het bericht invullen
            berichten.(b => b.id == Id && b.isVervalt = false)
            {

            }
            bericht.id = Id;
            bericht.aanmaakDatum = DateTime.Now;
            bericht.encryptedBericht =




        }

    }

}
