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
        private static List<Bericht> berichten = new List<Bericht>
        {
            new Bericht
            {
                id = Guid.NewGuid(),
                encryptedBericht = "def1ert4",
                aanmaakDatum = DateTime.Now,
                vervalDatum = 44,
                isVervalt = false

            }
        };

        [HttpPost("Opslaan bericht")]

        public async Task<ActionResult<List<Bericht>>> AddBericht(Bericht bericht)
        {
            berichten.Add(bericht);
            return Ok(bericht);
        }

        [HttpGet("Testen code")]
        public async Task<ActionResult<List<Bericht>>> Get()
        {
            return Ok(berichten);
        }

    }

}
