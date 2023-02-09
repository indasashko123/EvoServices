using MediatR;
using WalletService.Core;

namespace WalletService.Application.SQRS.Querries.GetAll
{
    public class GetAllQuery : IRequest<List<Wallet>>
    {

    }
}
