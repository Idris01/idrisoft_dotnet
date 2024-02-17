using Fintech.Models;
using Microsoft.EntityFrameworkCore;

namespace Fintech.Data
{
  public class FintechContext: DbContext
  {
    public DbSet<User> Users {get; set;} = null!;
    public DbSet<BankAccount> BankAccounts {get; set;} = null!;
    public DbSet<Transaction> Transactions {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(@"User ID=postgres;Password=9evergiveup;Host=localhost;Port=5432;Database=Fintech;");
    }
  }
}
