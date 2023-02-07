using Microsoft.EntityFrameworkCore;
using WalletService.Core;

namespace WalletService.Persistance.Configure
{
    public class Configuration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(w => w.id);
            builder.HasIndex(w => w.id).IsUnique();
        }
    }
}
