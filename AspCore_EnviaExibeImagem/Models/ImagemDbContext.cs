using Microsoft.EntityFrameworkCore;

namespace AspNetCore_EnviaExibeImagem.Models
{
    public class ImagemDbContext : DbContext
    {
        public ImagemDbContext(DbContextOptions<ImagemDbContext> options) : base(options)
        { }

        public DbSet<Imagem> Imagens { get; set; }
    }
}
