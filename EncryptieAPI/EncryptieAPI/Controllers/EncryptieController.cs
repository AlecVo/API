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

        [HttpPost("Opslaan bericht")]

        public async Task<ActionResult<List<Bericht>>> AddBericht()
        {
            var bericht = new List<Bericht>
            { 
                new Bericht
                {

                }
            };
            return Ok(bericht);
        }

    }

}
