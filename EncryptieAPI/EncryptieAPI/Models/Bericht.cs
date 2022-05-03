using System.ComponentModel.DataAnnotations;

namespace EncryptieAPI.Models
{
    public class Bericht 
    {
        public Guid id { get; set; }
        public string encryptedBericht { get; set; }
        public int vervalDatum { get; set; } = 7;
        public DateTime aanmaakDatum { get; set;} =DateTime.Now;
        public bool isVervalt { get; set; } = false;

    }
}
