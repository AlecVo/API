using EncryptieAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EncryptieAPI.Data
{
    public class EncryptieDbContext : DbContext
    {
        public EncryptieDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Bericht> Berichten { get; set; }
    }
}
