using System.ComponentModel.DataAnnotations;

namespace EncryptieAPI.Models
{
    public class Berichten 
    {
        public int id { get; set; }
        public string encryptedBericht { get; set; }
        public DateTime vervalDatum { get; set; } = 7;
        public DateTime aanmaakDatum { get; set; }

    }
}
