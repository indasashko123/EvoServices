using WalletService.Core;
using Microsoft.EntityFrameworkCore;

namespace WalletService.Application.Interfaces
{
    public interface IWalletDbContext
    {
        DbSet<Wallet> Wallets {get;set;}
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
