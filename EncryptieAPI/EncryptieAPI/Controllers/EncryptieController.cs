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
        private readonly EncrypieContext _dbContext;
        public EncryptieController(EncrypieContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("Opslaan bericht")]

        public async Task<ActionResult<List<Bericht>>> AddBericht(Bericht bericht)
        {
            _dbContext.Berichten.Add(bericht); //gaat berichten toevoegen in de database
            await _dbContext.SaveChangesAsync(); //gaat berichten opslaan in database

            return Ok(await _dbContext.Berichten.ToListAsync()); //gaat berichten tonen
        }

        [HttpPost("Testen code")]
        public async Task<ActionResult<Bericht>> OphalenBericht(Guid id)
        {
            var bericht = await _dbContext.Berichten.FindAsync(id); //gaat zoeken in de database met hetzelfde id dat opgegeven is
            if (bericht == null)
            {
                return BadRequest("Het bericht met dat id bestaat niet"); //als het bericht niet bestaat return foutmelding
            }
            else
            {
                _dbContext.Berichten.Remove(bericht);
                await _dbContext.SaveChangesAsync();
                return Ok(bericht); // bericht tonen
               
            }

        }
        [HttpGet("Testen code")]
        public async Task<ActionResult<Bericht>> OphalenBerichtenLijst()
        {
            return Ok(await _dbContext.Berichten.ToListAsync());//ophalen lijst van berichten
        }

    }

}
