using MediatR;
using WalletService.Core;

namespace WalletService.Application.SQRS.Querries.GetByOwner
{
    public class GetByOwnerQuery : IRequest<Wallet>
    {
        public int OwnerId { get; set; }
    }
}
