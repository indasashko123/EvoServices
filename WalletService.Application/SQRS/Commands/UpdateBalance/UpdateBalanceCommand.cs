using MediatR;

namespace WalletService.Application.SQRS.Commands.UpdateBalance
{
    public class UpdateBalanceCommand : IRequest
    {
         public decimal value { get; set; }
         public int id { get; set; }
    }
}
