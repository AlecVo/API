using System.ComponentModel.DataAnnotations;

namespace EncryptieAPI.Models
{
    public class Bericht
    {
        [Required]
        public string Ebericht { get; set; } = string.Empty;
        public int id { get; set; }
        public DateTime date { get; set; }

    }
}
