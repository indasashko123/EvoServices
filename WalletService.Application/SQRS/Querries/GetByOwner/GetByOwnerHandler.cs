using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interfaces;
using WalletService.Core;

namespace WalletService.Application.SQRS.Querries.GetByOwner
{
    internal class GetByOwnerHandler : BaseHandler, IRequestHandler<GetByOwnerQuery, Wallet>
    {
        public GetByOwnerHandler(IWalletDbContext _context) : base(_context) { }
        public async Task<Wallet> Handle(GetByOwnerQuery request, CancellationToken cancellationToken)
        {
            var entity = await context.Wallets.FirstOrDefaultAsync(wallet => wallet.ownerId == request.OwnerId);
            if (entity == null) 
            {
                throw new ArgumentException();
            }
            return entity;
        }
    }
}
