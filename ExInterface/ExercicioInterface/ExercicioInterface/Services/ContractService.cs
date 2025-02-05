using ExercicioInterface.Entities;
namespace ExercicioInterface.Services;

internal class ContractService
{
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
        _onlinePaymentService = onlinePaymentService;
    }
    public void ProcessContract(Contract contract, int months)
    {
        double monthQuota = contract.TotalValue / months;
        for (int i = 0; i < months; i++)
        {
            DateTime date = contract.Date.AddMonths(i);
            double newQuota = monthQuota + _onlinePaymentService.Interest(monthQuota, i);
            double finalQuota = newQuota + _onlinePaymentService.PaymentFee(newQuota);
            contract.AddInstallment(new Installment(date, finalQuota));
        }
    }
}
