using Microsoft.EntityFrameworkCore;
using WalletService.Core;

namespace WalletService.Persistance
{
    public class WalletDbContext : DbContext
    {
        public DbSet<Wallet> DbSet { get; set;}
    }
}