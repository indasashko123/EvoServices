using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interfaces;
using WalletService.Core;

namespace WalletService.Application.SQRS.Querries.GetAll
{
    internal class GetAllHandler : BaseHandler, IRequestHandler<GetAllQuery, List<Wallet>>
    {
        public GetAllHandler(IWalletDbContext _context) : base(_context)
        {
        }
        public async Task<List<Wallet>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            return await context.Wallets.ToListAsync(cancellationToken);
        }
    }
}
