using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        //Gaat gegevens ophalen HTTP => Openen met swagger, hier onder staat de code die opgehaalt kan worden

        private static List<SuperHero> heroes = new List<SuperHero>()
            {
                new SuperHero {
                Id = 1,
                Name = "Black Panther",
                FirstName = "TChalla ",
                LastName = "Wakanda",
                Place = "Wakanda"
                },
                new SuperHero {
                Id = 2,
                Name = "Spider-man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York"
                },
                new SuperHero {
                Id = 3,
                Name = "Iron-man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "New York"
                },
            };
        [HttpGet] //ophalen gegevens
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(heroes);
        }
        [HttpPost] //versturen van gegevens
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }
        [HttpGet("{id}")]// moet er staan omdat anders swagger het id vakje niet laat tonen, moet zelfde naam zijn als hieronder (int id)
        public async Task<ActionResult<SuperHero>> Get(int id) //gaat 1 held zoeken op id
        {
            var hero = heroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return BadRequest("Deze held bestaat niet! Kan niet gevonden worden."); //lijkt hard op een console.writeline
            }
            return Ok(hero);
        }
        [HttpPut] //Updaten van gegevens
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
            var hero = heroes.Find(x => x.Id == request.Id);
            if (hero == null)
            {
                return BadRequest("Deze held bestaat niet! Kan niet geupdate worden."); //lijkt hard op een console.writeline
            }
            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            return Ok(heroes);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> DeleteHero(int id)
        {
            var hero = heroes.Find(x =>x.Id == id);
            if (hero == null)
            {
                return BadRequest("Deze held bestaat niet, hij kan niet verwijdert worden.");
            }
            heroes.Remove(hero);
            return Ok(heroes);
        }

    }
}

