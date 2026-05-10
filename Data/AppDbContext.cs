using Microsoft.EntityFrameworkCore;
using MeuCrud.Api.Models;

namespace MeuCrud.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}
