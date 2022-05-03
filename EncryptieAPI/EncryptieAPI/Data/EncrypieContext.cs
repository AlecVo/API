using EncryptieAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EncryptieAPI.Data
{
    public class EncrypieContext : DbContext
    {
        public EncrypieContext(DbContextOptions options) : base(options) { }

        public DbSet<Bericht> Berichten { get; set; }
    }
}
