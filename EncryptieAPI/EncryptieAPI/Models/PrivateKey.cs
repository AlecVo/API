using System.ComponentModel.DataAnnotations;

namespace EncryptieAPI.Models
{
    public class PrivateKey
    {
        [Required]
        public string Key { get; set; } = string.Empty;
    }
}
