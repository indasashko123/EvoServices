using MediatR;
using WalletService.Application.Interfaces;
using WalletService.Core;

namespace WalletService.Application.SQRS.Commands.Create
{
    internal class CreateCommandHandler :BaseHandler, IRequestHandler<CreateCommand, int>
    {
        public CreateCommandHandler(IWalletDbContext _context) : base(_context) { }

        public async Task<int> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var entity = new Wallet
            {
                ownerId = request.OwnerId,
                balance = 0,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt = DateTime.Now.ToLocalTime().ToString(),
            };
            await context.Wallets.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return entity.id;
        }
    }
}
