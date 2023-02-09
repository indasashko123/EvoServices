using WalletService.Application.Interfaces;

namespace WalletService.Application.SQRS
{
    internal abstract class BaseHandler
    {
        private protected IWalletDbContext context;
        public BaseHandler(IWalletDbContext _context) 
        {
            context = _context;
        }
    }
}
