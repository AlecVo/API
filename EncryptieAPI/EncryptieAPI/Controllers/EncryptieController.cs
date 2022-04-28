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
            new Bericht { id = 1, date = DateTime.Now, Ebericht = "Hallo"},
            new Bericht { id = 2, date = DateTime.Now, Ebericht = "iets"},
            new Bericht { id = 3, date = DateTime.Now, Ebericht = "Test"},
        };

        [HttpGet("BerichtLezen")]
        public async Task<ActionResult<List<Bericht>>> get()
        {
            return Ok(berichten);
        }
        //laat de berichten zien
        //TODO: database koppelen en zien hoe dat de api het juiste bericht ophaalt.
        [HttpPost("BerichtToevoegen")]

        public async Task<ActionResult<List<Bericht>>> AddPrivateKey(Bericht bericht)
        {
            berichten.Add(bericht);
            return Ok(berichten);
        }
        //Voegt een bericht toe 
        //TODO: Database koppelen zodat het berichten gaat opslaan in de databank
        [HttpGet("LinkLezen")]
        public async Task<ActionResult<List<PrivateKey>>> get(string link)
        {
            return Ok(berichten);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Bericht>>> Delete(int id)
        {
            var bericht = berichten.Find(b => b.id == id);//Bericht is bericht waar bericht id hetzelfde is als het ingegeven id
            if (bericht == null)
            {
                return BadRequest("Hero met dit id is niet gevonden");
            }
            berichten.Remove(bericht);
            return Ok(berichten);
        }
        //gaat berichten verwijderen op id.
        //TODO: Berichten verwijderen nadat een tijdsbepaling overschreden is => bij een bericht dateTime toevoegen en een verwijder datum.
        //daarna op basis van tijd en het bericht id word het verwijdert van de database.
    }
}
