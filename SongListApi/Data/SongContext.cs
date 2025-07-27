using Microsoft.EntityFrameworkCore;
using SongListApi.Models;

namespace SongListApi.Data
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options) { }

        public DbSet<Song> Songs { get; set; }
    }
}
