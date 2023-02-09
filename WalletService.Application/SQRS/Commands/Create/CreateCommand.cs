
using MediatR;

namespace WalletService.Application.SQRS.Commands.Create
{
    public class CreateCommand : IRequest<int>
    {
        public int OwnerId { get; set; }

    }
}
