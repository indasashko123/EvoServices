using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interfaces;
using WalletService.Core;
using WalletService.Persistance.Configure;

namespace WalletService.Persistance
{
    public class WalletDbContext : DbContext, IWalletDbContext
    {
        public DbSet<Wallet> Wallets { get; set; }
        public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new Configuration());
            base.OnModelCreating(builder);
        }
    }
}