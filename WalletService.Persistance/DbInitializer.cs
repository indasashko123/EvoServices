namespace WalletService.Persistance
{
    public  class DbInitializer
    {
        public static void Initialize(WalletDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
