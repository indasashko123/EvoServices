using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interfaces;

namespace WalletService.Application.SQRS.Commands.UpdateBalance
{
    internal class UpdateBalanceHandler :BaseHandler, IRequestHandler<UpdateBalanceCommand>
    {
        public UpdateBalanceHandler(IWalletDbContext _context) : base(_context)
        {
        }

        public async Task<Unit> Handle(UpdateBalanceCommand request, CancellationToken cancellationToken)
        {
            var entity = await context.Wallets.FirstOrDefaultAsync(wallet => wallet.id == request.id, cancellationToken);
            if (entity == null) 
            {
                throw new Exception(); 
            }
            entity.updatedAt = DateTime.Now.ToLocalTime().ToString();
            entity.balance -= request.value;
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
