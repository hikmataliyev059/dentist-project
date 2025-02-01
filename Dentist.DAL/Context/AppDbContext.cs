using Dentist.Core;
using Microsoft.EntityFrameworkCore;

namespace Dentist.DAL.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Position> Positions { get; set; }
    public DbSet<Agent> Agents { get; set; }
}