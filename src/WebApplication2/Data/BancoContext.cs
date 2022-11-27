using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data

{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }
           public DbSet<ContatoModel> Contatos { get; set; }

    }
}
